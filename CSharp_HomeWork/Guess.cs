using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CSharp_HomeWork.GuessStart;

namespace CSharp_HomeWork
{
    public partial class Guess : Form
    {
        public Guess()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            RandomNumber();
            GuessStart startGuess = new GuessStart();
            startGuess.Owner = this;
            startGuess.ShowDialog();
        }

        private void btnShowAnswer_Click(object sender, EventArgs e)
        {
            MessageBox.Show(GuessNumber.Answer.ToString());
        }

        public void RandomNumber()
        {
            Random random = new Random(DateTime.Now.Millisecond);
            GuessNumber.Answer = random.Next() % 100;
        }

        private void Guess_Load(object sender, EventArgs e)
        {
            RandomNumber();
        }

        public void ChangeTital()
        {
            this.labShowNumber.Text = GuessNumber.labResult;
            labShowNumber.Refresh();
        }
    }
}
