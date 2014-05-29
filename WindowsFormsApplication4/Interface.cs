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
using System.Net;
using System.IO;
using System.Net.Sockets;


namespace RoboOps.Interface
{
    public partial class Interface : Form
    {
        Joystick joystick;
        string type;
        RoverComm comm;
        
        VideoPanel streamPanel;

        public Interface()
        {

            InitializeComponent();
            
            this.comm = new RoverComm(Constants.RoverIP, Constants.RoverPort);  // Initialize the communication module

            MainForJoystick();

        }


     

        public void SendData(byte[] data)
        {
            UdpClient client = new UdpClient();
            var remoteEP = new IPEndPoint(IPAddress.Parse("128.205.54.6"), 8081);
            //TcpClient client = new TcpClient();
            client.Connect(remoteEP);
            client.Send(data,data.Length);
        }

  
        void MainForJoystick()
        {
            bool controllerFound = true;
            try
            {
                initialize_joystick();
            }
            catch (Exception ex)
            {
                if (ex.Message == "controllerNotFound")
                {
                    controllerFound = false;
                    lblError.Text = "Could not find controller. Please connect it and restart the application.\nIf problem persists, contact Bill!";
                }
            }
            if (controllerFound)
            {
                System.Windows.Forms.Timer pollTimer = new System.Windows.Forms.Timer();
                pollTimer.Tick += pollJoystick;
                pollTimer.Interval = Constants.joystickTimeSensitivity;

                pollTimer.Start();
            }
        }

        int baseRotation = 144, baseLift = 90, elbow = 130, yaw = 175; //TODO: Assign initial encoder value
        bool scoop = false;
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
                yaw -= Constants.yawSensitivity;
                moveArm = true;
            }
            if (state.RotationX >= Constants.joystickMaxPose - Constants.joystickSensitivity && yaw < Constants.yawMax)
            {
                yaw += Constants.yawSensitivity;
                moveArm = true;
            }
            if (state.RotationY <= Constants.joystickSensitivity && elbow < Constants.elbowMaxLift)
            {
                elbow += Constants.elbowSensitivity;
                moveArm = true;
            }
            if (state.RotationY >= Constants.joystickMaxPose - Constants.joystickSensitivity && elbow > Constants.elbowMinLift)
            {
                elbow -= Constants.elbowSensitivity;
                moveArm = true;
            }
            if (state.Buttons[0])
            {
                scoop = !scoop;
                moveArm = true;
            }

            if (moveArm)
            {
                lblBase.Text = "Base: " + baseRotation.ToString();
                lblShoulder.Text = "Shoulder: " + baseLift.ToString();
                lblElbow.Text = "Elbow: " + elbow.ToString();
                lblWrist.Text = "Wrist: " + yaw.ToString();
                lblScoop.Text = "Scoop: " + scoop.ToString();
                comm.MoveArm(baseRotation, baseLift, elbow, yaw, scoop ? Constants.scoopOpen : Constants.scoopClose);
            }
            

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
            lblLeft.Text = "Left speed\n" + (-Constants.turnSpeed * drvSpeed.Value / 100).ToString();
            lblRight.Text = "Right speed\n" + (Constants.turnSpeed * drvSpeed.Value / 100).ToString();
            comm.MoveRover(-Constants.turnSpeed * drvSpeed.Value / 100, Constants.turnSpeed * drvSpeed.Value / 100);
        }

        private void MoveRight()
        {
            lblLeft.Text = "Left speed\n" + (Constants.turnSpeed * drvSpeed.Value / 100).ToString();
            lblRight.Text = "Right speed\n" + (-Constants.turnSpeed * drvSpeed.Value / 100).ToString();
            comm.MoveRover(Constants.turnSpeed * drvSpeed.Value / 100, -Constants.turnSpeed * drvSpeed.Value / 100);
        }

        private void MoveFwd()
        {
            lblLeft.Text = "Left speed\n" + (Constants.fwdSpeed * drvSpeed.Value / 100).ToString();
            lblRight.Text = "Right speed\n" + (Constants.fwdSpeed * drvSpeed.Value / 100).ToString();
            comm.MoveRover(Constants.fwdSpeed * drvSpeed.Value / 100, Constants.fwdSpeed * drvSpeed.Value / 100);
        }

        private void MoveBack()
        {
            lblLeft.Text = "Left speed\n" + (-Constants.turnSpeed * drvSpeed.Value / 100).ToString();
            lblRight.Text = "Right speed\n" + (-Constants.turnSpeed * drvSpeed.Value / 100).ToString();
            comm.MoveRover(-Constants.turnSpeed * drvSpeed.Value / 100, -Constants.turnSpeed * drvSpeed.Value / 100);
        }
        
        private void Stop()
        {
            lblLeft.Text = "Left speed\n" + (0).ToString();
            lblRight.Text = "Right speed\n" + (0).ToString();
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
                throw new Exception("controllerNotFound");
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



        private void btnStartStream_Click(object sender, EventArgs e)
        {
            streamPanel = new VideoPanel(comm);
            streamPanel.Show();

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
        }

        private void CheckedChanged(object sender, EventArgs e)
        {
            comm.ChangeRelay(chkRaiseMast.Checked, chkArm.Checked);
        }

    }
}
