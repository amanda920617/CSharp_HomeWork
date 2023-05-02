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
    public partial class Painter : Form
    {
        public Painter()
        {
            InitializeComponent();
        }
        float px = 0;
        int x = 0;
        int y = 0;
        Pen pen = new Pen(Color.Black, 0);

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left || e.Button == MouseButtons.Right || e.Button == MouseButtons.Middle)
            {
                Graphics graphics = Graphics.FromImage(pictureBox1.Image);
                graphics.DrawLine(pen, x, y, e.X, e.Y);
                x = e.X;
                y = e.Y;
                pictureBox1.Refresh();
            }
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            DialogResult = colorDialog.ShowDialog();
            if(DialogResult == DialogResult.OK)
                pen.Color = colorDialog.Color;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            px = trackBar1.Value;
            labColorWidth.Text = px.ToString();
            pen.Width = px;
        }

        private void Painter_Load(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void Clear()
        {
            pictureBox1.Image = new Bitmap(800, 450);
            Graphics graphics = Graphics.FromImage(pictureBox1.Image);
            graphics.Clear(Color.White);
        }
    }
}
