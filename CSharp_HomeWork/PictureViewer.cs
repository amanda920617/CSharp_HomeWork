using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Picture_Viewer;

namespace CSharp_HomeWork
{
    public partial class PictureViewer : Form
    {
        public PictureViewer()
        {
            InitializeComponent();
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            string name = "";
            name = Path.GetFileName(pictureBox.Tag.ToString());
            //MessageBox.Show(name);
            ShowPicture showPicture = new ShowPicture();
            showPicture.ChangePicture(name);
            showPicture.Show();
        }
    }
}
