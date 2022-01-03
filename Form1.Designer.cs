namespace SpriteCompression
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.InputGroupbox = new System.Windows.Forms.GroupBox();
            this.MapResLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.MapColorCountLabel = new System.Windows.Forms.Label();
            this.SpriteResLabel = new System.Windows.Forms.Label();
            this.SpriteCountLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.PathTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FilterGroupbox = new System.Windows.Forms.GroupBox();
            this.ProcessFilterButton = new System.Windows.Forms.Button();
            this.rbBlue = new System.Windows.Forms.RadioButton();
            this.rbGreen = new System.Windows.Forms.RadioButton();
            this.rbRed = new System.Windows.Forms.RadioButton();
            this.FilterCheckbox = new System.Windows.Forms.CheckBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.SpritemapBox = new System.Windows.Forms.PictureBox();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.FilteredBox = new System.Windows.Forms.PictureBox();
            this.ColorPaletteBox = new System.Windows.Forms.PictureBox();
            this.FolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.InputGroupbox.SuspendLayout();
            this.FilterGroupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpritemapBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FilteredBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorPaletteBox)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.flowLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(871, 685);
            this.splitContainer1.SplitterDistance = 320;
            this.splitContainer1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.InputGroupbox);
            this.flowLayoutPanel1.Controls.Add(this.FilterGroupbox);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(320, 685);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // InputGroupbox
            // 
            this.InputGroupbox.Controls.Add(this.MapResLabel);
            this.InputGroupbox.Controls.Add(this.label8);
            this.InputGroupbox.Controls.Add(this.MapColorCountLabel);
            this.InputGroupbox.Controls.Add(this.SpriteResLabel);
            this.InputGroupbox.Controls.Add(this.SpriteCountLabel);
            this.InputGroupbox.Controls.Add(this.label4);
            this.InputGroupbox.Controls.Add(this.label3);
            this.InputGroupbox.Controls.Add(this.label2);
            this.InputGroupbox.Controls.Add(this.BrowseButton);
            this.InputGroupbox.Controls.Add(this.PathTextbox);
            this.InputGroupbox.Controls.Add(this.label1);
            this.InputGroupbox.Location = new System.Drawing.Point(3, 3);
            this.InputGroupbox.Name = "InputGroupbox";
            this.InputGroupbox.Size = new System.Drawing.Size(317, 147);
            this.InputGroupbox.TabIndex = 0;
            this.InputGroupbox.TabStop = false;
            this.InputGroupbox.Text = "Input";
            // 
            // MapResLabel
            // 
            this.MapResLabel.AutoSize = true;
            this.MapResLabel.Location = new System.Drawing.Point(137, 113);
            this.MapResLabel.Name = "MapResLabel";
            this.MapResLabel.Size = new System.Drawing.Size(24, 13);
            this.MapResLabel.TabIndex = 10;
            this.MapResLabel.Text = "0x0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Spritemap Resolution:";
            // 
            // MapColorCountLabel
            // 
            this.MapColorCountLabel.AutoSize = true;
            this.MapColorCountLabel.Location = new System.Drawing.Point(137, 89);
            this.MapColorCountLabel.Name = "MapColorCountLabel";
            this.MapColorCountLabel.Size = new System.Drawing.Size(13, 13);
            this.MapColorCountLabel.TabIndex = 8;
            this.MapColorCountLabel.Text = "0";
            // 
            // SpriteResLabel
            // 
            this.SpriteResLabel.AutoSize = true;
            this.SpriteResLabel.Location = new System.Drawing.Point(137, 67);
            this.SpriteResLabel.Name = "SpriteResLabel";
            this.SpriteResLabel.Size = new System.Drawing.Size(24, 13);
            this.SpriteResLabel.TabIndex = 7;
            this.SpriteResLabel.Text = "0x0";
            // 
            // SpriteCountLabel
            // 
            this.SpriteCountLabel.AutoSize = true;
            this.SpriteCountLabel.Location = new System.Drawing.Point(137, 45);
            this.SpriteCountLabel.Name = "SpriteCountLabel";
            this.SpriteCountLabel.Size = new System.Drawing.Size(13, 13);
            this.SpriteCountLabel.TabIndex = 6;
            this.SpriteCountLabel.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Spritemap Colour Count:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sprite Resolution:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sprite Count:";
            // 
            // BrowseButton
            // 
            this.BrowseButton.Location = new System.Drawing.Point(285, 13);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(26, 20);
            this.BrowseButton.TabIndex = 2;
            this.BrowseButton.Text = "...";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // PathTextbox
            // 
            this.PathTextbox.Location = new System.Drawing.Point(104, 13);
            this.PathTextbox.Name = "PathTextbox";
            this.PathTextbox.Size = new System.Drawing.Size(175, 20);
            this.PathTextbox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Spritemap Folder:";
            // 
            // FilterGroupbox
            // 
            this.FilterGroupbox.Controls.Add(this.ProcessFilterButton);
            this.FilterGroupbox.Controls.Add(this.rbBlue);
            this.FilterGroupbox.Controls.Add(this.rbGreen);
            this.FilterGroupbox.Controls.Add(this.rbRed);
            this.FilterGroupbox.Controls.Add(this.FilterCheckbox);
            this.FilterGroupbox.Enabled = false;
            this.FilterGroupbox.Location = new System.Drawing.Point(3, 156);
            this.FilterGroupbox.Name = "FilterGroupbox";
            this.FilterGroupbox.Size = new System.Drawing.Size(317, 190);
            this.FilterGroupbox.TabIndex = 1;
            this.FilterGroupbox.TabStop = false;
            this.FilterGroupbox.Text = "Filter";
            // 
            // ProcessFilterButton
            // 
            this.ProcessFilterButton.Location = new System.Drawing.Point(9, 111);
            this.ProcessFilterButton.Name = "ProcessFilterButton";
            this.ProcessFilterButton.Size = new System.Drawing.Size(75, 23);
            this.ProcessFilterButton.TabIndex = 6;
            this.ProcessFilterButton.Text = "process";
            this.ProcessFilterButton.UseVisualStyleBackColor = true;
            this.ProcessFilterButton.Click += new System.EventHandler(this.ProcessFilterButton_Click);
            // 
            // rbBlue
            // 
            this.rbBlue.AutoSize = true;
            this.rbBlue.Location = new System.Drawing.Point(9, 88);
            this.rbBlue.Name = "rbBlue";
            this.rbBlue.Size = new System.Drawing.Size(46, 17);
            this.rbBlue.TabIndex = 5;
            this.rbBlue.TabStop = true;
            this.rbBlue.Text = "Blue";
            this.rbBlue.UseVisualStyleBackColor = true;
            // 
            // rbGreen
            // 
            this.rbGreen.AutoSize = true;
            this.rbGreen.Location = new System.Drawing.Point(9, 65);
            this.rbGreen.Name = "rbGreen";
            this.rbGreen.Size = new System.Drawing.Size(54, 17);
            this.rbGreen.TabIndex = 3;
            this.rbGreen.TabStop = true;
            this.rbGreen.Text = "Green";
            this.rbGreen.UseVisualStyleBackColor = true;
            // 
            // rbRed
            // 
            this.rbRed.AutoSize = true;
            this.rbRed.Location = new System.Drawing.Point(9, 42);
            this.rbRed.Name = "rbRed";
            this.rbRed.Size = new System.Drawing.Size(45, 17);
            this.rbRed.TabIndex = 2;
            this.rbRed.TabStop = true;
            this.rbRed.Text = "Red";
            this.rbRed.UseVisualStyleBackColor = true;
            // 
            // FilterCheckbox
            // 
            this.FilterCheckbox.AutoSize = true;
            this.FilterCheckbox.Enabled = false;
            this.FilterCheckbox.Location = new System.Drawing.Point(12, 19);
            this.FilterCheckbox.Name = "FilterCheckbox";
            this.FilterCheckbox.Size = new System.Drawing.Size(59, 17);
            this.FilterCheckbox.TabIndex = 0;
            this.FilterCheckbox.Text = "Enable";
            this.FilterCheckbox.UseVisualStyleBackColor = true;
            this.FilterCheckbox.CheckedChanged += new System.EventHandler(this.FilterCheckbox_CheckedChanged);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.SpritemapBox);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(547, 685);
            this.splitContainer2.SplitterDistance = 333;
            this.splitContainer2.TabIndex = 0;
            // 
            // SpritemapBox
            // 
            this.SpritemapBox.BackColor = System.Drawing.SystemColors.Control;
            this.SpritemapBox.BackgroundImage = global::SpriteCompression.Properties.Resources.tile;
            this.SpritemapBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpritemapBox.Location = new System.Drawing.Point(0, 0);
            this.SpritemapBox.Name = "SpritemapBox";
            this.SpritemapBox.Size = new System.Drawing.Size(547, 333);
            this.SpritemapBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SpritemapBox.TabIndex = 0;
            this.SpritemapBox.TabStop = false;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.FilteredBox);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.ColorPaletteBox);
            this.splitContainer3.Size = new System.Drawing.Size(547, 348);
            this.splitContainer3.SplitterDistance = 276;
            this.splitContainer3.TabIndex = 0;
            // 
            // FilteredBox
            // 
            this.FilteredBox.BackgroundImage = global::SpriteCompression.Properties.Resources.tile;
            this.FilteredBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FilteredBox.Location = new System.Drawing.Point(0, 0);
            this.FilteredBox.Name = "FilteredBox";
            this.FilteredBox.Size = new System.Drawing.Size(276, 348);
            this.FilteredBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FilteredBox.TabIndex = 0;
            this.FilteredBox.TabStop = false;
            // 
            // ColorPaletteBox
            // 
            this.ColorPaletteBox.BackgroundImage = global::SpriteCompression.Properties.Resources.tile;
            this.ColorPaletteBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ColorPaletteBox.Location = new System.Drawing.Point(0, 0);
            this.ColorPaletteBox.Name = "ColorPaletteBox";
            this.ColorPaletteBox.Size = new System.Drawing.Size(267, 348);
            this.ColorPaletteBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ColorPaletteBox.TabIndex = 0;
            this.ColorPaletteBox.TabStop = false;
            // 
            // FolderDialog
            // 
            this.FolderDialog.ShowNewFolderButton = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 685);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Spritemap Compression";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.InputGroupbox.ResumeLayout(false);
            this.InputGroupbox.PerformLayout();
            this.FilterGroupbox.ResumeLayout(false);
            this.FilterGroupbox.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SpritemapBox)).EndInit();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FilteredBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorPaletteBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox InputGroupbox;
        private System.Windows.Forms.Label MapResLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label MapColorCountLabel;
        private System.Windows.Forms.Label SpriteResLabel;
        private System.Windows.Forms.Label SpriteCountLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.TextBox PathTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.PictureBox SpritemapBox;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.PictureBox FilteredBox;
        private System.Windows.Forms.PictureBox ColorPaletteBox;
        private System.Windows.Forms.FolderBrowserDialog FolderDialog;
        private System.Windows.Forms.GroupBox FilterGroupbox;
        private System.Windows.Forms.RadioButton rbBlue;
        private System.Windows.Forms.RadioButton rbGreen;
        private System.Windows.Forms.RadioButton rbRed;
        private System.Windows.Forms.CheckBox FilterCheckbox;
        private System.Windows.Forms.Button ProcessFilterButton;
    }
}

