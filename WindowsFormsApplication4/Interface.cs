using System;
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
using System.Diagnostics;



namespace RoboOps.Interface
{
    public partial class Interface : Form
    {
        Joystick joystick;
        string type;
        Gamepad gamepad;
        MjpegDecoder _mjpeg;
        RoverComm comm;
        Dictionary<String, CancellationTokenSource> cancelTasks = new Dictionary<String, CancellationTokenSource>();
        Stopwatch fpsCalculate = new Stopwatch();
        VideoPanel streamPanel;

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
            MainForJoystick();
            // MainForGamePad();

        }

        private void mjpeg_FrameReady(object sender, FrameReadyEventArgs e)
        {
            streamPanel.imgVideo.Image = e.Bitmap;
            var size = e.Bitmap.Size;


            //Calculate frame rate
            if (!fpsCalculate.IsRunning)
                fpsCalculate.Start();
            else
            {
                lblFps.Text = (1000.0d / fpsCalculate.ElapsedMilliseconds).ToString("F") + " fps";
                fpsCalculate.Restart();
            }
        }

        //void MainForGamePad()
        //{
        //    gamepad = new Gamepad();
        //    System.Windows.Forms.Timer pollTimer = new System.Windows.Forms.Timer();
        //    pollTimer.Tick += pollGamepad;
        //    pollTimer.Interval = Constants.joystickTimeSensitivity;

        //    pollTimer.Start();
        //}

        //void pollGamepad(Object myObject, EventArgs myEventArgs)
        //{
        //    gamepad.GetGamepadButton();
        //}

        void MainForJoystick()
        {
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
        State lastState = State.Stop;

        private enum State 
        {
            Stop,
            MoveLeft,
            MoveRight,
            MoveFwd,
            MoveBack
        }

        private void pollJoystick(Object myObject, EventArgs myEventArgs)
        {
            joystick.Poll();

            var state = joystick.GetCurrentState();

            if (state.PointOfViewControllers[0] == 27000)
            {
                if (!(lastState == State.MoveLeft))
                {
                    MoveLeft();
                    lastState = State.MoveLeft;
                }
            }
            if (state.PointOfViewControllers[0] == 9000)
            {
                if (!(lastState == State.MoveRight))
                {
                    MoveRight();
                    lastState = State.MoveRight;
                }
            }
            if (state.PointOfViewControllers[0] == 0)
            {
                if (!(lastState == State.MoveFwd))
                {
                    MoveFwd();
                    lastState = State.MoveFwd;
                }
            }
            if (state.PointOfViewControllers[0] == 18000)
            {
                if (!(lastState == State.MoveBack))
                {
                    MoveBack();
                    lastState = State.MoveBack;
                }
            }
            if (state.PointOfViewControllers[0] == -1)
            {
                if (!(lastState == State.Stop))
                {
                    Stop();
                    lastState = State.Stop;
                }
            }


            if (Math.Max(lastStateX, originX) - Math.Min(lastStateX, originX) >= Constants.joystickSensitivity || Math.Max(lastStateY, originY) - Math.Min(lastStateY, originY) >= Constants.joystickSensitivity)
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

        private void MoveLeft()
        {
            comm.MoveRover(-Constants.turnSpeed, Constants.turnSpeed);
        }

        private void MoveRight()
        {
            comm.MoveRover(Constants.turnSpeed, -Constants.turnSpeed);
        }

        private void MoveFwd()
        {
            comm.MoveRover(Constants.fwdSpeed, Constants.fwdSpeed);
        }

        private void MoveBack()
        {
            comm.MoveRover(-Constants.turnSpeed, -Constants.turnSpeed);
        }
        
        private void Stop()
        {
            comm.MoveRover(0, 0);
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
            streamPanel = new VideoPanel();
            streamPanel.Show();
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
            streamPanel.Close();
            _mjpeg.StopStream();
            fpsCalculate.Reset();
        }

        private void rbtnCam_Click(object sender, EventArgs e)
        {
            var rbtnCam = (RadioButton)sender;
            comm.ChangeCamera(int.Parse(rbtnCam.Name[rbtnCam.Name.Length - 1].ToString()));
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void rbtnCam4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnCam3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnCam2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnCam1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblCoordinates_Click(object sender, EventArgs e)
        {

        }

        private void rbtnCam5_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
