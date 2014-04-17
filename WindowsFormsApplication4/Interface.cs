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

            MainForJoystick();

        }

        private void mjpeg_FrameReady(object sender, FrameReadyEventArgs e)
        {
            streamPanel.imgVideo.Image = e.Bitmap;
            var size = e.Bitmap.Size;
            var newFrameSize = new Size(streamPanel.imgVideo.Size.Width, size.Height * streamPanel.imgVideo.Size.Width / size.Width);
            if(newFrameSize.Height<=streamPanel.Size.Height) 
                streamPanel.imgVideo.Size = newFrameSize;

            //Calculate frame rate
            if (!fpsCalculate.IsRunning)
                fpsCalculate.Start();
            else
            {
                lblFps.Text = (1000.0d / fpsCalculate.ElapsedMilliseconds).ToString("F") + " fps";
                fpsCalculate.Restart();
            }
        }

  
        void MainForJoystick()
        {
            initialize_joystick();

            System.Windows.Forms.Timer pollTimer = new System.Windows.Forms.Timer();
            pollTimer.Tick += pollJoystick;
            pollTimer.Interval = Constants.joystickTimeSensitivity;

            pollTimer.Start();

        }

        int baseRotation = 40, baseLift = -20, elbow = 10, yaw = 10; //TODO: Assign initial encoder value
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
            
            //Arrow keys to drive rover
            DriveMotors(state);

            //Joysticks to move arm
            ArmControl(state);
        }

        private void ArmControl(JoystickState state)
        {
            //Base control
            bool moveArm = false;
            if (state.X <= Constants.joystickSensitivity && baseRotation > Constants.baseMinRotation)
            {
                baseRotation -= Constants.baseRotationSensitivity;
                moveArm = true;
            }
            if (state.X >= Constants.joystickMaxPose - Constants.joystickSensitivity && baseRotation < Constants.baseMaxRotation)
            {
                baseRotation += Constants.baseRotationSensitivity;
                moveArm = true;
            }
            if (state.Y <= Constants.joystickSensitivity && baseLift < Constants.baseMaxLift)
            {
                baseLift += Constants.baseLiftSensitivity;
                moveArm = true;
            }
            if (state.Y >= Constants.joystickMaxPose - Constants.joystickSensitivity && baseLift > Constants.baseMinLift)
            {
                baseLift -= Constants.baseLiftSensitivity;
                moveArm = true;
            }

            //Elbow and yaw control
            if (state.RotationX <= Constants.joystickSensitivity && yaw > Constants.yawMin)
            {
                yaw -= Constants.baseRotationSensitivity;
                moveArm = true;
            }
            if (state.RotationX >= Constants.joystickMaxPose - Constants.joystickSensitivity && yaw < Constants.yawMax)
            {
                yaw += Constants.baseRotationSensitivity;
                moveArm = true;
            }
            if (state.RotationY <= Constants.joystickSensitivity && elbow < Constants.elbowMaxLift)
            {
                elbow += Constants.baseLiftSensitivity;
                moveArm = true;
            }
            if (state.RotationY >= Constants.joystickMaxPose - Constants.joystickSensitivity && elbow > Constants.elbowMinLift)
            {
                elbow -= Constants.baseLiftSensitivity;
                moveArm = true;
            }

            if (moveArm)
                comm.MoveArm(baseRotation, baseLift, elbow, yaw);
        }

        private void DriveMotors(JoystickState state)
        {
            if (state.Z > Constants.joystickMaxPose - Constants.joystickSensitivity)
                Stop();
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
        }

        private void MoveLeft()
        {
            comm.MoveRover(-Constants.turnSpeed * drvSpeed.Value / 100, Constants.turnSpeed * drvSpeed.Value / 100);
        }

        private void MoveRight()
        {
            comm.MoveRover(Constants.turnSpeed * drvSpeed.Value / 100, -Constants.turnSpeed * drvSpeed.Value / 100);
        }

        private void MoveFwd()
        {
            comm.MoveRover(Constants.fwdSpeed * drvSpeed.Value / 100, Constants.fwdSpeed * drvSpeed.Value / 100);
        }

        private void MoveBack()
        {
            comm.MoveRover(-Constants.turnSpeed * drvSpeed.Value / 100, -Constants.turnSpeed * drvSpeed.Value / 100);
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


        private void button9_Click(object sender, EventArgs e)
        {
            Settings f2 = new Settings();
            f2.ShowDialog();
        }

        private void btnStartStream_Click(object sender, EventArgs e)
        {
            streamPanel = new VideoPanel();
            streamPanel.Show();
            _mjpeg.ParseStream(new Uri("http://166.149.188.104:8080/stream?topic=/chatter"));
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
            if(rbtnCam.Checked)
                comm.ChangeCamera(int.Parse(rbtnCam.Name[rbtnCam.Name.Length - 1].ToString()));
        }

       
    }
}
