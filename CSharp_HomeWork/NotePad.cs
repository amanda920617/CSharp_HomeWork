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

namespace CSharp_HomeWork
{
    public partial class NotePad : Form
    {
        public NotePad()
        {
            InitializeComponent();
            Rtxt.LanguageOption = RichTextBoxLanguageOptions.UIFonts;
        }
        string name = string.Empty;
        private void 新增Add_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            Rtxt.Text = string.Empty;
            name = openFileDialog1.FileName;
        }

        private void 開啟Open_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Rtxt.Text = File.ReadAllText(openFileDialog1.FileName);
                name = openFileDialog1.FileName;
            }
        }

        private void 儲存Save_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.FileName == "" && Rtxt.Text != "")
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog1.FileName, Rtxt.Text);
                    name = saveFileDialog1.FileName;
                }
                else
                    name = openFileDialog1.FileName;
            }
            else
            {
                File.WriteAllText(openFileDialog1.FileName, Rtxt.Text);
                name = openFileDialog1.FileName;

            }
        }

        private void 另存新檔OtherSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, Rtxt.Text);
                name = saveFileDialog1.FileName;
            }
        }

        private void 列印Print_Click(object sender, EventArgs e)
        {
            printDocument1.DocumentName = Path.GetFileName(name);
            printDialog1.Document = printDocument1;
            printDialog1.ShowDialog();
            /*我沒做這功能啦\n因為測試不了QAQ");*/
        }

        private void 預覽列印View_Click(object sender, EventArgs e)
        {
            printDocument1.DocumentName = Path.GetFileName(name);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
            /*我沒做這功能啦\n因為測試不了QAQ");*/
        }

        private void 復原Undo_Click(object sender, EventArgs e)
        {
            Rtxt.Undo();
        }

        private void 取消復原Redo_Click(object sender, EventArgs e)
        {
            Rtxt.Redo();
        }
        private void 剪下Cut_Click(object sender, EventArgs e)
        {
            Rtxt.Cut();
        }

        private void 複製Copy_Click(object sender, EventArgs e)
        {
            Rtxt.Copy();
        }

        private void 貼上Paste_Click(object sender, EventArgs e)
        {
            Rtxt.Paste();
        }
        private void 全選All_Click(object sender, EventArgs e)
        {
            Rtxt.SelectAll();
        }
        private void 顏色Color_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            DialogResult = colorDialog.ShowDialog();
            if (DialogResult == DialogResult.OK)
                Rtxt.ForeColor = colorDialog.Color;
        }

        private void 字型Font_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.Font = Rtxt.Font;
            DialogResult = fontDialog.ShowDialog();
            if (DialogResult == DialogResult.OK)
                Rtxt.Font = fontDialog.Font;
        }

        private void toUpper_Click(object sender, EventArgs e)
        {
            Rtxt.Text = Rtxt.Text.ToUpper();
        }

        private void toLower_Click(object sender, EventArgs e)
        {
            Rtxt.Text = Rtxt.Text.ToLower();
        }

        private void 自動換行Enter_Click(object sender, EventArgs e)
        {
            if(自動換行.Checked == true)
            {
                自動換行.Checked = false;
                Rtxt.WordWrap = false;
            }
            else
            {
                自動換行.Checked = true;
                Rtxt.WordWrap = true;
            }
        }

        private void 紅色R_Click(object sender, EventArgs e)
        {
            Rtxt.ForeColor = Color.Red;
        }

        private void 綠色G_Click(object sender, EventArgs e)
        {
            Rtxt.ForeColor = Color.Green;
        }

        private void 藍色Bu_Click(object sender, EventArgs e)
        {
            Rtxt.ForeColor = Color.Blue;
        }

        private void 黑色Bk_Click(object sender, EventArgs e)
        {
            Rtxt.ForeColor = Color.Black;
        }

        private void 關於About_Click(object sender, EventArgs e)
        {
            MessageBox.Show("此記事本為資策會C#課程作業，由 林佳誼 製作。\n謝謝您的使用！","關於");
        }

        private void NotePad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.N && e.Control)
                新增N.PerformClick();
            if (e.KeyCode == Keys.O && e.Control)
                開啟O.PerformClick();
            if (e.KeyCode == Keys.S && e.Control)
                儲存S.PerformClick();
            if (e.KeyCode == Keys.P && e.Control)
                列印P.PerformClick();

            if (e.KeyCode == Keys.Z && e.Control)
                復原U.PerformClick();
            if (e.KeyCode == Keys.Y && e.Control)
                取消復原R.PerformClick();
            if (e.KeyCode == Keys.X && e.Control)
                剪下T.PerformClick();
            if (e.KeyCode == Keys.C && e.Control)
                複製C.PerformClick();
            if (e.KeyCode == Keys.V && e.Control)
                貼上P.PerformClick();
            if (e.KeyCode == Keys.A && e.Control)
                全選A.PerformClick();
        }

        private void 結束X_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
