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
    public partial class Hello : Form
    {
        public Hello()
        {
            InitializeComponent();
        }

        private void btnSayHello_Click(object sender, EventArgs e)
        {
            string ChName = txtChName.Text;
            string EnName = txtEnName.Text;
            string Gender = txtGender.Text;
            string Constellation = txtConstellation.Text;
            MessageBox.Show("Hello,我是 " + ChName + " ,\n" + "英文名字是 " + EnName + " ,\n" + "性別是 " + Gender + " ,\n" + "星座是 " + Constellation + " ,\n" + "高興認識你!");
        }

        private void btnSayHi_Click(object sender, EventArgs e)
        {
            string ChName = txtChName.Text;
            string EnName = txtEnName.Text;
            string Gender = txtGender.Text;
            string Constellation = txtConstellation.Text;
            MessageBox.Show("Hi,我是 " + ChName + " ,\n" + "英文名字是 " + EnName + " ,\n" + "性別是 " + Gender + " ,\n" + "星座是 " + Constellation + " ,\n" + "高興認識你!");
        }
    }
}
