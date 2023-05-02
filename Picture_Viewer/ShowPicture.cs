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
using Picture_Viewer.Properties;

namespace Picture_Viewer
{
    public partial class ShowPicture : Form
    {
        public ShowPicture()
        {
            InitializeComponent();
        }
        public void ChangePicture(string name)
        {
            pictureBox1.Image = Image.FromFile($"C:\\MSIT_150\\CSharp作業\\CSharp_HomeWork\\Picture_Viewer\\Image\\{name}");
        }
    }
}
