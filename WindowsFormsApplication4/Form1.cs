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



namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        Joystick joystick;
         string type;
         string serial_port;
         MjpegDecoder _mjpeg;

        public Form1()
        {

            // Create a main loop for GLib, run it in a separate thread
         
            InitializeComponent();
            _mjpeg = new MjpegDecoder();
            _mjpeg.FrameReady += mjpeg_FrameReady;
        }

        private void mjpeg_FrameReady(object sender, FrameReadyEventArgs e)
        {
            imgVideo.Image = e.Bitmap;
        }
    
         void MainForJoystick()
        {
            // Initialize DirectInput
           
            string s ;
            var originX = 0;
            var originY = 0;
            var lastStateX = -1;
            var lastStateY = -1;
            var startFlag = false;
            while (true)
            {
                joystick.Poll();
                var datas = joystick.GetBufferedData();
                double theta = 0.0;
                double radius = 0.0;

                foreach (var state in datas)
                {
                    if (state.Sequence == 1)
                    {
                        s = (state.Offset).ToString();
                        if (s == "X")
                            originX = state.Value;
                        else if (s == "Y")
                            originY = state.Value;
                    }
                    s = (state.Offset).ToString();
                    if (s == "X")
                        lastStateX = state.Value;
                    else if (s == "Y")
                        lastStateY = state.Value;
                    startFlag = true;
                }
                if (startFlag && datas.Length == 0 && lastStateX != -1 && lastStateY != -1)
                {
                    var slope = 0.0;
                    if ((lastStateX - originX) == 0)
                        slope = Math.PI / 2;
                    else
                        slope = (lastStateY - originY) / (lastStateX - originX);
                    theta = (Math.Atan(slope) * 180) / Math.PI;
                    radius = Math.Sqrt(Math.Pow(originX - lastStateX, 2) + Math.Pow(originY - lastStateY, 2));
                    originX = lastStateX;
                    originY = lastStateY;
                    Console.WriteLine(theta);
                    Console.WriteLine(radius);
                    startFlag = false;
                }
            }
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            serial_port = "COM1";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            serial_port = "COM2";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            serial_port = "COM3";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            serial_port = "COM4";
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            serial_port = "COM5";
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
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void btnStartStream_Click(object sender, EventArgs e)
        {
            _mjpeg.ParseStream(new Uri("http://128.205.54.5:8080/stream?topic=/camera/image_raw"));

         
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
   
        }

        private void btnStopStream_Click(object sender, EventArgs e)
        {

        }
    }
}
