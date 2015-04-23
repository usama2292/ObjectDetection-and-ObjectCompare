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
    public partial class Form2 : Form
    {
        public Form2()
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



    }
}
