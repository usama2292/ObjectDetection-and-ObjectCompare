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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ObjIdentifier));
            this.buttonUpload = new System.Windows.Forms.Button();
            this.buttonScan = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picButton_clockwise = new System.Windows.Forms.PictureBox();
            this.picButton_anticlockwise = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picButton_clockwise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picButton_anticlockwise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonUpload
            // 
            this.buttonUpload.Location = new System.Drawing.Point(230, 242);
            this.buttonUpload.Name = "buttonUpload";
            this.buttonUpload.Size = new System.Drawing.Size(75, 23);
            this.buttonUpload.TabIndex = 0;
            this.buttonUpload.Text = "Upload";
            this.buttonUpload.UseVisualStyleBackColor = true;
            this.buttonUpload.Click += new System.EventHandler(this.buttonUpload_Click);
            // 
            // buttonScan
            // 
            this.buttonScan.Location = new System.Drawing.Point(12, 242);
            this.buttonScan.Name = "buttonScan";
            this.buttonScan.Size = new System.Drawing.Size(75, 23);
            this.buttonScan.TabIndex = 1;
            this.buttonScan.Text = "Scan";
            this.buttonScan.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(13, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(292, 203);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // picButton_clockwise
            // 
            this.picButton_clockwise.ImageLocation = "F:\\6th Semester\\VP Files\\clockwise.jpg";
            this.picButton_clockwise.Location = new System.Drawing.Point(124, 235);
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
            this.picButton_anticlockwise.Location = new System.Drawing.Point(163, 235);
            this.picButton_anticlockwise.Name = "picButton_anticlockwise";
            this.picButton_anticlockwise.Size = new System.Drawing.Size(35, 30);
            this.picButton_anticlockwise.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picButton_anticlockwise.TabIndex = 4;
            this.picButton_anticlockwise.TabStop = false;
            this.picButton_anticlockwise.Click += new System.EventHandler(this.picButton_anticlockwise_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(336, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(292, 203);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(336, 242);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(292, 20);
            this.textBox1.TabIndex = 6;
            // 
            // Form_ObjIdentifier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(648, 275);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.picButton_anticlockwise);
            this.Controls.Add(this.picButton_clockwise);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonScan);
            this.Controls.Add(this.buttonUpload);
            this.Name = "Form_ObjIdentifier";
            this.Text = "Object Identification";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picButton_clockwise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picButton_anticlockwise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonUpload;
        private System.Windows.Forms.Button buttonScan;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picButton_clockwise;
        private System.Windows.Forms.PictureBox picButton_anticlockwise;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

