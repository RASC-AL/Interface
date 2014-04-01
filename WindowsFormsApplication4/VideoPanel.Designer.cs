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
            ((System.ComponentModel.ISupportInitialize)(this.imgVideo)).BeginInit();
            this.SuspendLayout();
            // 
            // imgVideo
            // 
            this.imgVideo.Cursor = System.Windows.Forms.Cursors.Default;
            this.imgVideo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgVideo.Location = new System.Drawing.Point(0, 0);
            this.imgVideo.Name = "imgVideo";
            this.imgVideo.Size = new System.Drawing.Size(303, 295);
            this.imgVideo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgVideo.TabIndex = 0;
            this.imgVideo.TabStop = false;
            // 
            // VideoPanel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(303, 295);
            this.Controls.Add(this.imgVideo);
            this.Name = "VideoPanel";
            this.Text = "VideoPanel";
            ((System.ComponentModel.ISupportInitialize)(this.imgVideo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox imgVideo;



    }
}