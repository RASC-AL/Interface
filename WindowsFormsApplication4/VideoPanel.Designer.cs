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
            this.txtCam0 = new System.Windows.Forms.TextBox();
            this.txtCam1 = new System.Windows.Forms.TextBox();
            this.txtCam2 = new System.Windows.Forms.TextBox();
            this.txtCam3 = new System.Windows.Forms.TextBox();
            this.rbtnCam6 = new System.Windows.Forms.RadioButton();
            this.btnChangeCam = new System.Windows.Forms.Button();
            this.btnDropPos = new System.Windows.Forms.Button();
            this.btnPickPos = new System.Windows.Forms.Button();
            this.btnDrivePos = new System.Windows.Forms.Button();
            this.txtPan = new System.Windows.Forms.TextBox();
            this.txtZoom = new System.Windows.Forms.TextBox();
            this.txtTilt = new System.Windows.Forms.TextBox();
            this.btnChangePTZ = new System.Windows.Forms.Button();
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
            this.imgVideo.Size = new System.Drawing.Size(283, 536);
            this.imgVideo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgVideo.TabIndex = 0;
            this.imgVideo.TabStop = false;
            // 
            // lblFps
            // 
            this.lblFps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFps.AutoSize = true;
            this.lblFps.Location = new System.Drawing.Point(437, 9);
            this.lblFps.Name = "lblFps";
            this.lblFps.Size = new System.Drawing.Size(21, 13);
            this.lblFps.TabIndex = 20;
            this.lblFps.Text = "fps";
            // 
            // barFps
            // 
            this.barFps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.barFps.Location = new System.Drawing.Point(429, 67);
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
            this.lblBarFps.Location = new System.Drawing.Point(430, 48);
            this.lblBarFps.Name = "lblBarFps";
            this.lblBarFps.Size = new System.Drawing.Size(21, 13);
            this.lblBarFps.TabIndex = 22;
            this.lblBarFps.Text = "fps";
            // 
            // barWidth
            // 
            this.barWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.barWidth.LargeChange = 128;
            this.barWidth.Location = new System.Drawing.Point(369, 248);
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
            this.barHeight.Location = new System.Drawing.Point(435, 248);
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
            this.lblWidth.Location = new System.Drawing.Point(367, 229);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(24, 13);
            this.lblWidth.TabIndex = 25;
            this.lblWidth.Text = "W: ";
            // 
            // lblHeight
            // 
            this.lblHeight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(436, 229);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(21, 13);
            this.lblHeight.TabIndex = 26;
            this.lblHeight.Text = "H: ";
            // 
            // btnApply
            // 
            this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.btnApply.Location = new System.Drawing.Point(368, 500);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 27;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            this.btnApply.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnApply_MouseClick);
            // 
            // rbtnCam2
            // 
            this.rbtnCam2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbtnCam2.AutoSize = true;
            this.rbtnCam2.Location = new System.Drawing.Point(343, 58);
            this.rbtnCam2.Name = "rbtnCam2";
            this.rbtnCam2.Size = new System.Drawing.Size(70, 17);
            this.rbtnCam2.TabIndex = 29;
            this.rbtnCam2.Text = "Camera 1";
            this.rbtnCam2.UseVisualStyleBackColor = true;
            this.rbtnCam2.CheckedChanged += new System.EventHandler(this.rbtnCam_Click);
            // 
            // rbtnCam1
            // 
            this.rbtnCam1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbtnCam1.AutoSize = true;
            this.rbtnCam1.Checked = true;
            this.rbtnCam1.Location = new System.Drawing.Point(343, 34);
            this.rbtnCam1.Name = "rbtnCam1";
            this.rbtnCam1.Size = new System.Drawing.Size(70, 17);
            this.rbtnCam1.TabIndex = 28;
            this.rbtnCam1.TabStop = true;
            this.rbtnCam1.Text = "Camera 0";
            this.rbtnCam1.UseVisualStyleBackColor = true;
            this.rbtnCam1.CheckedChanged += new System.EventHandler(this.rbtnCam_Click);
            // 
            // rbtnCam3
            // 
            this.rbtnCam3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbtnCam3.AutoSize = true;
            this.rbtnCam3.Location = new System.Drawing.Point(343, 82);
            this.rbtnCam3.Name = "rbtnCam3";
            this.rbtnCam3.Size = new System.Drawing.Size(70, 17);
            this.rbtnCam3.TabIndex = 30;
            this.rbtnCam3.Text = "Camera 2";
            this.rbtnCam3.UseVisualStyleBackColor = true;
            this.rbtnCam3.CheckedChanged += new System.EventHandler(this.rbtnCam_Click);
            // 
            // rbtnCam4
            // 
            this.rbtnCam4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbtnCam4.AutoSize = true;
            this.rbtnCam4.Location = new System.Drawing.Point(343, 108);
            this.rbtnCam4.Name = "rbtnCam4";
            this.rbtnCam4.Size = new System.Drawing.Size(70, 17);
            this.rbtnCam4.TabIndex = 31;
            this.rbtnCam4.Text = "Camera 3";
            this.rbtnCam4.UseVisualStyleBackColor = true;
            this.rbtnCam4.CheckedChanged += new System.EventHandler(this.rbtnCam_Click);
            // 
            // rbtnCam5
            // 
            this.rbtnCam5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbtnCam5.AutoSize = true;
            this.rbtnCam5.Location = new System.Drawing.Point(343, 130);
            this.rbtnCam5.Name = "rbtnCam5";
            this.rbtnCam5.Size = new System.Drawing.Size(70, 17);
            this.rbtnCam5.TabIndex = 32;
            this.rbtnCam5.Text = "Camera 4";
            this.rbtnCam5.UseVisualStyleBackColor = true;
            this.rbtnCam5.CheckedChanged += new System.EventHandler(this.rbtnCam_Click);
            // 
            // barPan
            // 
            this.barPan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.barPan.Location = new System.Drawing.Point(370, 367);
            this.barPan.Maximum = 359;
            this.barPan.Name = "barPan";
            this.barPan.Size = new System.Drawing.Size(104, 45);
            this.barPan.TabIndex = 33;
            this.barPan.ValueChanged += new System.EventHandler(this.barPan_ValueChanged);
            // 
            // barTilt
            // 
            this.barTilt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.barTilt.Location = new System.Drawing.Point(370, 407);
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
            this.barZoom.Location = new System.Drawing.Point(370, 449);
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
            this.lblPan.Location = new System.Drawing.Point(321, 367);
            this.lblPan.Name = "lblPan";
            this.lblPan.Size = new System.Drawing.Size(20, 13);
            this.lblPan.TabIndex = 36;
            this.lblPan.Text = "P: ";
            // 
            // lblTilt
            // 
            this.lblTilt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTilt.AutoSize = true;
            this.lblTilt.Location = new System.Drawing.Point(321, 407);
            this.lblTilt.Name = "lblTilt";
            this.lblTilt.Size = new System.Drawing.Size(20, 13);
            this.lblTilt.TabIndex = 37;
            this.lblTilt.Text = "T: ";
            // 
            // lblZoom
            // 
            this.lblZoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblZoom.AutoSize = true;
            this.lblZoom.Location = new System.Drawing.Point(321, 449);
            this.lblZoom.Name = "lblZoom";
            this.lblZoom.Size = new System.Drawing.Size(20, 13);
            this.lblZoom.TabIndex = 38;
            this.lblZoom.Text = "Z: ";
            // 
            // txtCam0
            // 
            this.txtCam0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCam0.Location = new System.Drawing.Point(312, 34);
            this.txtCam0.Name = "txtCam0";
            this.txtCam0.Size = new System.Drawing.Size(20, 20);
            this.txtCam0.TabIndex = 39;
            // 
            // txtCam1
            // 
            this.txtCam1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCam1.Location = new System.Drawing.Point(312, 58);
            this.txtCam1.Name = "txtCam1";
            this.txtCam1.Size = new System.Drawing.Size(20, 20);
            this.txtCam1.TabIndex = 40;
            // 
            // txtCam2
            // 
            this.txtCam2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCam2.Location = new System.Drawing.Point(312, 82);
            this.txtCam2.Name = "txtCam2";
            this.txtCam2.Size = new System.Drawing.Size(20, 20);
            this.txtCam2.TabIndex = 41;
            // 
            // txtCam3
            // 
            this.txtCam3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCam3.Location = new System.Drawing.Point(312, 108);
            this.txtCam3.Name = "txtCam3";
            this.txtCam3.Size = new System.Drawing.Size(20, 20);
            this.txtCam3.TabIndex = 42;
            // 
            // rbtnCam6
            // 
            this.rbtnCam6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbtnCam6.AutoSize = true;
            this.rbtnCam6.Location = new System.Drawing.Point(343, 154);
            this.rbtnCam6.Name = "rbtnCam6";
            this.rbtnCam6.Size = new System.Drawing.Size(70, 17);
            this.rbtnCam6.TabIndex = 43;
            this.rbtnCam6.Text = "Camera 5";
            this.rbtnCam6.UseVisualStyleBackColor = true;
            this.rbtnCam6.CheckedChanged += new System.EventHandler(this.rbtnCam_Click);
            // 
            // btnChangeCam
            // 
            this.btnChangeCam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChangeCam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.btnChangeCam.ForeColor = System.Drawing.Color.White;
            this.btnChangeCam.Location = new System.Drawing.Point(309, 178);
            this.btnChangeCam.Name = "btnChangeCam";
            this.btnChangeCam.Size = new System.Drawing.Size(104, 23);
            this.btnChangeCam.TabIndex = 44;
            this.btnChangeCam.Text = "Change camera";
            this.btnChangeCam.UseVisualStyleBackColor = false;
            this.btnChangeCam.Click += new System.EventHandler(this.btnChangeCam_Click);
            // 
            // btnDropPos
            // 
            this.btnDropPos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.btnDropPos.Location = new System.Drawing.Point(74, 367);
            this.btnDropPos.Name = "btnDropPos";
            this.btnDropPos.Size = new System.Drawing.Size(75, 23);
            this.btnDropPos.TabIndex = 45;
            this.btnDropPos.Text = "Drop Pos";
            this.btnDropPos.UseVisualStyleBackColor = false;
            this.btnDropPos.Click += new System.EventHandler(this.btnDropPos_Click);
            // 
            // btnPickPos
            // 
            this.btnPickPos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.btnPickPos.Location = new System.Drawing.Point(74, 407);
            this.btnPickPos.Name = "btnPickPos";
            this.btnPickPos.Size = new System.Drawing.Size(75, 23);
            this.btnPickPos.TabIndex = 46;
            this.btnPickPos.Text = "Pick Pos";
            this.btnPickPos.UseVisualStyleBackColor = false;
            this.btnPickPos.Click += new System.EventHandler(this.btnPickPos_Click);
            // 
            // btnDrivePos
            // 
            this.btnDrivePos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.btnDrivePos.Location = new System.Drawing.Point(74, 449);
            this.btnDrivePos.Name = "btnDrivePos";
            this.btnDrivePos.Size = new System.Drawing.Size(75, 23);
            this.btnDrivePos.TabIndex = 47;
            this.btnDrivePos.Text = "Drive Pos";
            this.btnDrivePos.UseVisualStyleBackColor = false;
            this.btnDrivePos.Click += new System.EventHandler(this.btnDrivePos_Click);
            // 
            // txtPan
            // 
            this.txtPan.Location = new System.Drawing.Point(206, 367);
            this.txtPan.Name = "txtPan";
            this.txtPan.Size = new System.Drawing.Size(41, 20);
            this.txtPan.TabIndex = 48;
            // 
            // txtZoom
            // 
            this.txtZoom.Location = new System.Drawing.Point(206, 449);
            this.txtZoom.Name = "txtZoom";
            this.txtZoom.Size = new System.Drawing.Size(41, 20);
            this.txtZoom.TabIndex = 49;
            // 
            // txtTilt
            // 
            this.txtTilt.Location = new System.Drawing.Point(206, 407);
            this.txtTilt.Name = "txtTilt";
            this.txtTilt.Size = new System.Drawing.Size(41, 20);
            this.txtTilt.TabIndex = 50;
            // 
            // btnChangePTZ
            // 
            this.btnChangePTZ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.btnChangePTZ.Location = new System.Drawing.Point(176, 500);
            this.btnChangePTZ.Name = "btnChangePTZ";
            this.btnChangePTZ.Size = new System.Drawing.Size(79, 23);
            this.btnChangePTZ.TabIndex = 51;
            this.btnChangePTZ.Text = "Change PTZ";
            this.btnChangePTZ.UseVisualStyleBackColor = false;
            this.btnChangePTZ.Click += new System.EventHandler(this.btnChangePTZ_Click);
            // 
            // VideoPanel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.ClientSize = new System.Drawing.Size(497, 536);
            this.Controls.Add(this.btnChangePTZ);
            this.Controls.Add(this.txtTilt);
            this.Controls.Add(this.txtZoom);
            this.Controls.Add(this.txtPan);
            this.Controls.Add(this.btnDrivePos);
            this.Controls.Add(this.btnPickPos);
            this.Controls.Add(this.btnDropPos);
            this.Controls.Add(this.btnChangeCam);
            this.Controls.Add(this.rbtnCam6);
            this.Controls.Add(this.txtCam3);
            this.Controls.Add(this.txtCam2);
            this.Controls.Add(this.txtCam1);
            this.Controls.Add(this.txtCam0);
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
            this.ForeColor = System.Drawing.Color.Cornsilk;
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
        private System.Windows.Forms.TextBox txtCam0;
        private System.Windows.Forms.TextBox txtCam1;
        private System.Windows.Forms.TextBox txtCam2;
        private System.Windows.Forms.TextBox txtCam3;
        private System.Windows.Forms.RadioButton rbtnCam6;
        private System.Windows.Forms.Button btnChangeCam;
        private System.Windows.Forms.Button btnDropPos;
        private System.Windows.Forms.Button btnPickPos;
        private System.Windows.Forms.Button btnDrivePos;
        private System.Windows.Forms.TextBox txtPan;
        private System.Windows.Forms.TextBox txtZoom;
        private System.Windows.Forms.TextBox txtTilt;
        private System.Windows.Forms.Button btnChangePTZ;




    }
}