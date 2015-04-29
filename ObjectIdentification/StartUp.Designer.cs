namespace ObjectIdentification
{
    partial class StartUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartUp));
            this.ObjectDetector = new System.Windows.Forms.Button();
            this.FaceDetector = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ObjectDetector
            // 
            this.ObjectDetector.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ObjectDetector.Location = new System.Drawing.Point(239, 156);
            this.ObjectDetector.Name = "ObjectDetector";
            this.ObjectDetector.Size = new System.Drawing.Size(136, 67);
            this.ObjectDetector.TabIndex = 0;
            this.ObjectDetector.Text = "Object Detection";
            this.ObjectDetector.UseVisualStyleBackColor = true;
            this.ObjectDetector.Click += new System.EventHandler(this.ObjectDetector_Click);
            // 
            // FaceDetector
            // 
            this.FaceDetector.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FaceDetector.Location = new System.Drawing.Point(46, 156);
            this.FaceDetector.Name = "FaceDetector";
            this.FaceDetector.Size = new System.Drawing.Size(136, 67);
            this.FaceDetector.TabIndex = 1;
            this.FaceDetector.Text = "Face Detection";
            this.FaceDetector.UseVisualStyleBackColor = true;
            this.FaceDetector.Click += new System.EventHandler(this.FaceDetector_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(278, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bahria University,Islamabad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Font = new System.Drawing.Font("Lucida Calligraphy", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(347, 36);
            this.label2.TabIndex = 3;
            this.label2.Text = "Please Select an Option";
            // 
            // StartUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(420, 347);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FaceDetector);
            this.Controls.Add(this.ObjectDetector);
            this.Name = "StartUp";
            this.Text = "Welcome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ObjectDetector;
        private System.Windows.Forms.Button FaceDetector;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}