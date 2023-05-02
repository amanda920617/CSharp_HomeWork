using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_HomeWork
{
    public partial class StartGuess : Form
    {
        public StartGuess()
        {
            InitializeComponent();
        }
        GuessNumber guessNum = new GuessNumber();
        Guess guess = new Guess();
        private void btnEnter_Click(object sender, EventArgs e)
        {
            //todo 確認輸入框內容(1-100)跳警告
            GuessNumber.Num = int.Parse(txtEnterNumber.Text);
            if(guessNum.LargeSmall())
            {
                Console.WriteLine($"Num={GuessNumber.Num}\n");
                if (guessNum.ChangeRange())
                {
                    //todo Bingo 關閉表單 變成重新開始
                    guess.NewGame();
                    guess.labShowNumber.Update();
                    btnCancel.PerformClick();
                    //DialogResult = DialogResult.Cancel;
                    return;
                }
                else
                {
                    guess.ChangeTital();
                    Console.WriteLine($"UpDate\n");
                    //DialogResult = DialogResult.Retry;
                }
                //Console.WriteLine($"DialogResult={DialogResult}\n");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
