﻿namespace ObjectIdentification
{
    partial class Face_Detection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Face_Detection));
            this.IC_UploadImg1 = new System.Windows.Forms.Button();
            this.IC_clockwise_img1 = new System.Windows.Forms.PictureBox();
            this.IC_anticlockwise_img1 = new System.Windows.Forms.PictureBox();
            this.IC_buttonDetect = new System.Windows.Forms.Button();
            this.FaceHome = new System.Windows.Forms.PictureBox();
            this.inputImage = new Emgu.CV.UI.ImageBox();
            this.outputImage = new Emgu.CV.UI.ImageBox();
            ((System.ComponentModel.ISupportInitialize)(this.IC_clockwise_img1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IC_anticlockwise_img1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FaceHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputImage)).BeginInit();
            this.SuspendLayout();
            // 
            // IC_UploadImg1
            // 
            this.IC_UploadImg1.Location = new System.Drawing.Point(13, 242);
            this.IC_UploadImg1.Name = "IC_UploadImg1";
            this.IC_UploadImg1.Size = new System.Drawing.Size(93, 30);
            this.IC_UploadImg1.TabIndex = 2;
            this.IC_UploadImg1.Text = "Upload";
            this.IC_UploadImg1.UseVisualStyleBackColor = true;
            this.IC_UploadImg1.Click += new System.EventHandler(this.IC_UploadImg1_Click);
            // 
            // IC_clockwise_img1
            // 
            this.IC_clockwise_img1.ImageLocation = "C:\\Users\\Dell\\Documents\\Visual Studio 2013\\Projects\\ObjectIdentification\\VP Files" +
    "\\clockwise.jpg";
            this.IC_clockwise_img1.Location = new System.Drawing.Point(125, 242);
            this.IC_clockwise_img1.Name = "IC_clockwise_img1";
            this.IC_clockwise_img1.Size = new System.Drawing.Size(33, 30);
            this.IC_clockwise_img1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IC_clockwise_img1.TabIndex = 4;
            this.IC_clockwise_img1.TabStop = false;
            this.IC_clockwise_img1.Click += new System.EventHandler(this.IC_clockwise_img1_Click);
            // 
            // IC_anticlockwise_img1
            // 
            this.IC_anticlockwise_img1.ImageLocation = "C:\\Users\\Dell\\Documents\\Visual Studio 2013\\Projects\\ObjectIdentification\\VP Files" +
    "\\anti clockwise.jpg";
            this.IC_anticlockwise_img1.Location = new System.Drawing.Point(164, 242);
            this.IC_anticlockwise_img1.Name = "IC_anticlockwise_img1";
            this.IC_anticlockwise_img1.Size = new System.Drawing.Size(33, 30);
            this.IC_anticlockwise_img1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IC_anticlockwise_img1.TabIndex = 5;
            this.IC_anticlockwise_img1.TabStop = false;
            this.IC_anticlockwise_img1.Click += new System.EventHandler(this.IC_anticlockwise_img1_Click);
            // 
            // IC_buttonDetect
            // 
            this.IC_buttonDetect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IC_buttonDetect.Location = new System.Drawing.Point(307, 174);
            this.IC_buttonDetect.Name = "IC_buttonDetect";
            this.IC_buttonDetect.Size = new System.Drawing.Size(71, 51);
            this.IC_buttonDetect.TabIndex = 8;
            this.IC_buttonDetect.Text = "Detect";
            this.IC_buttonDetect.UseVisualStyleBackColor = true;
            this.IC_buttonDetect.Click += new System.EventHandler(this.IC_buttonDetect_Click);
            // 
            // FaceHome
            // 
            this.FaceHome.ImageLocation = "C:\\Users\\Dell\\Documents\\Visual Studio 2013\\Projects\\ObjectIdentification\\VP Files" +
    "\\Home.png";
            this.FaceHome.Location = new System.Drawing.Point(631, 242);
            this.FaceHome.Name = "FaceHome";
            this.FaceHome.Size = new System.Drawing.Size(45, 43);
            this.FaceHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FaceHome.TabIndex = 9;
            this.FaceHome.TabStop = false;
            this.FaceHome.Click += new System.EventHandler(this.FaceHome_Click_1);
            // 
            // inputImage
            // 
            this.inputImage.Location = new System.Drawing.Point(13, 13);
            this.inputImage.Name = "inputImage";
            this.inputImage.Size = new System.Drawing.Size(290, 212);
            this.inputImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.inputImage.TabIndex = 2;
            this.inputImage.TabStop = false;
            // 
            // outputImage
            // 
            this.outputImage.Location = new System.Drawing.Point(384, 13);
            this.outputImage.Name = "outputImage";
            this.outputImage.Size = new System.Drawing.Size(277, 212);
            this.outputImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.outputImage.TabIndex = 2;
            this.outputImage.TabStop = false;
            // 
            // Face_Detection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(688, 297);
            this.Controls.Add(this.outputImage);
            this.Controls.Add(this.inputImage);
            this.Controls.Add(this.FaceHome);
            this.Controls.Add(this.IC_buttonDetect);
            this.Controls.Add(this.IC_anticlockwise_img1);
            this.Controls.Add(this.IC_clockwise_img1);
            this.Controls.Add(this.IC_UploadImg1);
            this.Name = "Face_Detection";
            this.Text = "Face Detector";
            ((System.ComponentModel.ISupportInitialize)(this.IC_clockwise_img1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IC_anticlockwise_img1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FaceHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button IC_UploadImg1;
        private System.Windows.Forms.PictureBox IC_clockwise_img1;
        private System.Windows.Forms.PictureBox IC_anticlockwise_img1;
        private System.Windows.Forms.Button IC_buttonDetect;
        private System.Windows.Forms.PictureBox FaceHome;
        private Emgu.CV.UI.ImageBox inputImage;
        private Emgu.CV.UI.ImageBox outputImage;
    }
}