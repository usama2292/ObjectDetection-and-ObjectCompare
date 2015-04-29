using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectIdentification
{
    public partial class Face_Detection : Form
    {
        public Face_Detection()
        {
            InitializeComponent();
        }

        private void IC_UploadImg1_Click(object sender, EventArgs e)
        {
            OpenFileDialog uploadPic = new OpenFileDialog();
            if (uploadPic.ShowDialog() == DialogResult.OK)
            {
                IC_image1.ImageLocation = uploadPic.FileName;
            }
        }

        private void IC_UploadImg2_Click(object sender, EventArgs e)
        {
            OpenFileDialog uploadPic = new OpenFileDialog();
            if (uploadPic.ShowDialog() == DialogResult.OK)
            {
                IC_image2.ImageLocation = uploadPic.FileName;
            }
        }

        private void FaceHome_Click_1(object sender, EventArgs e)
        {

            this.Hide();
            var FormLoad = new StartUp();
            FormLoad.Show();
        }

        private void IC_clockwise_img1_Click(object sender, EventArgs e)
        {
            Image img = IC_image1.Image;
            img.RotateFlip(RotateFlipType.Rotate90FlipNone);
            IC_image1.Image = img;
        }

        private void IC_anticlockwise_img1_Click(object sender, EventArgs e)
        {
            Image img = IC_image1.Image;
            img.RotateFlip(RotateFlipType.Rotate270FlipNone);
            IC_image1.Image = img;
        }


    }
}
