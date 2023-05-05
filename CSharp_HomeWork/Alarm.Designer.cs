namespace CSharp_HomeWork
{
    partial class Alarm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBoxAlarm = new System.Windows.Forms.GroupBox();
            this.labSec = new System.Windows.Forms.Label();
            this.txtSec = new System.Windows.Forms.TextBox();
            this.labMin = new System.Windows.Forms.Label();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.labHr = new System.Windows.Forms.Label();
            this.txtHr = new System.Windows.Forms.TextBox();
            this.labAlarm = new System.Windows.Forms.Label();
            this.checkBoxSetAlarm = new System.Windows.Forms.CheckBox();
            this.labNowTime = new System.Windows.Forms.Label();
            this.labShowNowTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBoxAlarm.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxAlarm
            // 
            this.groupBoxAlarm.Controls.Add(this.labSec);
            this.groupBoxAlarm.Controls.Add(this.txtSec);
            this.groupBoxAlarm.Controls.Add(this.labMin);
            this.groupBoxAlarm.Controls.Add(this.txtMin);
            this.groupBoxAlarm.Controls.Add(this.labHr);
            this.groupBoxAlarm.Controls.Add(this.txtHr);
            this.groupBoxAlarm.Controls.Add(this.labAlarm);
            this.groupBoxAlarm.Controls.Add(this.checkBoxSetAlarm);
            this.groupBoxAlarm.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBoxAlarm.Location = new System.Drawing.Point(163, 198);
            this.groupBoxAlarm.Name = "groupBoxAlarm";
            this.groupBoxAlarm.Size = new System.Drawing.Size(488, 167);
            this.groupBoxAlarm.TabIndex = 0;
            this.groupBoxAlarm.TabStop = false;
            this.groupBoxAlarm.Text = "鬧鐘";
            // 
            // labSec
            // 
            this.labSec.AutoSize = true;
            this.labSec.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labSec.Location = new System.Drawing.Point(436, 65);
            this.labSec.Name = "labSec";
            this.labSec.Size = new System.Drawing.Size(42, 34);
            this.labSec.TabIndex = 7;
            this.labSec.Text = "秒";
            // 
            // txtSec
            // 
            this.txtSec.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtSec.Location = new System.Drawing.Point(371, 62);
            this.txtSec.MaxLength = 2;
            this.txtSec.Name = "txtSec";
            this.txtSec.Size = new System.Drawing.Size(59, 43);
            this.txtSec.TabIndex = 6;
            this.txtSec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSec.TextChanged += new System.EventHandler(this.txtSec_TextChanged);
            // 
            // labMin
            // 
            this.labMin.AutoSize = true;
            this.labMin.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labMin.Location = new System.Drawing.Point(323, 65);
            this.labMin.Name = "labMin";
            this.labMin.Size = new System.Drawing.Size(42, 34);
            this.labMin.TabIndex = 5;
            this.labMin.Text = "分";
            // 
            // txtMin
            // 
            this.txtMin.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMin.Location = new System.Drawing.Point(258, 62);
            this.txtMin.MaxLength = 2;
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(59, 43);
            this.txtMin.TabIndex = 4;
            this.txtMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMin.TextChanged += new System.EventHandler(this.txtMin_TextChanged);
            // 
            // labHr
            // 
            this.labHr.AutoSize = true;
            this.labHr.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labHr.Location = new System.Drawing.Point(217, 65);
            this.labHr.Name = "labHr";
            this.labHr.Size = new System.Drawing.Size(42, 34);
            this.labHr.TabIndex = 3;
            this.labHr.Text = "時";
            // 
            // txtHr
            // 
            this.txtHr.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtHr.Location = new System.Drawing.Point(152, 62);
            this.txtHr.MaxLength = 2;
            this.txtHr.Name = "txtHr";
            this.txtHr.Size = new System.Drawing.Size(59, 43);
            this.txtHr.TabIndex = 2;
            this.txtHr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtHr.TextChanged += new System.EventHandler(this.txtHr_TextChanged);
            // 
            // labAlarm
            // 
            this.labAlarm.AutoSize = true;
            this.labAlarm.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labAlarm.Location = new System.Drawing.Point(6, 65);
            this.labAlarm.Name = "labAlarm";
            this.labAlarm.Size = new System.Drawing.Size(150, 34);
            this.labAlarm.TabIndex = 1;
            this.labAlarm.Text = "設定時間：";
            // 
            // checkBoxSetAlarm
            // 
            this.checkBoxSetAlarm.AutoSize = true;
            this.checkBoxSetAlarm.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBoxSetAlarm.Location = new System.Drawing.Point(175, 111);
            this.checkBoxSetAlarm.Name = "checkBoxSetAlarm";
            this.checkBoxSetAlarm.Size = new System.Drawing.Size(142, 38);
            this.checkBoxSetAlarm.TabIndex = 0;
            this.checkBoxSetAlarm.Text = "設定鬧鐘";
            this.checkBoxSetAlarm.UseVisualStyleBackColor = true;
            this.checkBoxSetAlarm.CheckedChanged += new System.EventHandler(this.checkBoxSetAlarm_CheckedChanged);
            // 
            // labNowTime
            // 
            this.labNowTime.AutoSize = true;
            this.labNowTime.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labNowTime.Location = new System.Drawing.Point(42, 39);
            this.labNowTime.Name = "labNowTime";
            this.labNowTime.Size = new System.Drawing.Size(123, 34);
            this.labNowTime.TabIndex = 9;
            this.labNowTime.Text = "現在時間";
            // 
            // labShowNowTime
            // 
            this.labShowNowTime.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labShowNowTime.Location = new System.Drawing.Point(92, 73);
            this.labShowNowTime.Name = "labShowNowTime";
            this.labShowNowTime.Size = new System.Drawing.Size(123, 34);
            this.labShowNowTime.TabIndex = 10;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Alarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labShowNowTime);
            this.Controls.Add(this.labNowTime);
            this.Controls.Add(this.groupBoxAlarm);
            this.Name = "Alarm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Alarm_Load);
            this.groupBoxAlarm.ResumeLayout(false);
            this.groupBoxAlarm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAlarm;
        private System.Windows.Forms.Label labSec;
        private System.Windows.Forms.TextBox txtSec;
        private System.Windows.Forms.Label labMin;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.Label labHr;
        private System.Windows.Forms.TextBox txtHr;
        private System.Windows.Forms.Label labAlarm;
        private System.Windows.Forms.CheckBox checkBoxSetAlarm;
        private System.Windows.Forms.Label labNowTime;
        private System.Windows.Forms.Label labShowNowTime;
        private System.Windows.Forms.Timer timer1;
    }
}