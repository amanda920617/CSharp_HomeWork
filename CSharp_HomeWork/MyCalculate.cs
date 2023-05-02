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
            if (txtNum1.Text == "" || txtNum2.Text == "")
            {
                MessageBox.Show("請輸入數值！");
                return false;
            }
            else 
                return true;
        }
        private decimal GetNumber(int now)
        {
            Number Num = new Number();
            if (now == 1)
            {
                Num.num1 = decimal.Parse(txtNum1.Text);
                return Num.num1;
            }
            else
            {
                Num.num2 = decimal.Parse(txtNum2.Text);
                return Num.num2;
            }
        }
        private void btnAddition_Click(object sender, EventArgs e)
        {
            if (CheckNumber() == false)
                return;
            num1 = GetNumber(1);
            num2 = GetNumber(2);
            Ans = num1 + num2;
            Ans = decimal.Round(Ans, 4);
            txtAnswer.Text = Ans.ToString();
        }

        private void btnSaubraction_Click(object sender, EventArgs e)
        {
            if (CheckNumber() == false)
                return;
            num1 = GetNumber(1);
            num2 = GetNumber(2);
            Ans = num1 - num2;
            Ans = decimal.Round(Ans, 4);
            txtAnswer.Text = Ans.ToString();
        }

        private void btnMultipication_Click(object sender, EventArgs e)
        {
            if (CheckNumber() == false)
                return;
            num1 = GetNumber(1);
            num2 = GetNumber(2);
            Ans = num1 * num2;
            Ans = decimal.Round(Ans, 4);
            txtAnswer.Text = Ans.ToString();
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            if (CheckNumber() == false)
                return;
            num1 = GetNumber(1);
            num2 = GetNumber(2);
            Ans = num1 / num2;
            Ans = decimal.Round(Ans, 4);
            txtAnswer.Text = Ans.ToString();
        }
    }
        public partial class Number
    {
        public decimal num1;
        public decimal num2;
    }
}
