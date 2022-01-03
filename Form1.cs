using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SpriteCompression
{
    public partial class Form1 : Form
    {
        private Bitmap gReducedMap;
        private Bitmap gProcessedRMap;
        private List<Color> gColorMap;

        public Form1()
        {
            InitializeComponent();
            FolderDialog.SelectedPath = Application.StartupPath; //Easier to navigate if we start here
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            var dResult = FolderDialog.ShowDialog();

            if (dResult == DialogResult.OK)
            {
                PathTextbox.Text = FolderDialog.SelectedPath;

                var files = System.IO.Directory.EnumerateFiles(PathTextbox.Text);

                LoadSprites(files);

                FilterGroupbox.Enabled = true;
            }
        }

        private void ProcessRMap()
        {
            gProcessedRMap = new Bitmap(gReducedMap);

            for (int x = 0; x < gProcessedRMap.Width; ++x)
            {
                for (int y = 0; y < gProcessedRMap.Height; ++y)
                {
                    Color pixel = gProcessedRMap.GetPixel(x, y);

                    int channelIndex = rbRed.Checked ? pixel.R : rbGreen.Checked ? pixel.G : rbBlue.Checked ? pixel.B : 0;
                    if (channelIndex > gColorMap.Count) channelIndex = 0;

                    Color pixelColor = gColorMap[channelIndex];

                    gProcessedRMap.SetPixel(x, y, pixelColor);
                }
            }

            //Update
            FilteredBox.Image = gProcessedRMap;
        }

        private void GenerateColourPallet(List<Color> _colours)
        {
            //New canvas
            Bitmap canvas = new Bitmap(16, 16);

            //Set the pixels as the pallet data or up to 256 colours
            for (var i = 0; i < _colours.Count && i < 255; ++i)
            {
                var col = i % 16;
                var row = (int)Math.Floor(i / 16.0);
                canvas.SetPixel(col, row, _colours[i]);
            }

            //Bloated test to resize the pallet for better viewing
            int canvasSize = 256;
            Bitmap dummyCanvas = new Bitmap(canvasSize, canvasSize);
            Graphics gInstance = Graphics.FromImage(dummyCanvas);

            //Draw the pallet onto a larger canvas
            for (var i = 0; i < _colours.Count && i < 255; ++i)
            {
                var col = i % 16;
                var row = (int)Math.Floor(i / 16.0);
                gInstance.FillRectangle(new SolidBrush(_colours[i]), col * (canvasSize / 16), row * (canvasSize / 16), (canvasSize / 16), (canvasSize / 16));
            }

            gInstance.Flush();

            //Apply
            ColorPaletteBox.Image = dummyCanvas;
        }

        private void DrawImageToChannel(ref Bitmap _canvas, Bitmap _sprite, List<Color> _colourPallet, int _x, int _y, uint _mask)
        {
            for (int x = 0; x < _sprite.Width; ++x)
            {
                for (int y = 0; y < _sprite.Height; ++y)
                {
                    int uniqueIndex = _colourPallet.IndexOf(_sprite.GetPixel(x, y));
                    if (uniqueIndex == -1) uniqueIndex = 0; //Colour not found, leave pixel alone as it might be stacked

                    //Store canvas color
                    Color pixel = _canvas.GetPixel(_x + x, _y + y);

                    switch (_mask)
                    {
                        case 0x00FF0000:
                            _canvas.SetPixel(_x + x, _y + y, Color.FromArgb(255, uniqueIndex, pixel.G, pixel.B));
                            break;

                        case 0x0000FF00:
                            _canvas.SetPixel(_x + x, _y + y, Color.FromArgb(255, pixel.R, uniqueIndex, pixel.B));
                            break;

                        case 0x000000FF:
                            _canvas.SetPixel(_x + x, _y + y, Color.FromArgb(255, pixel.R, pixel.G, uniqueIndex));
                            break;

                        default:
                            //Invalid Mask
                            break;
                    }
                }
            }
        }

        private void ReduceSpriteMap(List<Bitmap> _sprites, List<Color> _colourPallet)
        {
            //Calculate the resolution of the first sprite
            int width = _sprites[0].Width;
            int height = _sprites[0].Height;

            //Create spritemap
            //Calculate map size
            int supportedChannels = 3;
            int rows, cols;
            rows = (int)Math.Ceiling(Math.Sqrt((double)_sprites.Count / (double)supportedChannels));
            cols = (int)Math.Ceiling(Math.Sqrt((double)_sprites.Count / (double)supportedChannels));

            //Build canvas
            Bitmap canvas = new Bitmap(width * rows, height * cols);
            canvas.SetResolution(_sprites[0].HorizontalResolution, _sprites[0].VerticalResolution);

            //Draw images to canvas
            for (int i = 0; i < _sprites.Count; ++i)
            {
                var col = i % cols;
                var row = (int)Math.Floor(i / (double)cols) % rows;

                switch (i % 3)
                {
                    case 0:
                        DrawImageToChannel(ref canvas, _sprites[i], _colourPallet, width * row, height * col, 0x00FF0000);
                        break;
                    case 1:
                        DrawImageToChannel(ref canvas, _sprites[i], _colourPallet, width * row, height * col, 0x0000FF00);
                        break;
                    default:
                        DrawImageToChannel(ref canvas, _sprites[i], _colourPallet, width * row, height * col, 0x000000FF);
                        break;
                }
            }

            //Apply canvas
            FilteredBox.Image = canvas;

            //Globals
            gReducedMap = canvas;
        }

        private void LoadSprites(IEnumerable<string> _files)
        {
            //Create new bitmap storage
            var bitmaps = new List<Bitmap>();

            //Load in the images found in the directory
            foreach (var file in _files)
            {
                if (System.IO.Path.GetExtension(file) == ".png")
                {
                    bitmaps.Add(new Bitmap(file));
                }
            }

            //Calculate the resolution of the first sprite
            int width = 0, height = 0;
            if (bitmaps.Count() > 0)
            {
                width = bitmaps[0].Width;
                height = bitmaps[0].Height;
            }

            //Calculate the number of colours distributed across all the sprites
            var uniqueColours = new List<Color>();
            uniqueColours.Add(Color.FromArgb(0, 0, 0, 0)); //BG Layer (pallet ID zero) is protected
            foreach (var sprite in bitmaps)
            {
                for (var x = 0; x < sprite.Width; ++x)
                {
                    for (var y = 0; y < sprite.Height; ++y)
                    {
                        Color pixel = sprite.GetPixel(x, y);

                        //Ignore transparent
                        if (pixel.A < 0xFE)
                        {
                            //Clean image
                            sprite.SetPixel(x, y, uniqueColours[0]); //set as background colour
                            continue;
                        }

                        bool bLikeColour = false;

                        foreach (var colour in uniqueColours)
                        {
                            float hTolerance = 20.0f; //In degrees
                            float sTolerance = 0.1f;
                            float bTolerance = 0.1f;

                            //Wraparound issue on hue
                            if (colour.GetHue() > pixel.GetHue() - hTolerance && colour.GetHue() < pixel.GetHue() + hTolerance)
                            {
                                if (colour.GetSaturation() > pixel.GetSaturation() - sTolerance && colour.GetSaturation() < pixel.GetSaturation() + sTolerance)
                                {
                                    if (colour.GetBrightness() > pixel.GetBrightness() - bTolerance && colour.GetBrightness() < pixel.GetBrightness() + bTolerance)
                                    {
                                        //Like-colour
                                        bLikeColour = true;

                                        //Test set pixel to limit colour pallet
                                        sprite.SetPixel(x, y, colour);

                                        break;
                                    }
                                }
                            }
                        }

                        if (!bLikeColour)
                        {
                            uniqueColours.Add(pixel);
                        }
                    }
                }
            }

            //Create spritemap
            //Calculate map size
            int rows, cols;
            rows = (int)Math.Ceiling(Math.Sqrt(bitmaps.Count));
            cols = (int)Math.Floor(Math.Sqrt(bitmaps.Count));

            //Build canvas
            Bitmap canvas = new Bitmap(width * rows, height * cols);
            canvas.SetResolution(bitmaps[0].HorizontalResolution, bitmaps[0].VerticalResolution);
            Graphics gInstance = Graphics.FromImage(canvas);

            //Draw images to canvas
            for (var row = 0; row < rows; ++row)
            {
                for (var col = 0; col < cols; ++col)
                {
                    var spriteIndex = (row * cols) + col;

                    if (spriteIndex >= bitmaps.Count) continue; //Crude skip out of the for loops

                    //Load bitmap into the graphics system
                    gInstance.DrawImage(bitmaps[spriteIndex], width * row, height * col);
                }
            }

            //Finalize Canvas
            gInstance.Flush();

            //Apply canvas
            SpritemapBox.Image = canvas;

            //Text updates
            SpriteCountLabel.Text = bitmaps.Count.ToString();
            SpriteResLabel.Text = width.ToString() + "x" + height.ToString();
            MapColorCountLabel.Text = uniqueColours.Count.ToString();
            MapResLabel.Text = canvas.Width.ToString() + "x" + canvas.Height.ToString();

            //Create pallet canvas
            GenerateColourPallet(uniqueColours);

            //Reduce map
            ReduceSpriteMap(bitmaps, uniqueColours);

            //Set Globals
            gColorMap = uniqueColours;
        }

        private void FilterCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            //Swap between processed and unprocessed
            FilteredBox.Image = FilterCheckbox.Checked ? gProcessedRMap : gReducedMap;
        }

        private void ProcessFilterButton_Click(object sender, EventArgs e)
        {
            FilterCheckbox.Enabled = true;
            FilterCheckbox.Checked = true;
            ProcessRMap();
        }
    }
}