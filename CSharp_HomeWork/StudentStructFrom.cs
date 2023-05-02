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
    public partial class StudentStructFrom : Form
    {
        public StudentStructFrom()
        {
            InitializeComponent();
        }
        Student student;

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
                MessageBox.Show("請輸入姓名", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (txtChScore.Text == "" || !(int.TryParse(txtChScore.Text, out student.ChScore)))
                MessageBox.Show("請輸入國文成績", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (txtEnScore.Text == "" || !(int.TryParse(txtEnScore.Text, out student.EnScore)))
                MessageBox.Show("請輸入英文成績", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (txtMathScore.Text == "" || !(int.TryParse(txtMathScore.Text, out student.MathScore)))
                MessageBox.Show("請輸入數學成績", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                student.Name = txtName.Text;
                //studentScores.Save(txtName.Text, int.Parse(txtChScore.Text), int.Parse(txtEnScore.Text), int.Parse(txtMathScore.Text));
                labShowScore.Text = "姓名：" + student.Name + "\n" + "國文：" + student.ChScore + "\n" + "英文：" + student.EnScore + "\n" + "數學：" + student.MathScore;
            }
        }

        private void btnHighestLowestSubject_Click(object sender, EventArgs e)
        {
            if (labShowScore.Text == "")
                MessageBox.Show("請先儲存成績！");
            else
            {
                string HighestSubject, LowestSubject;
                int HighestScore, LowestScore;
                HighestScore = CompareScore(0, student.ChScore, student.EnScore, student.MathScore);
                LowestScore = CompareScore(1, student.ChScore, student.EnScore, student.MathScore);
                HighestSubject = SubjectCheck(HighestScore);
                LowestSubject = SubjectCheck(LowestScore);
                labHighestLowestSubject.Text = "最高分科目為：" + HighestSubject + HighestScore.ToString() + "分\n" + "最低分科目為：" + LowestSubject + LowestScore.ToString() + "分";
            }
        }
 
        public int CompareScore(int HighLow, int Ch, int En, int Math)
        {
            int Max = Ch;
            int Min = Ch;
            if (HighLow == 0)
            {
                if (En >= Max)
                    Max = En;
                if (Math >= Max)
                    Max = Math;
                return Max;
            }
            else
            {
                if (En <= Min)
                    Min = En;
                if (Math <= Min)
                    Min = Math;
                return Min;
            }
        }
        public string SubjectCheck(int score)
        {
            string subject = "";
            Console.WriteLine($"score = {score}\n");

            if (score == student.ChScore)
                subject += "Chinese/";
            if (score == student.EnScore)
                subject += "English/";
            if (score == student.MathScore)
                subject += "Math/";
            Console.WriteLine($"subject = {subject}\n");
            return subject;
        }
    }
}
