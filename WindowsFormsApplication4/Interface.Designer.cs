namespace RoboOps.Interface
{
    partial class Interface
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Interface));
            this.btnStartStream = new System.Windows.Forms.Button();
            this.btnStopStream = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnArmHome = new System.Windows.Forms.Button();
            this.chkArm = new System.Windows.Forms.CheckBox();
            this.chkRaiseMast = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblRight = new System.Windows.Forms.Label();
            this.lblLeft = new System.Windows.Forms.Label();
            this.lblShoulder = new System.Windows.Forms.Label();
            this.lblElbow = new System.Windows.Forms.Label();
            this.lblWrist = new System.Windows.Forms.Label();
            this.lblScoop = new System.Windows.Forms.Label();
            this.lblBase = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.drvSpeed = new System.Windows.Forms.HScrollBar();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStartStream
            // 
            this.btnStartStream.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.btnStartStream.Location = new System.Drawing.Point(93, 263);
            this.btnStartStream.Name = "btnStartStream";
            this.btnStartStream.Size = new System.Drawing.Size(75, 23);
            this.btnStartStream.TabIndex = 16;
            this.btnStartStream.Text = "Start Stream";
            this.btnStartStream.UseVisualStyleBackColor = false;
            this.btnStartStream.Click += new System.EventHandler(this.btnStartStream_Click);
            // 
            // btnStopStream
            // 
            this.btnStopStream.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.btnStopStream.Location = new System.Drawing.Point(192, 263);
            this.btnStopStream.Name = "btnStopStream";
            this.btnStopStream.Size = new System.Drawing.Size(75, 23);
            this.btnStopStream.TabIndex = 17;
            this.btnStopStream.Text = "Stop Stream";
            this.btnStopStream.UseVisualStyleBackColor = false;
            this.btnStopStream.Click += new System.EventHandler(this.btnStopStream_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.btnRead);
            this.splitContainer1.Panel2.Controls.Add(this.btnArmHome);
            this.splitContainer1.Panel2.Controls.Add(this.chkArm);
            this.splitContainer1.Panel2.Controls.Add(this.chkRaiseMast);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.lblRight);
            this.splitContainer1.Panel2.Controls.Add(this.lblLeft);
            this.splitContainer1.Panel2.Controls.Add(this.lblShoulder);
            this.splitContainer1.Panel2.Controls.Add(this.lblElbow);
            this.splitContainer1.Panel2.Controls.Add(this.lblWrist);
            this.splitContainer1.Panel2.Controls.Add(this.lblScoop);
            this.splitContainer1.Panel2.Controls.Add(this.lblBase);
            this.splitContainer1.Panel2.Controls.Add(this.lblError);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.drvSpeed);
            this.splitContainer1.Panel2.Controls.Add(this.btnStopStream);
            this.splitContainer1.Panel2.Controls.Add(this.btnStartStream);
            this.splitContainer1.Panel2.ForeColor = System.Drawing.Color.Cornsilk;
            this.splitContainer1.Size = new System.Drawing.Size(1087, 693);
            this.splitContainer1.SplitterDistance = 25;
            this.splitContainer1.TabIndex = 20;
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
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.splitContainer2.Panel1.ForeColor = System.Drawing.Color.Cornsilk;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.splitContainer2.Panel2.ForeColor = System.Drawing.Color.Cornsilk;
            this.splitContainer2.Size = new System.Drawing.Size(25, 693);
            this.splitContainer2.SplitterDistance = 194;
            this.splitContainer2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(62, 518);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(321, 69);
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(72, 457);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "label6";
            // 
            // btnRead
            // 
            this.btnRead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.btnRead.Location = new System.Drawing.Point(228, 399);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(93, 23);
            this.btnRead.TabIndex = 41;
            this.btnRead.Text = "Get Readings";
            this.btnRead.UseVisualStyleBackColor = false;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnArmHome
            // 
            this.btnArmHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.btnArmHome.Location = new System.Drawing.Point(93, 399);
            this.btnArmHome.Name = "btnArmHome";
            this.btnArmHome.Size = new System.Drawing.Size(75, 23);
            this.btnArmHome.TabIndex = 40;
            this.btnArmHome.Text = "Arm Home";
            this.btnArmHome.UseVisualStyleBackColor = false;
            this.btnArmHome.Click += new System.EventHandler(this.btnArmHome_Click);
            // 
            // chkArm
            // 
            this.chkArm.AutoSize = true;
            this.chkArm.Location = new System.Drawing.Point(214, 215);
            this.chkArm.Name = "chkArm";
            this.chkArm.Size = new System.Drawing.Size(77, 17);
            this.chkArm.TabIndex = 39;
            this.chkArm.Text = "Arm Power";
            this.chkArm.UseVisualStyleBackColor = true;
            this.chkArm.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // chkRaiseMast
            // 
            this.chkRaiseMast.AutoSize = true;
            this.chkRaiseMast.Location = new System.Drawing.Point(93, 215);
            this.chkRaiseMast.Name = "chkRaiseMast";
            this.chkRaiseMast.Size = new System.Drawing.Size(79, 17);
            this.chkRaiseMast.TabIndex = 38;
            this.chkRaiseMast.Text = "Raise Mast";
            this.chkRaiseMast.UseVisualStyleBackColor = true;
            this.chkRaiseMast.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(119, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 20);
            this.label5.TabIndex = 37;
            this.label5.Text = "Motor Information";
            // 
            // lblRight
            // 
            this.lblRight.AutoSize = true;
            this.lblRight.Location = new System.Drawing.Point(272, 82);
            this.lblRight.Name = "lblRight";
            this.lblRight.Size = new System.Drawing.Size(35, 13);
            this.lblRight.TabIndex = 30;
            this.lblRight.Text = "label3";
            // 
            // lblLeft
            // 
            this.lblLeft.AutoSize = true;
            this.lblLeft.Location = new System.Drawing.Point(189, 81);
            this.lblLeft.Name = "lblLeft";
            this.lblLeft.Size = new System.Drawing.Size(35, 13);
            this.lblLeft.TabIndex = 29;
            this.lblLeft.Text = "label2";
            // 
            // lblShoulder
            // 
            this.lblShoulder.AutoSize = true;
            this.lblShoulder.Location = new System.Drawing.Point(90, 104);
            this.lblShoulder.Name = "lblShoulder";
            this.lblShoulder.Size = new System.Drawing.Size(35, 13);
            this.lblShoulder.TabIndex = 28;
            this.lblShoulder.Text = "label6";
            // 
            // lblElbow
            // 
            this.lblElbow.AutoSize = true;
            this.lblElbow.Location = new System.Drawing.Point(90, 128);
            this.lblElbow.Name = "lblElbow";
            this.lblElbow.Size = new System.Drawing.Size(35, 13);
            this.lblElbow.TabIndex = 27;
            this.lblElbow.Text = "label5";
            // 
            // lblWrist
            // 
            this.lblWrist.AutoSize = true;
            this.lblWrist.Location = new System.Drawing.Point(90, 151);
            this.lblWrist.Name = "lblWrist";
            this.lblWrist.Size = new System.Drawing.Size(35, 13);
            this.lblWrist.TabIndex = 26;
            this.lblWrist.Text = "label4";
            // 
            // lblScoop
            // 
            this.lblScoop.AutoSize = true;
            this.lblScoop.Location = new System.Drawing.Point(90, 174);
            this.lblScoop.Name = "lblScoop";
            this.lblScoop.Size = new System.Drawing.Size(35, 13);
            this.lblScoop.TabIndex = 25;
            this.lblScoop.Text = "label3";
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.Location = new System.Drawing.Point(90, 81);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(35, 13);
            this.lblBase.TabIndex = 24;
            this.lblBase.Text = "label2";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(33, 15);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Speed";
            // 
            // drvSpeed
            // 
            this.drvSpeed.Location = new System.Drawing.Point(89, 333);
            this.drvSpeed.Name = "drvSpeed";
            this.drvSpeed.Size = new System.Drawing.Size(261, 22);
            this.drvSpeed.TabIndex = 21;
            this.drvSpeed.Value = 50;
            // 
            // Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.ClientSize = new System.Drawing.Size(464, 602);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Interface";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStartStream;
        private System.Windows.Forms.Button btnStopStream;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.HScrollBar drvSpeed;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblShoulder;
        private System.Windows.Forms.Label lblElbow;
        private System.Windows.Forms.Label lblWrist;
        private System.Windows.Forms.Label lblScoop;
        private System.Windows.Forms.Label lblBase;
        private System.Windows.Forms.Label lblRight;
        private System.Windows.Forms.Label lblLeft;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkArm;
        private System.Windows.Forms.CheckBox chkRaiseMast;
        private System.Windows.Forms.Button btnArmHome;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Label label6;
    }
}

