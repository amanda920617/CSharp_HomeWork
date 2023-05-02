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
    public partial class Loan : Form
    {
        public Loan()
        {
            InitializeComponent();
        }

        private void btnCalaulate_Click(object sender, EventArgs e)
        {
            if (!(int.TryParse(txtLoanAmount.Text, out LoanValue.LoanAmount)))
            {
                MessageBox.Show("貸款金額 請輸入整數");
                txtLoanAmount.Clear();
                txtLoanAmount.Focus();
            }
            else if (!(int.TryParse(txtAnnualInterestRate.Text, out LoanValue.AnnualInterestRate)))
            {
                MessageBox.Show("年利率 請輸入整數");
                txtAnnualInterestRate.Clear();
                txtAnnualInterestRate.Focus();
            }
            else if (!(int.TryParse(txtLoanPeriod.Text, out LoanValue.LoanPeriod)))
            {
                MessageBox.Show("貸款期數 請輸入整數");
                txtLoanPeriod.Clear();
                txtLoanPeriod.Focus();
            }
            else
            {
                txtLoanAmount.Enabled = false;
                txtAnnualInterestRate.Enabled = false;
                txtLoanPeriod.Enabled = false;
                btnCalaulate.Enabled = false;
                btnClear.Enabled = true;

                Array.Resize(ref LoanValue.text, LoanValue.LoanPeriod);

                LoanValue.MonthlyInterestRate = (LoanValue.AnnualInterestRate * 0.01) / 12;
                LoanValue.RepayThePrincipal = (int)(Math.Ceiling(LoanValue.LoanAmount * 1.0 / LoanValue.LoanPeriod));

                LoanValue.FullInterest = 0;
                int loanamount = LoanValue.LoanAmount;
                for (int i = 0; i < LoanValue.LoanPeriod; i++)
                {
                    LoanValue.RepayInterest = Convert.ToInt32(loanamount * LoanValue.MonthlyInterestRate);
                    LoanValue.FullInterest += LoanValue.RepayInterest;
                    loanamount -= LoanValue.RepayThePrincipal;

                    //Console.WriteLine($"RT = {LoanValue.RepayThePrincipal} ,RI = {LoanValue.RepayInterest}");
                    LoanValue.text[i] = LoanValue.RepayInterest.ToString();
                    //Console.WriteLine($"text[{i}] = {LoanValue.RepayInterest}");
                }
                txtFullInterest.Text = LoanValue.FullInterest.ToString();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            btnCalaulate.Enabled = true;
            btnClear.Enabled = false;
            LoanValue.FullInterest = 0;
            txtFullInterest.Text = "";
            txtLoanAmount.Enabled = true;
            txtAnnualInterestRate.Enabled = true;
            txtLoanPeriod.Enabled = true;
        }
        
        private void btnReport_Click(object sender, EventArgs e)
        {
            LoanReport loanReport = new LoanReport();
            if (loanReport.Report())
                loanReport.Show();
        }
        
        private void btnStatistics_Click(object sender, EventArgs e)
        {
            LoanStatistics loanStatistics = new LoanStatistics();
            if (loanStatistics.Statistics())
                loanStatistics.Show();
        }
    }
}
