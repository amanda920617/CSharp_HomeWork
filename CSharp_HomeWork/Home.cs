using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_HomeWork
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            Hello hello = new Hello();
            hello.TopLevel = false;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(hello);
            hello.Show();
        }

        private void btnLoan_Click(object sender, EventArgs e)
        {
            Loan loan = new Loan();
            loan.TopLevel = false;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(loan);
            loan.Show();
        }

        private void btnPos_Click(object sender, EventArgs e)
        {
            Pos pos = new Pos();
            pos.TopLevel = false;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(pos);
            pos.Show();
        }

        private void btnStudentStructFrom_Click(object sender, EventArgs e)
        {
            StudentStructFrom student = new StudentStructFrom();
            student.TopLevel = false;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(student);
            student.Show();
        }

        private void btnMyCalculate_Click(object sender, EventArgs e)
        {
            MyCalculate myCalculate = new MyCalculate();
            myCalculate.TopLevel = false;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(myCalculate);
            myCalculate.Show();
        }

        private void btnXOGame_Click(object sender, EventArgs e)
        {
            XOGame xoGame = new XOGame();
            xoGame.TopLevel = false;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(xoGame);
            xoGame.Show();
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            Guess guess = new Guess();
            guess.TopLevel = false;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(guess);
            guess.Show();
        }

        private void btnMethod_Click(object sender, EventArgs e)
        {
            Method method = new Method();
            method.TopLevel = false;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(method);
            method.Show();
        }

        private void btnStudentGrade_Click(object sender, EventArgs e)
        {
            StudentGrade studentGrade = new StudentGrade();
            studentGrade.TopLevel = false;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(studentGrade);
            studentGrade.Show();
        }

        private void btnScreenSaver_Click(object sender, EventArgs e)
        {
            ScreenSaver screenSaver = new ScreenSaver();
            //screenSaver.TopLevel = false;
            splitContainer2.Panel2.Controls.Clear();
            //splitContainer2.Panel2.Controls.Add(screenSaver);
            screenSaver.Show();
        }

        private void btnPainter_Click(object sender, EventArgs e)
        {
            Painter painter = new Painter();
            painter.TopLevel = false;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(painter);
            painter.Show();
        }

        private void btnPictureViewer_Click(object sender, EventArgs e)
        {
            PictureViewer pictureViewer = new PictureViewer();
            pictureViewer.TopLevel = false;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(pictureViewer);
            pictureViewer.Show();
        }

        private void btnAlarm_Click(object sender, EventArgs e)
        {
            Alarm alarm = new Alarm();
            alarm.TopLevel = false;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(alarm);
            alarm.Show();
        }
    }
}
