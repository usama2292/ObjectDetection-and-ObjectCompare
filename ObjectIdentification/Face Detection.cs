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
        Image<Bgr, Byte> arrayImage;
        Image<Gray, Byte> grayImage;
        Image<Bgr, Byte> blankImage;

        CascadeClassifier faceDetect;
        CascadeClassifier eyeDetect;

        Rectangle[] faceArr;

        int imageChanger;




        public Face_Detection()
        {
            InitializeComponent();
            imageChanger = 0;
        }

        private void IC_UploadImg1_Click(object sender, EventArgs e)
        {
            OpenFileDialog uploadPic = new OpenFileDialog();
            if (uploadPic.ShowDialog() == DialogResult.OK)
            {
                inputImage.ImageLocation = uploadPic.FileName;
                originalImage = new Image<Bgr, byte>(uploadPic.FileName);
                arrayImage = new Image<Bgr, byte>(uploadPic.FileName);
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
            blankImage = null;
            grayImage = originalImage.Convert<Gray, Byte>();
            outputImage.Image = blankImage;
            faceDetect = new CascadeClassifier(@"C:\Emgu\emgucv-windows-universal-cuda 2.4.10.1940\opencv\data\haarcascades\haarcascade_frontalface_default.xml");
            eyeDetect = new CascadeClassifier(@"C:\Emgu\emgucv-windows-universal-cuda 2.4.10.1940\opencv\data\haarcascades\haarcascade_eye.xml");

            Application.DoEvents();
            faceArr = faceDetect.DetectMultiScale(grayImage, 1.4, 8, Size.Empty, Size.Empty);
            //Rectangle[] eyeArr = faceDetect.DetectMultiScale(grayImage, 1.1, 5, Size.Empty, Size.Empty);

          
        //    blankImage = new Image<Bgr,byte>(originalImage.Bitmap.Clone(faceArr[0], System.Drawing.Imaging.PixelFormat.DontCare));
            testfaceIMG.Image=originalImage.Bitmap.Clone(faceArr[0], System.Drawing.Imaging.PixelFormat.DontCare);


            foreach (Rectangle detection in faceArr)
            {
                originalImage.Draw(detection, new Bgr(Color.Red), 2);

            }

            //foreach (Rectangle detection in eyeArr)
            //{
            //    originalImage.Draw(detection, new Bgr(Color.Blue), 2);
            //}

            outputImage.Image = originalImage;
        }

        private void detectFaceRight_Click(object sender, EventArgs e)
        {
            imageChanger++;
            imageChanger = (imageChanger % faceArr.Length);
            testfaceIMG.Image = arrayImage.Bitmap.Clone(faceArr[imageChanger], System.Drawing.Imaging.PixelFormat.DontCare);
           // arrayImage.InPaint(grayImage, 20);

        }

        private void detectFaceLeft_Click(object sender, EventArgs e)
        {
            imageChanger--;
            if(imageChanger==-1)
            {
                imageChanger = (faceArr.Length - 1);
            }
            testfaceIMG.Image = arrayImage.Bitmap.Clone(faceArr[imageChanger], System.Drawing.Imaging.PixelFormat.DontCare);
        }


    }
}
