using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CSharp_HomeWork
{
    public partial class StudentGrade : Form
    {
        public StudentGrade()
        {
            InitializeComponent();
        }

        public static int RName = 1;
        decimal ChAverage, EnAverage, MathAverage;
        string result = string.Empty;

        int ChSum = 0, EnSum = 0, MathSum = 0;
        int ChMax = 0, ChMin = 100;
        int EnMax = 0, EnMin = 100;
        int MathMax = 0, MathMin = 100;

        Student student;
        StudentOtherGrade studentOtherGrade;
        List<Student> StudentList = new List<Student>();
        List<StudentOtherGrade> StudentOtherGradeList = new List<StudentOtherGrade>();


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtName.Text.Length > 4)
                MessageBox.Show("請輸入姓名(4字以內)", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (txtChScore.Text == "" || !(int.TryParse(txtChScore.Text, out student.ChScore)))
                MessageBox.Show("請輸入國文成績", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (txtEnScore.Text == "" || !(int.TryParse(txtEnScore.Text, out student.EnScore)))
                MessageBox.Show("請輸入英文成績", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (txtMathScore.Text == "" || !(int.TryParse(txtMathScore.Text, out student.MathScore)))
                MessageBox.Show("請輸入數學成績", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if(student.ChScore > 100 || student.ChScore < 0)
                    MessageBox.Show("請輸入正確的國文成績(0~100)", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (student.EnScore > 100 || student.EnScore < 0)
                    MessageBox.Show("請輸入正確的英文成績(0~100)", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (student.MathScore > 100 || student.MathScore < 0)
                    MessageBox.Show("請輸入正確的數學成績(0~100)", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    btnStatistics.Enabled = true;
                    btnRemove.Enabled = true;

                    student.Name = txtName.Text;

                    Compare(student.ChScore, student.EnScore, student.MathScore);
                    HighLow(student.ChScore, student.EnScore, student.MathScore);
                    studentOtherGrade.Sum = student.ChScore + student.EnScore + student.MathScore;
                    studentOtherGrade.Average = decimal.Round(Convert.ToDecimal(studentOtherGrade.Sum / 3.0), 1);

                    //result += $"{string.Format("{0,-4}", student.Name)}{string.Format("{0,6}", student.ChScore)}{string.Format("{0,6}", student.EnScore)}{string.Format("{0,6}", student.MathScore)}{string.Format("{0,6}", studentOtherGrade.Sum)}{string.Format("{0,6}", studentOtherGrade.Average)}{string.Format("{0,26}", studentOtherGrade.Lowest)}{string.Format("{0,26}", studentOtherGrade.Highest)}\n";

                    SaveScore();
                }
            }
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            btnStatistics.Enabled = true;
            btnRemove.Enabled = true;
            RandomScore();
            Compare(student.ChScore, student.EnScore, student.MathScore);
            HighLow(student.ChScore, student.EnScore, student.MathScore);

            studentOtherGrade.Sum = student.ChScore + student.EnScore + student.MathScore;
            studentOtherGrade.Average = decimal.Round(Convert.ToDecimal(studentOtherGrade.Sum / 3.0),1);
            //result += $"{string.Format("{0,-4}", RName)}{string.Format("{0,6}", student.ChScore)}{string.Format("{0,6}", student.EnScore)}{string.Format("{0,6}", student.MathScore)}{string.Format("{0,6}", studentOtherGrade.Sum)}{string.Format("{0,6}", studentOtherGrade.Average)}{string.Format("{0,26}", studentOtherGrade.Lowest)}{string.Format("{0,26}", studentOtherGrade.Highest)}\n";
            
            SaveScore();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtName.Text.Length > 4)
                MessageBox.Show("請輸入姓名(4字以內)", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (txtChScore.Text == "" || !(int.TryParse(txtChScore.Text, out student.ChScore)))
                MessageBox.Show("請輸入國文成績", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (txtEnScore.Text == "" || !(int.TryParse(txtEnScore.Text, out student.EnScore)))
                MessageBox.Show("請輸入英文成績", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (txtMathScore.Text == "" || !(int.TryParse(txtMathScore.Text, out student.MathScore)))
                MessageBox.Show("請輸入數學成績", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if (student.ChScore > 100 || student.ChScore < 0)
                    MessageBox.Show("請輸入正確的國文成績(0~100)", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (student.EnScore > 100 || student.EnScore < 0)
                    MessageBox.Show("請輸入正確的英文成績(0~100)", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (student.MathScore > 100 || student.MathScore < 0)
                    MessageBox.Show("請輸入正確的數學成績(0~100)", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    btnStatistics.Enabled = true;
                    btnRemove.Enabled = true;

                    student.Name = txtName.Text;

                    Compare(student.ChScore, student.EnScore, student.MathScore);
                    HighLow(student.ChScore, student.EnScore, student.MathScore);
                    studentOtherGrade.Sum = student.ChScore + student.EnScore + student.MathScore;
                    studentOtherGrade.Average = decimal.Round(Convert.ToDecimal(studentOtherGrade.Sum / 3.0), 1);

                    StudentList.Insert(0, student);
                    StudentOtherGradeList.Insert(0, studentOtherGrade);
                    RName++;
                    ShowScore();
                    //result = $"{string.Format("{0,-4}", student.Name)}{string.Format("{0,6}", student.ChScore)}{string.Format("{0,6}", student.EnScore)}{string.Format("{0,6}", student.MathScore)}{string.Format("{0,6}", studentOtherGrade.Sum)}{string.Format("{0,6}", studentOtherGrade.Average)}{string.Format("{0,26}", studentOtherGrade.Lowest)}{string.Format("{0,26}", studentOtherGrade.Highest)}\n";
                    //result += temp;
                    //SaveScore();
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            StudentList.RemoveAt(0);
            StudentOtherGradeList.RemoveAt(0);
            ShowScore();
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            btnInsert.Enabled = false;
            btnRandom.Enabled = false;
            btnStatistics.Enabled = false;
            btnRemove.Enabled = false;
            btnRandom20.Enabled = false;

            ChAverage = decimal.Round(Convert.ToDecimal(ChSum / RName), 1);
            EnAverage = decimal.Round(Convert.ToDecimal(EnSum / RName), 1);
            MathAverage = decimal.Round(Convert.ToDecimal(MathSum / RName), 1);

            labStatistics.Text = $"{string.Format("{0,-4}", "總分")}{string.Format("{0,4}", ChSum)}{string.Format("{0,6}", EnSum)}{string.Format("{0,6}", MathSum)}\n";
            labStatistics.Text += $"{ string.Format("{0,-4}", "平均")}{ string.Format("{0,4}", ChAverage)}{ string.Format("{0,6}", EnAverage)}{ string.Format("{0,6}", MathAverage)}\n";
            labStatistics.Text += $"{ string.Format("{0,-3}", "最高分")}{ string.Format("{0,4}", ChMax)}{ string.Format("{0,6}", EnMax)}{ string.Format("{0,6}", MathMax)}\n";
            labStatistics.Text += $"{ string.Format("{0,-3}", "最低分")}{ string.Format("{0,4}", ChMin)}{ string.Format("{0,6}", EnMin)}{ string.Format("{0,6}", MathMin)}\n";

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            btnRemove.Enabled = false;
            btnStatistics.Enabled=false;

            if (comboBoxProject.Text != "國文成績" && comboBoxProject.Text != "英文成績" && comboBoxProject.Text != "數學成績")
            {
                MessageBox.Show("錯誤！請重新使用下拉選單選擇項目成績");
                return;
            }

            if (txtStart.Text == "" || !(int.TryParse(txtStart.Text, out int start)))
                MessageBox.Show("請輸入範圍起始值", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (txtEnd.Text == "" || !(int.TryParse(txtEnd.Text, out int end)))
                MessageBox.Show("請輸入範圍結束值", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if (start > 100 || start < 0)
                    MessageBox.Show($"請輸入正確的{comboBoxProject.Text}範圍起始值(0~100)", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (start > 300 || start < 0)
                    MessageBox.Show($"請輸入正確的{comboBoxProject.Text}範圍起始值(0~300)", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (end > 100 || end < 0)
                    MessageBox.Show($"請輸入正確的{comboBoxProject.Text}範圍結束值(0~100)", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (end > 300 || end < 0)
                    MessageBox.Show($"請輸入正確的{comboBoxProject.Text}範圍結束值(0~300)", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
                if(end < start)
                    MessageBox.Show($"請輸入正確的成績範圍(0~300)", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    Search(comboBoxProject.SelectedIndex,start,end);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            btnInsert.Enabled = true;
            btnRandom.Enabled = true;
            btnStatistics.Enabled = false;
            btnRemove.Enabled = false;
            btnRandom20.Enabled = true;

            StudentList.Clear();
            StudentOtherGradeList.Clear();
            ShowScore();
            comboBoxProject.Text = "科目成績";
            txtStart.Text = string.Empty;
            txtEnd.Text = string.Empty;

            labStatistics.Text = string.Empty;
            result = string.Empty;
            RName = 1;

            ChSum = 0;
            EnSum = 0;
            MathSum = 0;

            ChMax = 0;
            ChMin = 100;
            EnMax = 0;
            EnMin = 100;
            MathMax = 0;
            MathMin = 100;
        }

        private void btnRandom20_Click(object sender, EventArgs e)
        {
            btnStatistics.Enabled = true;
            btnRemove.Enabled = true;

            for (int i = 0; i < 20; i++)
            {
                RandomScore();
                Compare(student.ChScore, student.EnScore, student.MathScore);
                HighLow(student.ChScore, student.EnScore, student.MathScore);

                studentOtherGrade.Sum = student.ChScore + student.EnScore + student.MathScore;
                studentOtherGrade.Average = decimal.Round(Convert.ToDecimal(studentOtherGrade.Sum / 3.0), 1);
                //result += $"{string.Format("{0,-4}", RName)}{string.Format("{0,6}", student.ChScore)}{string.Format("{0,6}", student.EnScore)}{string.Format("{0,6}", student.MathScore)}{string.Format("{0,6}", studentOtherGrade.Sum)}{string.Format("{0,6}", studentOtherGrade.Average)}{string.Format("{0,26}", studentOtherGrade.Lowest)}{string.Format("{0,26}", studentOtherGrade.Highest)}\n";
                SaveScore();
            }
        }

        private void btnSearchCancel_Click(object sender, EventArgs e)
        {
            btnRemove.Enabled = true;
            btnStatistics.Enabled = true;
            ShowScore();
        }

        public void HighLow(int Ch, int En, int Math)
        {
            ChSum += Ch;
            EnSum += En;
            MathSum += Math;

            if (Ch > ChMax)
                ChMax = Ch;
            if (Ch < ChMin)
                ChMin = Ch;
            if (En > EnMax)
                EnMax = En;
            if (En < EnMin)
                EnMin = En;
            if (Math > MathMax)
                MathMax = Math;
            if (Math < MathMin)
                MathMin = Math;
        }
        public void SaveScore()
        {
            StudentList.Add(student);
            StudentOtherGradeList.Add(studentOtherGrade);
            ShowScore();
            RName++;
        }
        public void ShowScore()
        {
            result = $"";
            for (int i = 0; i < StudentList.Count; i++)
                result += $"{string.Format("{0,-4}", StudentList[i].Name)}{string.Format("{0,6}", StudentList[i].ChScore)}{string.Format("{0,6}", StudentList[i].EnScore)}{string.Format("{0,6}", StudentList[i].MathScore)}{string.Format("{0,6}", StudentOtherGradeList[i].Sum)}{string.Format("{0,6}", StudentOtherGradeList[i].Average)}{string.Format("{0,26}", StudentOtherGradeList[i].Lowest)}{string.Format("{0,26}", StudentOtherGradeList[i].Highest)}\n";
            labScore.Text = result;
        }
        public void Search(int subject, int start, int end)
        {
            List<Student> TempList = new List<Student>();
            List<StudentOtherGrade> TempOtherGradesList = new List<StudentOtherGrade>();
            List<Student> ResultList = new List<Student>();
            List<StudentOtherGrade> ResultOtherGradesList = new List<StudentOtherGrade>();
            result = "";
            switch (subject)
            {
                case 0:
                    for (int i = 0; i < StudentList.Count; i++)
                    {
                        if (StudentList[i].ChScore >= start)
                        {
                            TempList.Add(StudentList[i]);
                            TempOtherGradesList.Add(StudentOtherGradeList[i]);
                        }
                    }
                    for (int i = 0; i < TempList.Count; i++)
                    {
                        if (TempList[i].ChScore <= end)
                        {
                            ResultList.Add(TempList[i]);
                            ResultOtherGradesList.Add(TempOtherGradesList[i]);
                        }
                    }
                    break;

                case 1:
                    for (int i = 0; i < StudentList.Count; i++)
                    {
                        if (StudentList[i].EnScore >= start)
                        {
                            TempList.Add(StudentList[i]);
                            TempOtherGradesList.Add(StudentOtherGradeList[i]);
                        }
                    }
                    for (int i = 0; i < TempList.Count; i++)
                    {
                        if (TempList[i].EnScore <= end)
                        {
                            ResultList.Add(TempList[i]);
                            ResultOtherGradesList.Add(TempOtherGradesList[i]);
                        }
                    }
                    break;

                case 2:
                    for (int i = 0; i < StudentList.Count; i++)
                    {
                        if (StudentList[i].MathScore >= start)
                        {
                            TempList.Add(StudentList[i]);
                            TempOtherGradesList.Add(StudentOtherGradeList[i]);
                        }
                    }
                    for (int i = 0; i < TempList.Count; i++)
                    {
                        if (TempList[i].MathScore <= end)
                        {
                            ResultList.Add(TempList[i]);
                            ResultOtherGradesList.Add(TempOtherGradesList[i]);
                        }
                    }
                    break;
            }

            result = $"";
            for (int i = 0; i < ResultList.Count; i++)
                result += $"{string.Format("{0,-4}", ResultList[i].Name)}{string.Format("{0,6}", ResultList[i].ChScore)}{string.Format("{0,6}", ResultList[i].EnScore)}{string.Format("{0,6}", ResultList[i].MathScore)}{string.Format("{0,6}", ResultOtherGradesList[i].Sum)}{string.Format("{0,6}", ResultOtherGradesList[i].Average)}{string.Format("{0,26}", ResultOtherGradesList[i].Lowest)}{string.Format("{0,26}", ResultOtherGradesList[i].Highest)}\n";
            labScore.Text = result;
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
        public void RandomScore()
        {
            Random random = new Random(DateTime.Now.Millisecond + StudentGrade.RName);
            student.Name = StudentGrade.RName.ToString();
            student.ChScore = random.Next(0, 100);
            student.EnScore = random.Next(0, 100);
            student.MathScore = random.Next(0, 100);
        }

        string HighestSubject, LowestSubject;
        int HighestScore, LowestScore;

        public void Compare(int Ch, int En, int Math)
        {
            HighestScore = CompareScore(0, Ch, En, Math);
            LowestScore = CompareScore(1, Ch, En, Math);
            HighestSubject = SubjectCheck(HighestScore);
            LowestSubject = SubjectCheck(LowestScore);

            studentOtherGrade.Highest = $"{HighestSubject}{HighestScore}";
            studentOtherGrade.Lowest = $"{LowestSubject}{LowestScore}";
        }
    }
}
