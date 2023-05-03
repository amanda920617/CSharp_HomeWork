namespace CSharp_HomeWork
{
    partial class LoanStatistics
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
            this.label1 = new System.Windows.Forms.Label();
            this.TableStatistics = new System.Windows.Forms.TableLayoutPanel();
            this.PanelStatistics = new System.Windows.Forms.Panel();
            this.PanelStatistics.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(61, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "每期應繳金額($)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TableStatistics
            // 
            this.TableStatistics.AutoSize = true;
            this.TableStatistics.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TableStatistics.ColumnCount = 1;
            this.TableStatistics.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TableStatistics.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TableStatistics.Location = new System.Drawing.Point(0, 0);
            this.TableStatistics.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TableStatistics.Name = "TableStatistics";
            this.TableStatistics.Padding = new System.Windows.Forms.Padding(0, 0, 0, 32);
            this.TableStatistics.RowCount = 1;
            this.TableStatistics.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableStatistics.Size = new System.Drawing.Size(0, 32);
            this.TableStatistics.TabIndex = 2;
            // 
            // PanelStatistics
            // 
            this.PanelStatistics.AutoScroll = true;
            this.PanelStatistics.AutoSize = true;
            this.PanelStatistics.Controls.Add(this.TableStatistics);
            this.PanelStatistics.Location = new System.Drawing.Point(33, 50);
            this.PanelStatistics.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PanelStatistics.Name = "PanelStatistics";
            this.PanelStatistics.Size = new System.Drawing.Size(318, 288);
            this.PanelStatistics.TabIndex = 3;
            // 
            // LoanStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(388, 372);
            this.Controls.Add(this.PanelStatistics);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "LoanStatistics";
            this.Text = "LoanStatistics";
            this.PanelStatistics.ResumeLayout(false);
            this.PanelStatistics.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TableLayoutPanel TableStatistics;
        private System.Windows.Forms.Panel PanelStatistics;
    }
}