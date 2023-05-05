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
            try
            {
                pictureBox1.Image = Image.FromFile($@"C:\MSIT_150\CSharp_HomeWork\Picture_Viewer\Image\{name}");
            }
            catch (Exception e)
            {
                MessageBox.Show($"例外狀況發生啦！\n照片路徑為:{e.Message}\n\n因本作業檔案下載到電腦的位置不同，故照片無法正確顯示，請自行重新修改並確認路徑正確後，再次執行，謝謝您的配合！");
            }
        }
    }
}
