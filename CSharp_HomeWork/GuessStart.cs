using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_HomeWork
{
    public partial class GuessStart : Form
    {
        //public delegate void MyInvoke();
        public GuessStart()
        {
            InitializeComponent();
        }
        GuessNumber guessNum = new GuessNumber();
        Guess guess = new Guess();

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (!(int.TryParse(txtEnterNumber.Text, out GuessNumber.Num)))
                MessageBox.Show($"錯誤！請輸入{GuessNumber.Min}~{GuessNumber.Max}之間的數字", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (guessNum.LargeSmall())
                {
                    guessNum.ChangeRange();
                    Guess thisguess = (Guess)this.Owner;
                    thisguess.ChangeTital();
                }
            }
            txtEnterNumber.Focus();
            txtEnterNumber.Select(0, txtEnterNumber.Text.Length);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            GuessNumber.Min = 0;
            GuessNumber.Max = 100;
            GuessNumber.labResult = "數字炸彈";

            Guess bingoguess = (Guess)this.Owner;
            bingoguess.ChangeTital();
            bingoguess.RandomNumber();

            DialogResult = DialogResult.Cancel;
        }

        private void GuessStart_FormClosing(object sender, FormClosingEventArgs e)
        {
            btnCancel.PerformClick();
        }
    }
}

