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
            this.label4 = new System.Windows.Forms.Label();
            this.lblJoystickPollInterval = new System.Windows.Forms.Label();
            this.lbljoystickMax = new System.Windows.Forms.Label();
            this.lbljoystickSensitivity = new System.Windows.Forms.Label();
            this.lblJoystickZero = new System.Windows.Forms.Label();
            this.lblPort = new System.Windows.Forms.Label();
            this.lblRoverIp = new System.Windows.Forms.Label();
            this.txtJoystickMax = new System.Windows.Forms.TextBox();
            this.txtJoystickPollInterval = new System.Windows.Forms.TextBox();
            this.txtJoystickSensitivity = new System.Windows.Forms.TextBox();
            this.txtJoystickZero = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtRoverIp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblYawSensitivity = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.lblMaxYaw = new System.Windows.Forms.Label();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.lblMinYaw = new System.Windows.Forms.Label();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.lblBaseLiftSensitivity = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.lblBaseMaxLift = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.lblBaseMinLift = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.lblElbowSensitivity = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.lblElbowMaxLift = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.lblElbowMinLift = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.lblbaseRotationSensitivity = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.lblBaseMaxRotation = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblbaseMinRotation = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lblTurnMaxSpeed = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblFwdSpeed = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
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
            this.splitContainer1.SplitterDistance = 686;
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
            this.splitContainer2.Panel1.Controls.Add(this.label4);
            this.splitContainer2.Panel1.Controls.Add(this.lblJoystickPollInterval);
            this.splitContainer2.Panel1.Controls.Add(this.lbljoystickMax);
            this.splitContainer2.Panel1.Controls.Add(this.lbljoystickSensitivity);
            this.splitContainer2.Panel1.Controls.Add(this.lblJoystickZero);
            this.splitContainer2.Panel1.Controls.Add(this.lblPort);
            this.splitContainer2.Panel1.Controls.Add(this.lblRoverIp);
            this.splitContainer2.Panel1.Controls.Add(this.txtJoystickMax);
            this.splitContainer2.Panel1.Controls.Add(this.txtJoystickPollInterval);
            this.splitContainer2.Panel1.Controls.Add(this.txtJoystickSensitivity);
            this.splitContainer2.Panel1.Controls.Add(this.txtJoystickZero);
            this.splitContainer2.Panel1.Controls.Add(this.txtPort);
            this.splitContainer2.Panel1.Controls.Add(this.txtRoverIp);
            this.splitContainer2.Panel1.ForeColor = System.Drawing.Color.Cornsilk;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.splitContainer2.Panel2.Controls.Add(this.label3);
            this.splitContainer2.Panel2.Controls.Add(this.label2);
            this.splitContainer2.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer2.Panel2.Controls.Add(this.lblYawSensitivity);
            this.splitContainer2.Panel2.Controls.Add(this.textBox12);
            this.splitContainer2.Panel2.Controls.Add(this.lblMaxYaw);
            this.splitContainer2.Panel2.Controls.Add(this.textBox13);
            this.splitContainer2.Panel2.Controls.Add(this.lblMinYaw);
            this.splitContainer2.Panel2.Controls.Add(this.textBox14);
            this.splitContainer2.Panel2.Controls.Add(this.lblBaseLiftSensitivity);
            this.splitContainer2.Panel2.Controls.Add(this.textBox9);
            this.splitContainer2.Panel2.Controls.Add(this.lblBaseMaxLift);
            this.splitContainer2.Panel2.Controls.Add(this.textBox10);
            this.splitContainer2.Panel2.Controls.Add(this.lblBaseMinLift);
            this.splitContainer2.Panel2.Controls.Add(this.textBox11);
            this.splitContainer2.Panel2.Controls.Add(this.lblElbowSensitivity);
            this.splitContainer2.Panel2.Controls.Add(this.textBox6);
            this.splitContainer2.Panel2.Controls.Add(this.lblElbowMaxLift);
            this.splitContainer2.Panel2.Controls.Add(this.textBox7);
            this.splitContainer2.Panel2.Controls.Add(this.lblElbowMinLift);
            this.splitContainer2.Panel2.Controls.Add(this.textBox8);
            this.splitContainer2.Panel2.Controls.Add(this.lblbaseRotationSensitivity);
            this.splitContainer2.Panel2.Controls.Add(this.textBox5);
            this.splitContainer2.Panel2.Controls.Add(this.lblBaseMaxRotation);
            this.splitContainer2.Panel2.Controls.Add(this.textBox3);
            this.splitContainer2.Panel2.Controls.Add(this.lblbaseMinRotation);
            this.splitContainer2.Panel2.Controls.Add(this.textBox4);
            this.splitContainer2.Panel2.Controls.Add(this.lblTurnMaxSpeed);
            this.splitContainer2.Panel2.Controls.Add(this.textBox2);
            this.splitContainer2.Panel2.Controls.Add(this.lblFwdSpeed);
            this.splitContainer2.Panel2.Controls.Add(this.textBox1);
            this.splitContainer2.Panel2.ForeColor = System.Drawing.Color.Cornsilk;
            this.splitContainer2.Size = new System.Drawing.Size(686, 693);
            this.splitContainer2.SplitterDistance = 194;
            this.splitContainer2.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(276, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 20);
            this.label4.TabIndex = 37;
            this.label4.Text = "Controller Configuration";
            // 
            // lblJoystickPollInterval
            // 
            this.lblJoystickPollInterval.AutoSize = true;
            this.lblJoystickPollInterval.Location = new System.Drawing.Point(37, 158);
            this.lblJoystickPollInterval.Name = "lblJoystickPollInterval";
            this.lblJoystickPollInterval.Size = new System.Drawing.Size(103, 13);
            this.lblJoystickPollInterval.TabIndex = 11;
            this.lblJoystickPollInterval.Text = "Joystick Poll Interval";
            // 
            // lbljoystickMax
            // 
            this.lbljoystickMax.AutoSize = true;
            this.lbljoystickMax.Location = new System.Drawing.Point(335, 112);
            this.lbljoystickMax.Name = "lbljoystickMax";
            this.lbljoystickMax.Size = new System.Drawing.Size(68, 13);
            this.lbljoystickMax.TabIndex = 10;
            this.lbljoystickMax.Text = "Joystick Max";
            // 
            // lbljoystickSensitivity
            // 
            this.lbljoystickSensitivity.AutoSize = true;
            this.lbljoystickSensitivity.ForeColor = System.Drawing.Color.Cornsilk;
            this.lbljoystickSensitivity.Location = new System.Drawing.Point(335, 158);
            this.lbljoystickSensitivity.Name = "lbljoystickSensitivity";
            this.lbljoystickSensitivity.Size = new System.Drawing.Size(95, 13);
            this.lbljoystickSensitivity.TabIndex = 9;
            this.lbljoystickSensitivity.Text = "Joystick Sensitivity";
            // 
            // lblJoystickZero
            // 
            this.lblJoystickZero.AutoSize = true;
            this.lblJoystickZero.Location = new System.Drawing.Point(37, 112);
            this.lblJoystickZero.Name = "lblJoystickZero";
            this.lblJoystickZero.Size = new System.Drawing.Size(70, 13);
            this.lblJoystickZero.TabIndex = 8;
            this.lblJoystickZero.Text = "Joystick Zero";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(335, 16);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(26, 13);
            this.lblPort.TabIndex = 7;
            this.lblPort.Text = "Port";
            // 
            // lblRoverIp
            // 
            this.lblRoverIp.AutoSize = true;
            this.lblRoverIp.Location = new System.Drawing.Point(37, 16);
            this.lblRoverIp.Name = "lblRoverIp";
            this.lblRoverIp.Size = new System.Drawing.Size(49, 13);
            this.lblRoverIp.TabIndex = 6;
            this.lblRoverIp.Text = "Rover IP";
            // 
            // txtJoystickMax
            // 
            this.txtJoystickMax.Location = new System.Drawing.Point(458, 109);
            this.txtJoystickMax.Name = "txtJoystickMax";
            this.txtJoystickMax.Size = new System.Drawing.Size(126, 20);
            this.txtJoystickMax.TabIndex = 5;
            // 
            // txtJoystickPollInterval
            // 
            this.txtJoystickPollInterval.Location = new System.Drawing.Point(160, 155);
            this.txtJoystickPollInterval.Name = "txtJoystickPollInterval";
            this.txtJoystickPollInterval.Size = new System.Drawing.Size(126, 20);
            this.txtJoystickPollInterval.TabIndex = 4;
            // 
            // txtJoystickSensitivity
            // 
            this.txtJoystickSensitivity.Location = new System.Drawing.Point(458, 155);
            this.txtJoystickSensitivity.Name = "txtJoystickSensitivity";
            this.txtJoystickSensitivity.Size = new System.Drawing.Size(126, 20);
            this.txtJoystickSensitivity.TabIndex = 3;
            // 
            // txtJoystickZero
            // 
            this.txtJoystickZero.Location = new System.Drawing.Point(160, 109);
            this.txtJoystickZero.Name = "txtJoystickZero";
            this.txtJoystickZero.Size = new System.Drawing.Size(126, 20);
            this.txtJoystickZero.TabIndex = 2;
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(458, 9);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(126, 20);
            this.txtPort.TabIndex = 1;
            // 
            // txtRoverIp
            // 
            this.txtRoverIp.Location = new System.Drawing.Point(160, 9);
            this.txtRoverIp.Name = "txtRoverIp";
            this.txtRoverIp.Size = new System.Drawing.Size(126, 20);
            this.txtRoverIp.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(276, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 20);
            this.label3.TabIndex = 36;
            this.label3.Text = "Drive Configuration";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(276, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "Arm Configuration";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 329);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(321, 69);
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // lblYawSensitivity
            // 
            this.lblYawSensitivity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblYawSensitivity.AutoSize = true;
            this.lblYawSensitivity.Location = new System.Drawing.Point(431, 302);
            this.lblYawSensitivity.Name = "lblYawSensitivity";
            this.lblYawSensitivity.Size = new System.Drawing.Size(78, 13);
            this.lblYawSensitivity.TabIndex = 33;
            this.lblYawSensitivity.Text = "Yaw Sensitivity";
            // 
            // textBox12
            // 
            this.textBox12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox12.Location = new System.Drawing.Point(565, 299);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(49, 20);
            this.textBox12.TabIndex = 32;
            // 
            // lblMaxYaw
            // 
            this.lblMaxYaw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMaxYaw.AutoSize = true;
            this.lblMaxYaw.Location = new System.Drawing.Point(231, 302);
            this.lblMaxYaw.Name = "lblMaxYaw";
            this.lblMaxYaw.Size = new System.Drawing.Size(51, 13);
            this.lblMaxYaw.TabIndex = 31;
            this.lblMaxYaw.Text = "Max Yaw";
            // 
            // textBox13
            // 
            this.textBox13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox13.Location = new System.Drawing.Point(332, 299);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(51, 20);
            this.textBox13.TabIndex = 30;
            // 
            // lblMinYaw
            // 
            this.lblMinYaw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMinYaw.AutoSize = true;
            this.lblMinYaw.Location = new System.Drawing.Point(31, 302);
            this.lblMinYaw.Name = "lblMinYaw";
            this.lblMinYaw.Size = new System.Drawing.Size(48, 13);
            this.lblMinYaw.TabIndex = 29;
            this.lblMinYaw.Text = "Min Yaw";
            // 
            // textBox14
            // 
            this.textBox14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox14.Location = new System.Drawing.Point(127, 299);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(49, 20);
            this.textBox14.TabIndex = 28;
            // 
            // lblBaseLiftSensitivity
            // 
            this.lblBaseLiftSensitivity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblBaseLiftSensitivity.AutoSize = true;
            this.lblBaseLiftSensitivity.Location = new System.Drawing.Point(431, 212);
            this.lblBaseLiftSensitivity.Name = "lblBaseLiftSensitivity";
            this.lblBaseLiftSensitivity.Size = new System.Drawing.Size(98, 13);
            this.lblBaseLiftSensitivity.TabIndex = 27;
            this.lblBaseLiftSensitivity.Text = "Base Lift Sensitivity";
            // 
            // textBox9
            // 
            this.textBox9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox9.Location = new System.Drawing.Point(565, 209);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(49, 20);
            this.textBox9.TabIndex = 26;
            // 
            // lblBaseMaxLift
            // 
            this.lblBaseMaxLift.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblBaseMaxLift.AutoSize = true;
            this.lblBaseMaxLift.Location = new System.Drawing.Point(231, 212);
            this.lblBaseMaxLift.Name = "lblBaseMaxLift";
            this.lblBaseMaxLift.Size = new System.Drawing.Size(71, 13);
            this.lblBaseMaxLift.TabIndex = 25;
            this.lblBaseMaxLift.Text = "Base Max Lift";
            // 
            // textBox10
            // 
            this.textBox10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox10.Location = new System.Drawing.Point(332, 209);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(51, 20);
            this.textBox10.TabIndex = 24;
            // 
            // lblBaseMinLift
            // 
            this.lblBaseMinLift.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblBaseMinLift.AutoSize = true;
            this.lblBaseMinLift.Location = new System.Drawing.Point(31, 212);
            this.lblBaseMinLift.Name = "lblBaseMinLift";
            this.lblBaseMinLift.Size = new System.Drawing.Size(68, 13);
            this.lblBaseMinLift.TabIndex = 23;
            this.lblBaseMinLift.Text = "Base Min Lift";
            // 
            // textBox11
            // 
            this.textBox11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox11.Location = new System.Drawing.Point(127, 209);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(49, 20);
            this.textBox11.TabIndex = 22;
            // 
            // lblElbowSensitivity
            // 
            this.lblElbowSensitivity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblElbowSensitivity.AutoSize = true;
            this.lblElbowSensitivity.Location = new System.Drawing.Point(431, 260);
            this.lblElbowSensitivity.Name = "lblElbowSensitivity";
            this.lblElbowSensitivity.Size = new System.Drawing.Size(86, 13);
            this.lblElbowSensitivity.TabIndex = 21;
            this.lblElbowSensitivity.Text = "Elbow Sensitivity";
            // 
            // textBox6
            // 
            this.textBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox6.Location = new System.Drawing.Point(565, 257);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(49, 20);
            this.textBox6.TabIndex = 20;
            // 
            // lblElbowMaxLift
            // 
            this.lblElbowMaxLift.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblElbowMaxLift.AutoSize = true;
            this.lblElbowMaxLift.Location = new System.Drawing.Point(231, 260);
            this.lblElbowMaxLift.Name = "lblElbowMaxLift";
            this.lblElbowMaxLift.Size = new System.Drawing.Size(76, 13);
            this.lblElbowMaxLift.TabIndex = 19;
            this.lblElbowMaxLift.Text = "Elbow Max Lift";
            // 
            // textBox7
            // 
            this.textBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox7.Location = new System.Drawing.Point(332, 257);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(51, 20);
            this.textBox7.TabIndex = 18;
            // 
            // lblElbowMinLift
            // 
            this.lblElbowMinLift.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblElbowMinLift.AutoSize = true;
            this.lblElbowMinLift.Location = new System.Drawing.Point(31, 260);
            this.lblElbowMinLift.Name = "lblElbowMinLift";
            this.lblElbowMinLift.Size = new System.Drawing.Size(73, 13);
            this.lblElbowMinLift.TabIndex = 17;
            this.lblElbowMinLift.Text = "Elbow Min Lift";
            // 
            // textBox8
            // 
            this.textBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox8.Location = new System.Drawing.Point(127, 257);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(49, 20);
            this.textBox8.TabIndex = 16;
            // 
            // lblbaseRotationSensitivity
            // 
            this.lblbaseRotationSensitivity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblbaseRotationSensitivity.AutoSize = true;
            this.lblbaseRotationSensitivity.Location = new System.Drawing.Point(431, 164);
            this.lblbaseRotationSensitivity.Name = "lblbaseRotationSensitivity";
            this.lblbaseRotationSensitivity.Size = new System.Drawing.Size(124, 13);
            this.lblbaseRotationSensitivity.TabIndex = 15;
            this.lblbaseRotationSensitivity.Text = "Base Rotation Sensitivity";
            // 
            // textBox5
            // 
            this.textBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox5.Location = new System.Drawing.Point(565, 161);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(49, 20);
            this.textBox5.TabIndex = 14;
            // 
            // lblBaseMaxRotation
            // 
            this.lblBaseMaxRotation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblBaseMaxRotation.AutoSize = true;
            this.lblBaseMaxRotation.Location = new System.Drawing.Point(231, 164);
            this.lblBaseMaxRotation.Name = "lblBaseMaxRotation";
            this.lblBaseMaxRotation.Size = new System.Drawing.Size(97, 13);
            this.lblBaseMaxRotation.TabIndex = 13;
            this.lblBaseMaxRotation.Text = "Base Max Rotation";
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox3.Location = new System.Drawing.Point(332, 161);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(51, 20);
            this.textBox3.TabIndex = 12;
            // 
            // lblbaseMinRotation
            // 
            this.lblbaseMinRotation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblbaseMinRotation.AutoSize = true;
            this.lblbaseMinRotation.Location = new System.Drawing.Point(31, 164);
            this.lblbaseMinRotation.Name = "lblbaseMinRotation";
            this.lblbaseMinRotation.Size = new System.Drawing.Size(94, 13);
            this.lblbaseMinRotation.TabIndex = 11;
            this.lblbaseMinRotation.Text = "Base Min Rotation";
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox4.Location = new System.Drawing.Point(127, 161);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(49, 20);
            this.textBox4.TabIndex = 10;
            // 
            // lblTurnMaxSpeed
            // 
            this.lblTurnMaxSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTurnMaxSpeed.AutoSize = true;
            this.lblTurnMaxSpeed.Location = new System.Drawing.Point(335, 75);
            this.lblTurnMaxSpeed.Name = "lblTurnMaxSpeed";
            this.lblTurnMaxSpeed.Size = new System.Drawing.Size(86, 13);
            this.lblTurnMaxSpeed.TabIndex = 9;
            this.lblTurnMaxSpeed.Text = "Turn Max Speed";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox2.Location = new System.Drawing.Point(458, 72);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(126, 20);
            this.textBox2.TabIndex = 8;
            // 
            // lblFwdSpeed
            // 
            this.lblFwdSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFwdSpeed.AutoSize = true;
            this.lblFwdSpeed.Location = new System.Drawing.Point(37, 75);
            this.lblFwdSpeed.Name = "lblFwdSpeed";
            this.lblFwdSpeed.Size = new System.Drawing.Size(102, 13);
            this.lblFwdSpeed.TabIndex = 7;
            this.lblFwdSpeed.Text = "Forward Max Speed";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox1.Location = new System.Drawing.Point(160, 72);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(126, 20);
            this.textBox1.TabIndex = 1;
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
            this.ClientSize = new System.Drawing.Size(1077, 602);
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
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
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
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtRoverIp;
        private System.Windows.Forms.TextBox txtJoystickMax;
        private System.Windows.Forms.TextBox txtJoystickPollInterval;
        private System.Windows.Forms.TextBox txtJoystickSensitivity;
        private System.Windows.Forms.TextBox txtJoystickZero;
        private System.Windows.Forms.Label lblJoystickPollInterval;
        private System.Windows.Forms.Label lbljoystickMax;
        private System.Windows.Forms.Label lbljoystickSensitivity;
        private System.Windows.Forms.Label lblJoystickZero;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Label lblRoverIp;
        private System.Windows.Forms.Label lblFwdSpeed;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblTurnMaxSpeed;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblBaseLiftSensitivity;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label lblBaseMaxLift;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label lblBaseMinLift;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label lblElbowSensitivity;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label lblElbowMaxLift;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label lblElbowMinLift;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label lblbaseRotationSensitivity;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label lblBaseMaxRotation;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblbaseMinRotation;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lblYawSensitivity;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label lblMaxYaw;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.Label lblMinYaw;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblShoulder;
        private System.Windows.Forms.Label lblElbow;
        private System.Windows.Forms.Label lblWrist;
        private System.Windows.Forms.Label lblScoop;
        private System.Windows.Forms.Label lblBase;
        private System.Windows.Forms.Label lblRight;
        private System.Windows.Forms.Label lblLeft;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkArm;
        private System.Windows.Forms.CheckBox chkRaiseMast;
    }
}

