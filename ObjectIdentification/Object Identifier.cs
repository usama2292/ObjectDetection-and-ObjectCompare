using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using Emgu.CV;
using Emgu.Util;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using Emgu.CV.UI;

namespace ObjectIdentification
{
    public partial class Form_ObjIdentifier : Form
    {
        Image <Bgr,Byte>img;
        public Form_ObjIdentifier()
        {
            InitializeComponent();
        }

        private void buttonUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog uploadPic = new OpenFileDialog();
            if(uploadPic.ShowDialog()==DialogResult.OK)
            {
                OI_inputImage.ImageLocation = uploadPic.FileName;
                img = new Image<Bgr, byte>(uploadPic.FileName);
            }

        }

        private void picButton_clockwise_Click(object sender, EventArgs e)
        {
            img = img.Rotate(90, new Bgr(Color.Black));
            OI_inputImage.Image = img;
        }

        private void picButton_anticlockwise_Click(object sender, EventArgs e)
        {
            img = img.Rotate(-90, new Bgr(Color.Black));
            OI_inputImage.Image = img;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var FormLoad = new StartUp();
            FormLoad.Show();
        }

    }
}
