using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CSharp_HomeWork
{
    public partial class LoanValue
    {
        public static int LoanAmount, AnnualInterestRate, LoanPeriod;
        public static int RepayThePrincipal, RepayInterest, FullInterest = 0;
        public static double MonthlyInterestRate;
        public static string[] text = new string[10];
    }
    public partial struct Student
    {
        public string Name;
        public int ChScore;
        public int EnScore;
        public int MathScore;
    }
    public partial struct StudentOtherGrade
    {
        public int Sum;
        public decimal Average;
        public string Highest;
        public string Lowest;
    }
    public partial class GuessNumber
    {
        public static int Min = 0, Max = 100;
        public static int Num;
        public static string labResult;
        public static int Answer;

        public bool ChangeRange()
        {
            Result();
            if (labResult != "Bingo")
                return false;
            else
                return true;
        }
        public void Result()
        {
            if (Num == Answer)
            {
                MessageBox.Show("恭喜你猜對了！炸彈數字是 " + Answer);
                labResult = "Bingo";
            }
            else if (Num > Answer)
            {
                Max = Num;
                labResult = "太大了\n";
                labResult += "炸彈介於" + Min + "~" + Max;
            }
            else
            {
                Min = Num;
                labResult = "太小了\n";
                labResult += "炸彈介於" + Min + "~" + Max;
            }
        }
        public bool LargeSmall()
        {
            if (Num > Max || Num < Min)
            {
                MessageBox.Show($"錯誤！請輸入{Min}~{Max}之間的數字", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
                return true;
        }
    }
}