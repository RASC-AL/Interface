﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SharpDX.DirectInput;
using MjpegProcessor;
using RoboOps.HomeClient;
using System.Threading.Tasks;
using System.Threading;



namespace RoboOps.Interface
{
    public partial class Interface : Form
    {
        Joystick joystick;
        string type;

        MjpegDecoder _mjpeg;
        RoverComm comm;
        Dictionary<String, CancellationTokenSource> cancelTasks = new Dictionary<String, CancellationTokenSource>();

        public Interface()
        {

            InitializeComponent();
            _mjpeg = new MjpegDecoder();  // Initialize the Mjpeg decoder library
            _mjpeg.FrameReady += mjpeg_FrameReady; // Set the event which will be triggered when frame is received

            this.comm = new RoverComm(Constants.RoverIP, Constants.RoverPort);  // Initialize the communication module

            // Start receiving joystick input on spearate thread. Add cancellation token which will be invoked when form is closed.
            //cancelTasks.Add("joystick1", new CancellationTokenSource());
            //CancellationToken ct = cancelTasks["joystick1"].Token;
            //Task.Factory.StartNew(() => MainForJoystick(lblCoordinates), ct);

            initialize_joystick();

            System.Windows.Forms.Timer pollTimer = new System.Windows.Forms.Timer();
            pollTimer.Tick += pollJoystick;
            pollTimer.Interval = Constants.joystickTimeSensitivity;

            pollTimer.Start();

        }

        private void mjpeg_FrameReady(object sender, FrameReadyEventArgs e)
        {
            imgVideo.Image = e.Bitmap;
        }

        void MainForJoystick(Label labelCoordinates)
        {
            // Initialize DirectInput
            initialize_joystick();

            System.Windows.Forms.Timer pollTimer = new System.Windows.Forms.Timer();
            pollTimer.Tick += pollJoystick;
            pollTimer.Interval = Constants.joystickTimeSensitivity;

            pollTimer.Start();


        }

        int originX = 0;
        int originY = 0;
        int lastStateX = -1;
        int lastStateY = -1;
        int theta1 = 0, theta2 = 0, theta3 = 0;

        private void pollJoystick(Object myObject, EventArgs myEventArgs)
        {
            joystick.Poll();
            
            var state = joystick.GetCurrentState();
            double theta = 0.0;
            double radius = 0.0;

            lastStateX = state.X - Constants.joystickZeroPose;
            lastStateY = Constants.joystickZeroPose - state.Y;
            
            if (lastStateX != -1 && lastStateY != -1)
            {
                if (Math.Max(lastStateX, originX) - Math.Min(lastStateX, originX) >= Constants.joystickSensitivity || Math.Max(lastStateY, originY) - Math.Min(lastStateY, originY) >= Constants.joystickSensitivity || (state.PointOfViewControllers[0] == 0 || state.PointOfViewControllers[0] == 18000))
                {
                    if (false)
                    {
                        theta = Math.Round((Math.Atan2(lastStateY, lastStateX) * 180) / Math.PI);
                        radius = Math.Round(Math.Sqrt(Math.Pow(originX, 2) + Math.Pow(originY, 2)));

                        MoveRover(originX, originY, radius, theta);
                    }
                    else
                    {
                        theta1 = originX * Constants.baseMaxRotation / (2 * Constants.joystickMaxPose) + 90;
                        theta2 = originY * Constants.baseMaxAngle / Constants.joystickMaxPose;
                        if (state.PointOfViewControllers[0] == 0)
                            theta3 += Constants.elbowSensitivity;
                        else if (state.PointOfViewControllers[0] == 18000)
                            theta3 += Constants.elbowSensitivity;

                        comm.MoveArm(theta1, theta2, theta3);
                    }
                }

                originX = lastStateX;
                originY = lastStateY;
            }

        }

        private void MoveRover(int x, int y, double radius, double theta)
        {
            // Max = 65535 Center between 32767 and 32511  sensititvity 256
            // Invoke the Background worker thread (UI thread) from joystick i/p thread to send the value of X and Y position of joystick
            if (this.lblCoordinates.InvokeRequired)
            {
                this.lblCoordinates.BeginInvoke(
                    new MethodInvoker(delegate()
                        {
                            this.lblCoordinates.Text = "X:" + x.ToString()
                                                        + " Y:" + y.ToString()/*; }));//*/
                                                        + " R:" + radius.ToString()
                                                        + " T:" + theta.ToString();
                        }));
            }
            else
            {
                this.lblCoordinates.Text = "X:" + x.ToString()
                                                        + " Y:" + y.ToString()/*; }));//*/
                                                        + " R:" + radius.ToString()
                                                        + " T:" + theta.ToString();
            }
            if (theta <= 0)
                comm.MoveBackward(radius, -theta);
            else
                comm.MoveForward(radius, theta);
        }



        private void button1_Click(object sender, EventArgs e)
        {
            type = "arm";
        }

        private void initialize_joystick()
        {
            var directInput = new DirectInput();

            // Find a Joystick Guid
            var joystickGuid = Guid.Empty;

            foreach (var deviceInstance in directInput.GetDevices(DeviceType.Gamepad, DeviceEnumerationFlags.AllDevices))
                joystickGuid = deviceInstance.InstanceGuid;

            // If Gamepad not found, look for a Joystick
            if (joystickGuid == Guid.Empty)
                foreach (var deviceInstance in directInput.GetDevices(DeviceType.Joystick, DeviceEnumerationFlags.AllDevices))
                    joystickGuid = deviceInstance.InstanceGuid;

            // If Joystick not found, throws an error
            if (joystickGuid == Guid.Empty)
            {
                Console.WriteLine("No joystick/Gamepad found.");
                Console.ReadKey();
                Environment.Exit(1);
            }
            // Instantiate the joystick
            joystick = new Joystick(directInput, joystickGuid);

            Console.WriteLine("Found Joystick/Gamepad with GUID: {0}", joystickGuid);

            // Query all suported ForceFeedback effects
            var allEffects = joystick.GetEffects();
            foreach (var effectInfo in allEffects)
                Console.WriteLine("Effect available {0}", effectInfo.Name);

            // Set BufferSize in order to use buffered data.
            joystick.Properties.BufferSize = 128;

            // Acquire the joystick
            joystick.Acquire();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            type = "drive";// for driving 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // open
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // close
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // arm home
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // connect rover
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Settings f2 = new Settings();
            f2.ShowDialog();
        }

        private void btnStartStream_Click(object sender, EventArgs e)
        {
            _mjpeg.ParseStream(new Uri("http://128.205.54.5:8080/stream?topic=/chatter"));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //foreach (var cancelTask in cancelTasks)
            //{
            //    cancelTask.Value.Cancel();
            //}
        }

        private void btnStopStream_Click(object sender, EventArgs e)
        {
            _mjpeg.StopStream();
        }

        private void rbtnCam_Click(object sender, EventArgs e)
        {
            var rbtnCam = (RadioButton)sender;
            comm.ChangeCamera(int.Parse(rbtnCam.Name[rbtnCam.Name.Length-1].ToString()));            
        }
    }
}
