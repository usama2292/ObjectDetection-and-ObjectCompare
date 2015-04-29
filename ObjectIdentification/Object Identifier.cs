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

namespace ObjectIdentification
{
    public partial class Form_ObjIdentifier : Form
    {
        public Form_ObjIdentifier()
        {
            InitializeComponent();
        }

        private void buttonUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog uploadPic = new OpenFileDialog();
            if(uploadPic.ShowDialog()==DialogResult.OK)
            {
                pictureBox1.ImageLocation = uploadPic.FileName;
            }

        }

        private void picButton_clockwise_Click(object sender, EventArgs e)
        {
            Image img = pictureBox1.Image;
            img.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pictureBox1.Image = img;
        }

        private void picButton_anticlockwise_Click(object sender, EventArgs e)
        {
            Image img = pictureBox1.Image;
            img.RotateFlip(RotateFlipType.Rotate270FlipNone);
            pictureBox1.Image = img;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var FormLoad = new StartUp();
            FormLoad.Show();
        }

    }
}
