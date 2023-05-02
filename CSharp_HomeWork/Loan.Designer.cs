namespace CSharp_HomeWork
{
    partial class Loan
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
            this.labLoanAmount = new System.Windows.Forms.Label();
            this.labAnnualInterestRate = new System.Windows.Forms.Label();
            this.labLoanPeriod = new System.Windows.Forms.Label();
            this.txtLoanAmount = new System.Windows.Forms.TextBox();
            this.txtAnnualInterestRate = new System.Windows.Forms.TextBox();
            this.txtLoanPeriod = new System.Windows.Forms.TextBox();
            this.btnCalaulate = new System.Windows.Forms.Button();
            this.labFullInterest = new System.Windows.Forms.Label();
            this.txtFullInterest = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnStatistics = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labLoanAmount
            // 
            this.labLoanAmount.AutoSize = true;
            this.labLoanAmount.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labLoanAmount.Location = new System.Drawing.Point(296, 59);
            this.labLoanAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labLoanAmount.Name = "labLoanAmount";
            this.labLoanAmount.Size = new System.Drawing.Size(208, 43);
            this.labLoanAmount.TabIndex = 0;
            this.labLoanAmount.Text = "貸款金額($):";
            // 
            // labAnnualInterestRate
            // 
            this.labAnnualInterestRate.AutoSize = true;
            this.labAnnualInterestRate.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labAnnualInterestRate.Location = new System.Drawing.Point(296, 159);
            this.labAnnualInterestRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labAnnualInterestRate.Name = "labAnnualInterestRate";
            this.labAnnualInterestRate.Size = new System.Drawing.Size(185, 43);
            this.labAnnualInterestRate.TabIndex = 1;
            this.labAnnualInterestRate.Text = "年利率(%):";
            // 
            // labLoanPeriod
            // 
            this.labLoanPeriod.AutoSize = true;
            this.labLoanPeriod.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labLoanPeriod.Location = new System.Drawing.Point(296, 259);
            this.labLoanPeriod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labLoanPeriod.Name = "labLoanPeriod";
            this.labLoanPeriod.Size = new System.Drawing.Size(222, 43);
            this.labLoanPeriod.TabIndex = 2;
            this.labLoanPeriod.Text = "貸款期數(月):\t";
            // 
            // txtLoanAmount
            // 
            this.txtLoanAmount.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtLoanAmount.Location = new System.Drawing.Point(567, 55);
            this.txtLoanAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txtLoanAmount.Name = "txtLoanAmount";
            this.txtLoanAmount.Size = new System.Drawing.Size(203, 52);
            this.txtLoanAmount.TabIndex = 3;
            this.txtLoanAmount.Text = "100000";
            // 
            // txtAnnualInterestRate
            // 
            this.txtAnnualInterestRate.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtAnnualInterestRate.Location = new System.Drawing.Point(567, 155);
            this.txtAnnualInterestRate.Margin = new System.Windows.Forms.Padding(4);
            this.txtAnnualInterestRate.Name = "txtAnnualInterestRate";
            this.txtAnnualInterestRate.Size = new System.Drawing.Size(203, 52);
            this.txtAnnualInterestRate.TabIndex = 4;
            this.txtAnnualInterestRate.Text = "10";
            // 
            // txtLoanPeriod
            // 
            this.txtLoanPeriod.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtLoanPeriod.Location = new System.Drawing.Point(567, 255);
            this.txtLoanPeriod.Margin = new System.Windows.Forms.Padding(4);
            this.txtLoanPeriod.Name = "txtLoanPeriod";
            this.txtLoanPeriod.Size = new System.Drawing.Size(203, 52);
            this.txtLoanPeriod.TabIndex = 5;
            this.txtLoanPeriod.Text = "24";
            // 
            // btnCalaulate
            // 
            this.btnCalaulate.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCalaulate.Location = new System.Drawing.Point(240, 456);
            this.btnCalaulate.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalaulate.Name = "btnCalaulate";
            this.btnCalaulate.Size = new System.Drawing.Size(115, 66);
            this.btnCalaulate.TabIndex = 6;
            this.btnCalaulate.Text = "計算";
            this.btnCalaulate.UseVisualStyleBackColor = true;
            this.btnCalaulate.Click += new System.EventHandler(this.btnCalaulate_Click);
            // 
            // labFullInterest
            // 
            this.labFullInterest.AutoSize = true;
            this.labFullInterest.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labFullInterest.Location = new System.Drawing.Point(296, 359);
            this.labFullInterest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labFullInterest.Name = "labFullInterest";
            this.labFullInterest.Size = new System.Drawing.Size(208, 43);
            this.labFullInterest.TabIndex = 7;
            this.labFullInterest.Text = "全部利息($):";
            // 
            // txtFullInterest
            // 
            this.txtFullInterest.Enabled = false;
            this.txtFullInterest.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtFullInterest.Location = new System.Drawing.Point(567, 355);
            this.txtFullInterest.Margin = new System.Windows.Forms.Padding(4);
            this.txtFullInterest.Name = "txtFullInterest";
            this.txtFullInterest.Size = new System.Drawing.Size(203, 52);
            this.txtFullInterest.TabIndex = 8;
            // 
            // btnClear
            // 
            this.btnClear.Enabled = false;
            this.btnClear.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClear.Location = new System.Drawing.Point(403, 456);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(115, 66);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "清除";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnReport
            // 
            this.btnReport.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReport.Location = new System.Drawing.Point(567, 456);
            this.btnReport.Margin = new System.Windows.Forms.Padding(4);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(115, 66);
            this.btnReport.TabIndex = 10;
            this.btnReport.Text = "報表";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnStatistics
            // 
            this.btnStatistics.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnStatistics.Location = new System.Drawing.Point(733, 456);
            this.btnStatistics.Margin = new System.Windows.Forms.Padding(4);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(115, 66);
            this.btnStatistics.TabIndex = 11;
            this.btnStatistics.Text = "統計";
            this.btnStatistics.UseVisualStyleBackColor = true;
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
            // 
            // Loan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.btnStatistics);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtFullInterest);
            this.Controls.Add(this.labFullInterest);
            this.Controls.Add(this.btnCalaulate);
            this.Controls.Add(this.txtLoanPeriod);
            this.Controls.Add(this.txtAnnualInterestRate);
            this.Controls.Add(this.txtLoanAmount);
            this.Controls.Add(this.labLoanPeriod);
            this.Controls.Add(this.labAnnualInterestRate);
            this.Controls.Add(this.labLoanAmount);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Loan";
            this.Text = "Loan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labLoanAmount;
        private System.Windows.Forms.Label labAnnualInterestRate;
        private System.Windows.Forms.Label labLoanPeriod;
        private System.Windows.Forms.TextBox txtLoanAmount;
        private System.Windows.Forms.TextBox txtAnnualInterestRate;
        private System.Windows.Forms.TextBox txtLoanPeriod;
        private System.Windows.Forms.Button btnCalaulate;
        private System.Windows.Forms.Label labFullInterest;
        private System.Windows.Forms.TextBox txtFullInterest;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnStatistics;
    }
}