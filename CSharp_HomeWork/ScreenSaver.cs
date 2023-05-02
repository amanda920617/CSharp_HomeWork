using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_HomeWork
{
    public partial class ScreenSaver : Form
    {
        public ScreenSaver()
        {
            InitializeComponent();
        }

        public bool L = true;
        public bool T= true;
        public const int change = 10;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(pictureBox1.Left + pictureBox1.Width + change > this.Width)
                L = false;
            if(pictureBox1.Left - change < 0)
                L = true;
            if (pictureBox1.Top + pictureBox1.Height + change > this.Height)
                T = false;
            if (pictureBox1.Top - change < 0)
                T = true;

            if (L)
                pictureBox1.Left += change;
            else
                pictureBox1.Left -= change;
            if (T)
                pictureBox1.Top += change;
            else
                pictureBox1.Top -= change;
        }

        private void ScreenSaver_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }
    }
}
