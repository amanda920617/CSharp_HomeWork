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
    public partial class LoanReport : Form
    {
        public LoanReport()
        {
            InitializeComponent();
        }

        public bool Report()
        {
            txtLoanAmount.Text = LoanValue.LoanAmount.ToString();
            txtAnnualInterestRate.Text = LoanValue.AnnualInterestRate.ToString();
            txtLoanPeriod.Text = LoanValue.LoanPeriod.ToString();
            txtFullInterest.Text = LoanValue.FullInterest.ToString();
            txtAllAmount.Text = (LoanValue.LoanAmount + LoanValue.FullInterest).ToString();
            if(LoanValue.FullInterest == 0)
            {
                MessageBox.Show("請先點擊 計算 再輸出報表","警告",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
            else
                return true; 
        }
    }
}
