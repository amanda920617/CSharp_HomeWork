using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_HomeWork
{
    public partial class Alarm : Form
    {
        public Alarm()
        {
            InitializeComponent();
        }

        String NowTime = String.Empty;
        bool flag = false;
        int Hr, Min, Sec;

        private void Alarm_Load(object sender, EventArgs e)
        {
            NowTime = DateTime.Now.ToString("HH:mm:ss");
            labShowNowTime.Text = NowTime;
        }

        private void ClearChecked()
        {
            checkBoxSetAlarm.Checked = false;
        }

        private void txtHr_TextChanged(object sender, EventArgs e)
        {
            ClearChecked();
        }


        private void txtMin_TextChanged(object sender, EventArgs e)
        {
            ClearChecked();
        }

        private void txtSec_TextChanged(object sender, EventArgs e)
        {
            ClearChecked();
        }

        private void checkBoxSetAlarm_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSetAlarm.Checked == false)
                return;
            else if (!(int.TryParse(txtHr.Text, out Hr)) || !(int.TryParse(txtMin.Text, out Min)) || !(int.TryParse(txtSec.Text, out Sec)))
            {
                MessageBox.Show($"請先輸入欲設定的鬧鐘時間\n再勾選設定鬧鐘");
                checkBoxSetAlarm.Checked = false;
            }
            else
                flag = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            NowTime = DateTime.Now.ToString("HH:mm:ss");
            //MessageBox.Show(NowTime);
            labShowNowTime.Text = NowTime;
            if(flag)
            {
                string Alarm;
                Alarm = $"{Hr:D2}:{Min:D2}:{Sec:D2}";
                if(string.Equals(NowTime, Alarm))
                {
                    SoundPlayer soundPlayer = new SoundPlayer(@"E:\MSIT_150\CSharp作業\CSharp_HomeWork\CSharp_HomeWork\Music\手機鬧鐘鈴聲.wav");
                    soundPlayer.Play();
                    //MessageBox.Show($"嗶嗶嗶");
                    checkBoxSetAlarm.Checked = false;
                    flag = false;
                    txtHr.Clear();
                    txtMin.Clear();
                    txtSec.Clear();
                    Hr = -1;
                    Min = -1;
                    Sec = -1;
                }
            }
        }
    }
}
