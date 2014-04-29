namespace RoboOps.Interface
{
    partial class VideoPanel
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
            this.imgVideo = new System.Windows.Forms.PictureBox();
            this.lblFps = new System.Windows.Forms.Label();
            this.barFps = new System.Windows.Forms.TrackBar();
            this.lblBarFps = new System.Windows.Forms.Label();
            this.barWidth = new System.Windows.Forms.TrackBar();
            this.barHeight = new System.Windows.Forms.TrackBar();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.btnApply = new System.Windows.Forms.Button();
            this.rbtnCam2 = new System.Windows.Forms.RadioButton();
            this.rbtnCam1 = new System.Windows.Forms.RadioButton();
            this.rbtnCam3 = new System.Windows.Forms.RadioButton();
            this.rbtnCam4 = new System.Windows.Forms.RadioButton();
            this.rbtnCam5 = new System.Windows.Forms.RadioButton();
            this.barPan = new System.Windows.Forms.TrackBar();
            this.barTilt = new System.Windows.Forms.TrackBar();
            this.barZoom = new System.Windows.Forms.TrackBar();
            this.lblPan = new System.Windows.Forms.Label();
            this.lblTilt = new System.Windows.Forms.Label();
            this.lblZoom = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgVideo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barFps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barPan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barTilt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barZoom)).BeginInit();
            this.SuspendLayout();
            // 
            // imgVideo
            // 
            this.imgVideo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imgVideo.Cursor = System.Windows.Forms.Cursors.Default;
            this.imgVideo.Location = new System.Drawing.Point(0, 0);
            this.imgVideo.Name = "imgVideo";
            this.imgVideo.Size = new System.Drawing.Size(696, 536);
            this.imgVideo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgVideo.TabIndex = 0;
            this.imgVideo.TabStop = false;
            // 
            // lblFps
            // 
            this.lblFps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFps.AutoSize = true;
            this.lblFps.Location = new System.Drawing.Point(818, 9);
            this.lblFps.Name = "lblFps";
            this.lblFps.Size = new System.Drawing.Size(21, 13);
            this.lblFps.TabIndex = 20;
            this.lblFps.Text = "fps";
            // 
            // barFps
            // 
            this.barFps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.barFps.Location = new System.Drawing.Point(810, 67);
            this.barFps.Maximum = 30;
            this.barFps.Minimum = 1;
            this.barFps.Name = "barFps";
            this.barFps.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.barFps.Size = new System.Drawing.Size(45, 104);
            this.barFps.TabIndex = 21;
            this.barFps.Value = 30;
            this.barFps.ValueChanged += new System.EventHandler(this.barFps_ValueChanged);
            // 
            // lblBarFps
            // 
            this.lblBarFps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBarFps.AutoSize = true;
            this.lblBarFps.Location = new System.Drawing.Point(811, 48);
            this.lblBarFps.Name = "lblBarFps";
            this.lblBarFps.Size = new System.Drawing.Size(21, 13);
            this.lblBarFps.TabIndex = 22;
            this.lblBarFps.Text = "fps";
            // 
            // barWidth
            // 
            this.barWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.barWidth.LargeChange = 128;
            this.barWidth.Location = new System.Drawing.Point(750, 207);
            this.barWidth.Maximum = 1024;
            this.barWidth.Minimum = 1;
            this.barWidth.Name = "barWidth";
            this.barWidth.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.barWidth.Size = new System.Drawing.Size(45, 104);
            this.barWidth.TabIndex = 23;
            this.barWidth.Value = 1024;
            this.barWidth.ValueChanged += new System.EventHandler(this.barWidth_ValueChanged);
            // 
            // barHeight
            // 
            this.barHeight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.barHeight.LargeChange = 128;
            this.barHeight.Location = new System.Drawing.Point(816, 207);
            this.barHeight.Maximum = 1024;
            this.barHeight.Minimum = 1;
            this.barHeight.Name = "barHeight";
            this.barHeight.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.barHeight.Size = new System.Drawing.Size(45, 104);
            this.barHeight.TabIndex = 24;
            this.barHeight.Value = 1024;
            this.barHeight.ValueChanged += new System.EventHandler(this.barHeight_ValueChanged);
            // 
            // lblWidth
            // 
            this.lblWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(748, 188);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(24, 13);
            this.lblWidth.TabIndex = 25;
            this.lblWidth.Text = "W: ";
            // 
            // lblHeight
            // 
            this.lblHeight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(817, 188);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(21, 13);
            this.lblHeight.TabIndex = 26;
            this.lblHeight.Text = "H: ";
            // 
            // btnApply
            // 
            this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApply.Location = new System.Drawing.Point(749, 459);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 27;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            this.btnApply.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnApply_MouseClick);
            // 
            // rbtnCam2
            // 
            this.rbtnCam2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbtnCam2.AutoSize = true;
            this.rbtnCam2.Location = new System.Drawing.Point(724, 77);
            this.rbtnCam2.Name = "rbtnCam2";
            this.rbtnCam2.Size = new System.Drawing.Size(70, 17);
            this.rbtnCam2.TabIndex = 29;
            this.rbtnCam2.Text = "Camera 2";
            this.rbtnCam2.UseVisualStyleBackColor = true;
            this.rbtnCam2.CheckedChanged += new System.EventHandler(this.rbtnCam_Click);
            // 
            // rbtnCam1
            // 
            this.rbtnCam1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbtnCam1.AutoSize = true;
            this.rbtnCam1.Checked = true;
            this.rbtnCam1.Location = new System.Drawing.Point(724, 53);
            this.rbtnCam1.Name = "rbtnCam1";
            this.rbtnCam1.Size = new System.Drawing.Size(70, 17);
            this.rbtnCam1.TabIndex = 28;
            this.rbtnCam1.TabStop = true;
            this.rbtnCam1.Text = "Camera 1";
            this.rbtnCam1.UseVisualStyleBackColor = true;
            this.rbtnCam1.CheckedChanged += new System.EventHandler(this.rbtnCam_Click);
            // 
            // rbtnCam3
            // 
            this.rbtnCam3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbtnCam3.AutoSize = true;
            this.rbtnCam3.Location = new System.Drawing.Point(724, 101);
            this.rbtnCam3.Name = "rbtnCam3";
            this.rbtnCam3.Size = new System.Drawing.Size(70, 17);
            this.rbtnCam3.TabIndex = 30;
            this.rbtnCam3.Text = "Camera 3";
            this.rbtnCam3.UseVisualStyleBackColor = true;
            this.rbtnCam3.CheckedChanged += new System.EventHandler(this.rbtnCam_Click);
            // 
            // rbtnCam4
            // 
            this.rbtnCam4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbtnCam4.AutoSize = true;
            this.rbtnCam4.Location = new System.Drawing.Point(724, 127);
            this.rbtnCam4.Name = "rbtnCam4";
            this.rbtnCam4.Size = new System.Drawing.Size(70, 17);
            this.rbtnCam4.TabIndex = 31;
            this.rbtnCam4.Text = "Camera 4";
            this.rbtnCam4.UseVisualStyleBackColor = true;
            this.rbtnCam4.CheckedChanged += new System.EventHandler(this.rbtnCam_Click);
            // 
            // rbtnCam5
            // 
            this.rbtnCam5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbtnCam5.AutoSize = true;
            this.rbtnCam5.Location = new System.Drawing.Point(724, 149);
            this.rbtnCam5.Name = "rbtnCam5";
            this.rbtnCam5.Size = new System.Drawing.Size(70, 17);
            this.rbtnCam5.TabIndex = 32;
            this.rbtnCam5.Text = "Camera 5";
            this.rbtnCam5.UseVisualStyleBackColor = true;
            this.rbtnCam5.CheckedChanged += new System.EventHandler(this.rbtnCam_Click);
            // 
            // barPan
            // 
            this.barPan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.barPan.Location = new System.Drawing.Point(751, 326);
            this.barPan.Maximum = 359;
            this.barPan.Name = "barPan";
            this.barPan.Size = new System.Drawing.Size(104, 45);
            this.barPan.TabIndex = 33;
            this.barPan.ValueChanged += new System.EventHandler(this.barPan_ValueChanged);
            // 
            // barTilt
            // 
            this.barTilt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.barTilt.Location = new System.Drawing.Point(751, 366);
            this.barTilt.Maximum = 360;
            this.barTilt.Minimum = 180;
            this.barTilt.Name = "barTilt";
            this.barTilt.Size = new System.Drawing.Size(104, 45);
            this.barTilt.TabIndex = 34;
            this.barTilt.Value = 180;
            this.barTilt.ValueChanged += new System.EventHandler(this.barTilt_ValueChanged);
            // 
            // barZoom
            // 
            this.barZoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.barZoom.LargeChange = 1000;
            this.barZoom.Location = new System.Drawing.Point(751, 408);
            this.barZoom.Maximum = 10000;
            this.barZoom.Name = "barZoom";
            this.barZoom.Size = new System.Drawing.Size(104, 45);
            this.barZoom.SmallChange = 10;
            this.barZoom.TabIndex = 35;
            this.barZoom.Scroll += new System.EventHandler(this.barZoom_Scroll);
            // 
            // lblPan
            // 
            this.lblPan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPan.AutoSize = true;
            this.lblPan.Location = new System.Drawing.Point(702, 326);
            this.lblPan.Name = "lblPan";
            this.lblPan.Size = new System.Drawing.Size(20, 13);
            this.lblPan.TabIndex = 36;
            this.lblPan.Text = "P: ";
            // 
            // lblTilt
            // 
            this.lblTilt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTilt.AutoSize = true;
            this.lblTilt.Location = new System.Drawing.Point(702, 366);
            this.lblTilt.Name = "lblTilt";
            this.lblTilt.Size = new System.Drawing.Size(20, 13);
            this.lblTilt.TabIndex = 37;
            this.lblTilt.Text = "T: ";
            // 
            // lblZoom
            // 
            this.lblZoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblZoom.AutoSize = true;
            this.lblZoom.Location = new System.Drawing.Point(702, 408);
            this.lblZoom.Name = "lblZoom";
            this.lblZoom.Size = new System.Drawing.Size(20, 13);
            this.lblZoom.TabIndex = 38;
            this.lblZoom.Text = "Z: ";
            // 
            // VideoPanel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(878, 536);
            this.Controls.Add(this.lblZoom);
            this.Controls.Add(this.lblTilt);
            this.Controls.Add(this.lblPan);
            this.Controls.Add(this.barZoom);
            this.Controls.Add(this.barTilt);
            this.Controls.Add(this.barPan);
            this.Controls.Add(this.rbtnCam2);
            this.Controls.Add(this.rbtnCam1);
            this.Controls.Add(this.rbtnCam3);
            this.Controls.Add(this.rbtnCam4);
            this.Controls.Add(this.rbtnCam5);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.barHeight);
            this.Controls.Add(this.barWidth);
            this.Controls.Add(this.lblBarFps);
            this.Controls.Add(this.barFps);
            this.Controls.Add(this.lblFps);
            this.Controls.Add(this.imgVideo);
            this.Name = "VideoPanel";
            this.Text = "VideoPanel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VideoPanel_FormClosing);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.VideoPanel_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.imgVideo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barFps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barPan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barTilt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barZoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox imgVideo;
        public System.Windows.Forms.Label lblFps;
        private System.Windows.Forms.TrackBar barFps;
        private System.Windows.Forms.Label lblBarFps;
        private System.Windows.Forms.TrackBar barWidth;
        private System.Windows.Forms.TrackBar barHeight;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.RadioButton rbtnCam2;
        private System.Windows.Forms.RadioButton rbtnCam1;
        private System.Windows.Forms.RadioButton rbtnCam3;
        private System.Windows.Forms.RadioButton rbtnCam4;
        private System.Windows.Forms.RadioButton rbtnCam5;
        private System.Windows.Forms.TrackBar barPan;
        private System.Windows.Forms.TrackBar barTilt;
        private System.Windows.Forms.TrackBar barZoom;
        private System.Windows.Forms.Label lblPan;
        private System.Windows.Forms.Label lblTilt;
        private System.Windows.Forms.Label lblZoom;




    }
}