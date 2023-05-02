using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace CSharp_HomeWork
{
    public partial class XOGame : Form
    {
        public XOGame()
        {
            InitializeComponent();
        }
        string str = "O";
        public void WriteOX(object sender)
        {
            System.Windows.Forms.Button btn = (System.Windows.Forms.Button)sender;
            btn.Text = str;
            btn.Enabled = false;
            btn.BackColor = Color.Transparent;
        }
        public string CheckCh(string str)
        {
            if (str == "O")
                return "X";
            else
                return "O";
        }
        public int Count()
        {
            int count = 0;
            object[] btn = { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9 };
            for(int i = 0; i < 9; i ++)
            {
                if(((System.Windows.Forms.Button)btn[i]).Text != "")
                    count++;
            }
            return count;
        }
        public bool WinLose(int count)
        {
            if(count < 3) return false;
            if((btn1.Text == btn2.Text && btn2.Text == btn3.Text && btn1.Text != "") || 
                (btn1.Text == btn4.Text && btn4.Text == btn7.Text && btn1.Text != ""))
            {
                ShowWiner(btn1.Text);
                return true;
            }
            else if((btn4.Text == btn5.Text && btn5.Text == btn6.Text && btn5.Text != "") ||
                        (btn2.Text == btn5.Text && btn5.Text == btn8.Text && btn5.Text != "") ||
                        (btn1.Text == btn5.Text && btn5.Text == btn9.Text && btn5.Text != "") ||
                        (btn3.Text == btn5.Text && btn5.Text == btn7.Text && btn5.Text != ""))
            {
                ShowWiner(btn5.Text);
                return true;
            }
            else if((btn7.Text == btn8.Text && btn8.Text == btn9.Text && btn9.Text != "") ||
                        (btn3.Text == btn6.Text && btn6.Text == btn9.Text && btn9.Text != ""))
            {
                ShowWiner(btn9.Text);
                return true;
            }
            else if(count == 9)
            {
                MessageBox.Show("平局！按下確定重新開始", "完局！");
                return true;
            }
            else
                return false;
        }

        public void ShowWiner(string str)
        {
            if (str == "X")
                MessageBox.Show("X手獲勝！", "完局！");
            else
                MessageBox.Show("O手獲勝！", "完局！");
        }

        private void btn_Click(object sender, EventArgs e)
        {
            str = CheckCh(str);
            WriteOX(sender);
            if (WinLose(Count()) == true)
                btnReset.PerformClick();
        }

        private void Clear()
        {
            object[] btn = { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9 };
            for (int i = 0; i < btn.Length; i++)
            {
                ((System.Windows.Forms.Button)btn[i]).Text = "";
                ((System.Windows.Forms.Button)btn[i]).Enabled = true;
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            str = "O";
            Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void XOGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.R)
                btnReset.PerformClick();
            if (e.KeyData == Keys.Escape)
                btnExit.PerformClick();
        }
    }
}