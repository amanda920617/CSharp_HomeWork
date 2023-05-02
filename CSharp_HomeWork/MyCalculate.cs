using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_HomeWork
{
    public partial class MyCalculate : Form
    {
        public MyCalculate()
        {
            InitializeComponent();
        }
        decimal num1;
        decimal num2;
        decimal Ans;
        public bool CheckNumber()
        {
            if (!(decimal.TryParse(txtNum1.Text,out num1)))
            {
                MessageBox.Show("請輸入正確Num1數值！");
                return false;
            }
            else if (!(decimal.TryParse(txtNum2.Text, out num2)))
            {
                MessageBox.Show("請輸入正確Num2數值！");
                return false;
            }
            else 
                return true;
        }
        private void btnAddition_Click(object sender, EventArgs e)
        {
            if (CheckNumber() == false)
                return;
            Ans = num1 + num2;
            Ans = decimal.Round(Ans, 4);
            txtAnswer.Text = Ans.ToString();
        }

        private void btnSaubraction_Click(object sender, EventArgs e)
        {
            if (CheckNumber() == false)
                return;
            Ans = num1 - num2;
            Ans = decimal.Round(Ans, 4);
            txtAnswer.Text = Ans.ToString();
        }

        private void btnMultipication_Click(object sender, EventArgs e)
        {
            if (CheckNumber() == false)
                return;
            Ans = num1 * num2;
            Ans = decimal.Round(Ans, 4);
            txtAnswer.Text = Ans.ToString();
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            if (CheckNumber() == false)
                return;
            Ans = num1 / num2;
            Ans = decimal.Round(Ans, 4);
            txtAnswer.Text = Ans.ToString();
        }
    }
}
