namespace ObjectIdentification
{
    partial class Form_ObjIdentifier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ObjIdentifier));
            this.buttonUpload = new System.Windows.Forms.Button();
            this.buttonScan = new System.Windows.Forms.Button();
            this.picButton_clockwise = new System.Windows.Forms.PictureBox();
            this.picButton_anticlockwise = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.OI_inputImage = new Emgu.CV.UI.ImageBox();
            ((System.ComponentModel.ISupportInitialize)(this.picButton_clockwise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picButton_anticlockwise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OI_inputImage)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonUpload
            // 
            this.buttonUpload.Location = new System.Drawing.Point(13, 242);
            this.buttonUpload.Name = "buttonUpload";
            this.buttonUpload.Size = new System.Drawing.Size(88, 33);
            this.buttonUpload.TabIndex = 0;
            this.buttonUpload.Text = "Upload";
            this.buttonUpload.UseVisualStyleBackColor = true;
            this.buttonUpload.Click += new System.EventHandler(this.buttonUpload_Click);
            // 
            // buttonScan
            // 
            this.buttonScan.Location = new System.Drawing.Point(309, 175);
            this.buttonScan.Name = "buttonScan";
            this.buttonScan.Size = new System.Drawing.Size(75, 50);
            this.buttonScan.TabIndex = 1;
            this.buttonScan.Text = "Scan";
            this.buttonScan.UseVisualStyleBackColor = true;
            // 
            // picButton_clockwise
            // 
            this.picButton_clockwise.ImageLocation = "F:\\6th Semester\\VP Files\\clockwise.jpg";
            this.picButton_clockwise.Location = new System.Drawing.Point(124, 242);
            this.picButton_clockwise.Name = "picButton_clockwise";
            this.picButton_clockwise.Size = new System.Drawing.Size(33, 30);
            this.picButton_clockwise.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picButton_clockwise.TabIndex = 3;
            this.picButton_clockwise.TabStop = false;
            this.picButton_clockwise.Click += new System.EventHandler(this.picButton_clockwise_Click);
            // 
            // picButton_anticlockwise
            // 
            this.picButton_anticlockwise.ImageLocation = "F:\\6th Semester\\VP Files\\anti clockwise.jpg";
            this.picButton_anticlockwise.Location = new System.Drawing.Point(163, 242);
            this.picButton_anticlockwise.Name = "picButton_anticlockwise";
            this.picButton_anticlockwise.Size = new System.Drawing.Size(35, 30);
            this.picButton_anticlockwise.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picButton_anticlockwise.TabIndex = 4;
            this.picButton_anticlockwise.TabStop = false;
            this.picButton_anticlockwise.Click += new System.EventHandler(this.picButton_anticlockwise_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(386, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(290, 213);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.ImageLocation = "C:\\Users\\Dell\\Documents\\Visual Studio 2013\\Projects\\ObjectIdentification\\VP Files" +
    "\\Home.png";
            this.pictureBox3.Location = new System.Drawing.Point(631, 242);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(45, 43);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // OI_inputImage
            // 
            this.OI_inputImage.Location = new System.Drawing.Point(21, 12);
            this.OI_inputImage.Name = "OI_inputImage";
            this.OI_inputImage.Size = new System.Drawing.Size(282, 213);
            this.OI_inputImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.OI_inputImage.TabIndex = 2;
            this.OI_inputImage.TabStop = false;
            // 
            // Form_ObjIdentifier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(688, 297);
            this.Controls.Add(this.OI_inputImage);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.picButton_anticlockwise);
            this.Controls.Add(this.picButton_clockwise);
            this.Controls.Add(this.buttonScan);
            this.Controls.Add(this.buttonUpload);
            this.Name = "Form_ObjIdentifier";
            this.Text = "Object Identification";
            ((System.ComponentModel.ISupportInitialize)(this.picButton_clockwise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picButton_anticlockwise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OI_inputImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonUpload;
        private System.Windows.Forms.Button buttonScan;
        private System.Windows.Forms.PictureBox picButton_clockwise;
        private System.Windows.Forms.PictureBox picButton_anticlockwise;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Emgu.CV.UI.ImageBox OI_inputImage;
    }
}

