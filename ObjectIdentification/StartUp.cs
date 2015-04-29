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
    public partial class StartUp : Form
    {
        public StartUp()
        {
            InitializeComponent();
        }

        private void FaceDetector_Click(object sender, EventArgs e)
        {
            this.Hide();
            var FormLoad = new Face_Detection();     //Face Detection Load
            FormLoad.Show();
        }

        private void ObjectDetector_Click(object sender, EventArgs e)
        {
            this.Hide();
            var FormLoad = new Form_ObjIdentifier();     //Object Identifier Load
            FormLoad.Show();
        }
    }
}
