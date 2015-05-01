using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.Util;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using Emgu.CV.UI;


namespace ObjectIdentification
{
    public partial class Face_Detection : Form
    {
        Image<Bgr, Byte> originalImage;
        Image<Gray, Byte> grayImage;
        Image<Bgr, Byte> blankImage;

        HaarCascade faceDetect;
        HaarCascade eyeDetect;



        public Face_Detection()
        {
            InitializeComponent();
        }

        private void IC_UploadImg1_Click(object sender, EventArgs e)
        {
            OpenFileDialog uploadPic = new OpenFileDialog();
            if (uploadPic.ShowDialog() == DialogResult.OK)
            {
                inputImage.ImageLocation = uploadPic.FileName;
                originalImage = new Image<Bgr, byte>(uploadPic.FileName);
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
            originalImage=originalImage.Rotate(90, new Bgr(Color.Black));
            inputImage.Image = originalImage;
        }

        private void IC_anticlockwise_img1_Click(object sender, EventArgs e)
        {
            originalImage = originalImage.Rotate(-90, new Bgr(Color.Black));
            inputImage.Image = originalImage;
        }

        private void IC_buttonDetect_Click(object sender, EventArgs e)
        {
            grayImage = originalImage.Convert<Gray, Byte>();
            outputImage.Image = blankImage;
            faceDetect = new HaarCascade(@"C:\Emgu\emgucv-windows-universal-cuda 2.4.10.1940\opencv\data\haarcascades\haarcascade_frontalface_default.xml");
            eyeDetect = new HaarCascade(@"C:\Emgu\emgucv-windows-universal-cuda 2.4.10.1940\opencv\data\haarcascades\haarcascade_eye.xml");

            Application.DoEvents();

            MCvAvgComp[] faceArr = faceDetect.Detect(grayImage, 1.4, 5, HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, Size.Empty, Size.Empty);
            MCvAvgComp[] eyeArr = eyeDetect.Detect(grayImage, 1.4,15, HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, Size.Empty, Size.Empty);

            foreach (MCvAvgComp detection in faceArr)
            {
                originalImage.Draw(detection.rect, new Bgr(Color.Red), 2);
            }

            foreach (MCvAvgComp detection in eyeArr)
            {
                originalImage.Draw(detection.rect, new Bgr(Color.Blue), 2);
            }

            outputImage.Image = originalImage;
        }


    }
}
