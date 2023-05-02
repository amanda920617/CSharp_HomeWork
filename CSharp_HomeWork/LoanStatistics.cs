using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace CSharp_HomeWork
{
    public partial class LoanStatistics : Form
    {
        public LoanStatistics()
        {
            InitializeComponent();
        }
        public bool Statistics()
        {
            //if (LoanValue.LoanPeriod == 0) return false;
            if (LoanValue.FullInterest == 0)
            {
                MessageBox.Show("【全部利息】錯誤，請重新輸入，再輸出統計", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                InitializeTLStatisticsTable();

                CreateColumn();
                CreateRow();
                TableStatistics.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
                CreateTital();
                CreateContent();
                PanelStatistics.Refresh();
                return true;
            }
        }
        private void InitializeTLStatisticsTable()
        {
            TableStatistics.Controls.Clear();
            TableStatistics.RowStyles.Clear();
            TableStatistics.ColumnStyles.Clear();
        }
        private void CreateColumn()
        {
            int ColumnCount = 4;
            TableStatistics.ColumnCount = ColumnCount;
            for (int i = 0; i < ColumnCount; i++)
            {
                TableStatistics.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            }
        }

        private void CreateRow()
        {
            int RowCount = LoanValue.LoanPeriod;
            TableStatistics.RowCount = RowCount;
            for (int i = 0; i < RowCount; i++)
            {
                TableStatistics.RowStyles.Add(new ColumnStyle(SizeType.AutoSize));
            }
        }
        public void CreateTital()
        {
            int ColumnCount = 4;
            for (int j = 0; j < ColumnCount; j++)
            {
                //Console.WriteLine($"i = {i.ToString()} ,j = {j.ToString()}");
                string[] content = new string[4] { "期數", "償還本金", "償還利息", "本期應繳金額" };

                System.Windows.Forms.Label label = new System.Windows.Forms.Label();
                label.Name = "Label_" + 0 + "_" + j.ToString();
                label.Text = content[j];
                label.Anchor = AnchorStyles.Left | AnchorStyles.Right;
                label.AutoSize = true;
                label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                label.Font = new Font("微軟正黑體", 12, FontStyle.Bold);

                TableStatistics.Controls.Add(label);
                TableStatistics.SetCellPosition(label, new TableLayoutPanelCellPosition(j, 0));
            }
        }
        public void CreateContent()
        {
            int ColumnCount = 4;
            int RowCount = LoanValue.LoanPeriod;
            for (int i = 1; i <= RowCount; i++)
            {
                for (int j = 0; j < ColumnCount; j++)
                {
                    //Console.WriteLine($"i = {i.ToString()} ,j = {j.ToString()}");

                    string RepayThePrincipal = LoanValue.RepayThePrincipal.ToString();
                    string RepayInterest = LoanValue.text[i-1];
                    string Total = (LoanValue.RepayThePrincipal + int.Parse(LoanValue.text[i-1])).ToString();
                    string[] content = new string[4] { i.ToString(), RepayThePrincipal, RepayInterest, Total };

                    System.Windows.Forms.Label label = new System.Windows.Forms.Label();
                    label.Name = "Label_" + i.ToString() + "_" + j.ToString();
                    label.Text = content[j];
                    //Console.WriteLine($"label.Text = {label.Text}");
                    label.Anchor = AnchorStyles.Left | AnchorStyles.Right;
                    label.AutoSize = true;
                    label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    label.Font = new Font("微軟正黑體", 12, FontStyle.Bold);

                    TableStatistics.Controls.Add(label);
                    TableStatistics.SetCellPosition(label, new TableLayoutPanelCellPosition(j, i));
                    //Console.WriteLine($"RepayT = {RepayThePrincipal} ,{text[j]}");
                }
            }
        }
    }
}
