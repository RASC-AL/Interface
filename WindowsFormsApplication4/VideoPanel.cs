using MjpegProcessor;
using RoboOps.HomeClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Net.Sockets;
using System.Net;


namespace RoboOps.Interface
{
    public partial class VideoPanel : Form
    {
        RoverComm comm;
        MjpegDecoder _mjpeg;
        Stopwatch fpsCalculate = new Stopwatch();
        int currentCam = 1;

        public VideoPanel(RoverComm commModule)
        {
            comm = commModule;
            InitializeComponent();
            _mjpeg = new MjpegDecoder();  // Initialize the Mjpeg decoder library
            _mjpeg.FrameReady += mjpeg_FrameReady; // Set the event which will be triggered when frame is received

            _mjpeg.ParseStream(new Uri("http://128.205.54.5:8080/stream?topic=/chatter"));
            
            ///////////////////////////////////

          

        }

        /// <summary>
        /// /////////////////
        /// </summary>
        /// 
      

        
        /////////////////////
        public int fps = 30;
        public int width = 1024;
        public int height = 1024;
        public int pan = 0;
        public int tilt = 0;
        public int zoom = 0;


        private void mjpeg_FrameReady(object sender, FrameReadyEventArgs e)
        {
            imgVideo.Image = e.Bitmap;

            ImageConverter img = new ImageConverter();
            byte[] bytes = (byte[])img.ConvertTo(e.Bitmap, typeof(byte[]));
            //ImageListStreamer
            //SendData(bytes);
            var size = e.Bitmap.Size;
            var newFrameSize = new Size(Size.Width - 200, size.Height * (Size.Width) / size.Width);
            if (newFrameSize.Height <= Size.Height)
                imgVideo.Size = newFrameSize;

            //Calculate frame rate
            if (!fpsCalculate.IsRunning)
                fpsCalculate.Start();
            else
            {
                lblFps.Text = (1000.0d / fpsCalculate.ElapsedMilliseconds).ToString("F") + " fps";
                fpsCalculate.Restart();
            }
        }

        private void imgVideo_Click(object sender, EventArgs e)
        {

        }

        private void barFps_ValueChanged(object sender, EventArgs e)
        {
            fps = ((TrackBar)sender).Value;
            lblBarFps.Text = fps.ToString() + "fps";
        }

        private void barWidth_ValueChanged(object sender, EventArgs e)
        {
            width = ((TrackBar)sender).Value;
            lblWidth.Text = "W: " + width.ToString();
        }

        private void barHeight_ValueChanged(object sender, EventArgs e)
        {
            height = ((TrackBar)sender).Value;
            lblHeight.Text = "H: " + height.ToString();
        }

        private void rbtnCam_Click(object sender, EventArgs e)
        {
            var rbtnCam = (RadioButton)sender;
            if (rbtnCam.Checked)
            {
                currentCam = int.Parse(rbtnCam.Name[rbtnCam.Name.Length - 1].ToString());
                comm.ChangeCamera(currentCam, fps, width, height);
                
            }
        }

        private void VideoPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            _mjpeg.StopStream();
            fpsCalculate.Reset();
        }

        private void btnApply_MouseClick(object sender, MouseEventArgs e)
        {
            comm.ChangeCamera(currentCam, fps, width, height);
        }

        private void barTilt_ValueChanged(object sender, EventArgs e)
        {
            tilt = ((TrackBar)sender).Value;
            lblTilt.Text = "T: " + tilt.ToString();
        }

        private void barZoom_Scroll(object sender, EventArgs e)
        {
            zoom = ((TrackBar)sender).Value;
            lblZoom.Text = "Z: " + zoom.ToString();
        }

        private void barPan_ValueChanged(object sender, EventArgs e)
        {
            pan = ((TrackBar)sender).Value;
            lblPan.Text = "P: " + pan.ToString();
        }

    }
}
