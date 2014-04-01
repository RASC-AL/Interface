﻿namespace RoboOps.Interface
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.rbtnCam1 = new System.Windows.Forms.RadioButton();
            this.rbtnCam2 = new System.Windows.Forms.RadioButton();
            this.rbtnCam3 = new System.Windows.Forms.RadioButton();
            this.rbtnCam4 = new System.Windows.Forms.RadioButton();
            this.rbtnCam5 = new System.Windows.Forms.RadioButton();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.btnStartStream = new System.Windows.Forms.Button();
            this.btnStopStream = new System.Windows.Forms.Button();
            this.lblCoordinates = new System.Windows.Forms.Label();
            this.lblFps = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(165, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "arm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(264, 67);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "drive";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // rbtnCam1
            // 
            this.rbtnCam1.AutoSize = true;
            this.rbtnCam1.Checked = true;
            this.rbtnCam1.Location = new System.Drawing.Point(183, 141);
            this.rbtnCam1.Name = "rbtnCam1";
            this.rbtnCam1.Size = new System.Drawing.Size(70, 17);
            this.rbtnCam1.TabIndex = 2;
            this.rbtnCam1.TabStop = true;
            this.rbtnCam1.Text = "Camera 1";
            this.rbtnCam1.UseVisualStyleBackColor = true;
            this.rbtnCam1.CheckedChanged += new System.EventHandler(this.rbtnCam1_CheckedChanged);
            this.rbtnCam1.Click += new System.EventHandler(this.rbtnCam_Click);
            // 
            // rbtnCam2
            // 
            this.rbtnCam2.AutoSize = true;
            this.rbtnCam2.Location = new System.Drawing.Point(183, 165);
            this.rbtnCam2.Name = "rbtnCam2";
            this.rbtnCam2.Size = new System.Drawing.Size(70, 17);
            this.rbtnCam2.TabIndex = 3;
            this.rbtnCam2.Text = "Camera 2";
            this.rbtnCam2.UseVisualStyleBackColor = true;
            this.rbtnCam2.CheckedChanged += new System.EventHandler(this.rbtnCam2_CheckedChanged);
            this.rbtnCam2.Click += new System.EventHandler(this.rbtnCam_Click);
            // 
            // rbtnCam3
            // 
            this.rbtnCam3.AutoSize = true;
            this.rbtnCam3.Location = new System.Drawing.Point(183, 189);
            this.rbtnCam3.Name = "rbtnCam3";
            this.rbtnCam3.Size = new System.Drawing.Size(70, 17);
            this.rbtnCam3.TabIndex = 4;
            this.rbtnCam3.Text = "Camera 3";
            this.rbtnCam3.UseVisualStyleBackColor = true;
            this.rbtnCam3.CheckedChanged += new System.EventHandler(this.rbtnCam3_CheckedChanged);
            this.rbtnCam3.Click += new System.EventHandler(this.rbtnCam_Click);
            // 
            // rbtnCam4
            // 
            this.rbtnCam4.AutoSize = true;
            this.rbtnCam4.Location = new System.Drawing.Point(183, 215);
            this.rbtnCam4.Name = "rbtnCam4";
            this.rbtnCam4.Size = new System.Drawing.Size(70, 17);
            this.rbtnCam4.TabIndex = 5;
            this.rbtnCam4.Text = "Camera 4";
            this.rbtnCam4.UseVisualStyleBackColor = true;
            this.rbtnCam4.CheckedChanged += new System.EventHandler(this.rbtnCam4_CheckedChanged);
            this.rbtnCam4.Click += new System.EventHandler(this.rbtnCam_Click);
            // 
            // rbtnCam5
            // 
            this.rbtnCam5.AutoSize = true;
            this.rbtnCam5.Location = new System.Drawing.Point(183, 237);
            this.rbtnCam5.Name = "rbtnCam5";
            this.rbtnCam5.Size = new System.Drawing.Size(70, 17);
            this.rbtnCam5.TabIndex = 6;
            this.rbtnCam5.Text = "Camera 5";
            this.rbtnCam5.UseVisualStyleBackColor = true;
            this.rbtnCam5.CheckedChanged += new System.EventHandler(this.rbtnCam5_CheckedChanged);
            this.rbtnCam5.Click += new System.EventHandler(this.rbtnCam_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(204, 292);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 29);
            this.button3.TabIndex = 7;
            this.button3.Text = "switch";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(165, 363);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "open";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(276, 363);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 9;
            this.button5.Text = "close";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(276, 440);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 24);
            this.button6.TabIndex = 12;
            this.button6.Text = "Move to Rover";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(152, 440);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(98, 24);
            this.button8.TabIndex = 14;
            this.button8.Text = "Arm Home";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(30, 20);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(116, 28);
            this.button9.TabIndex = 15;
            this.button9.Text = "Settings";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // btnStartStream
            // 
            this.btnStartStream.Location = new System.Drawing.Point(165, 107);
            this.btnStartStream.Name = "btnStartStream";
            this.btnStartStream.Size = new System.Drawing.Size(75, 23);
            this.btnStartStream.TabIndex = 16;
            this.btnStartStream.Text = "Start Stream";
            this.btnStartStream.UseVisualStyleBackColor = true;
            this.btnStartStream.Click += new System.EventHandler(this.btnStartStream_Click);
            // 
            // btnStopStream
            // 
            this.btnStopStream.Location = new System.Drawing.Point(264, 107);
            this.btnStopStream.Name = "btnStopStream";
            this.btnStopStream.Size = new System.Drawing.Size(75, 23);
            this.btnStopStream.TabIndex = 17;
            this.btnStopStream.Text = "Stop Stream";
            this.btnStopStream.UseVisualStyleBackColor = true;
            this.btnStopStream.Click += new System.EventHandler(this.btnStopStream_Click);
            // 
            // lblCoordinates
            // 
            this.lblCoordinates.AutoSize = true;
            this.lblCoordinates.Location = new System.Drawing.Point(27, 451);
            this.lblCoordinates.Name = "lblCoordinates";
            this.lblCoordinates.Size = new System.Drawing.Size(30, 13);
            this.lblCoordinates.TabIndex = 18;
            this.lblCoordinates.Text = "X: Y:";
            this.lblCoordinates.Click += new System.EventHandler(this.lblCoordinates_Click);
            // 
            // lblFps
            // 
            this.lblFps.AutoSize = true;
            this.lblFps.Location = new System.Drawing.Point(345, 112);
            this.lblFps.Name = "lblFps";
            this.lblFps.Size = new System.Drawing.Size(21, 13);
            this.lblFps.TabIndex = 19;
            this.lblFps.Text = "fps";
            // 
            // Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 488);
            this.Controls.Add(this.lblFps);
            this.Controls.Add(this.lblCoordinates);
            this.Controls.Add(this.btnStopStream);
            this.Controls.Add(this.btnStartStream);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.rbtnCam5);
            this.Controls.Add(this.rbtnCam4);
            this.Controls.Add(this.rbtnCam3);
            this.Controls.Add(this.rbtnCam2);
            this.Controls.Add(this.rbtnCam1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Interface";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton rbtnCam1;
        private System.Windows.Forms.RadioButton rbtnCam2;
        private System.Windows.Forms.RadioButton rbtnCam3;
        private System.Windows.Forms.RadioButton rbtnCam4;
        private System.Windows.Forms.RadioButton rbtnCam5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button btnStartStream;
        private System.Windows.Forms.Button btnStopStream;
        private System.Windows.Forms.Label lblCoordinates;
        private System.Windows.Forms.Label lblFps;
    }
}

