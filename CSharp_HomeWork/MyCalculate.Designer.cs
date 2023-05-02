namespace CSharp_HomeWork
{
    partial class MyCalculate
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
            this.labNum1 = new System.Windows.Forms.Label();
            this.labNum2 = new System.Windows.Forms.Label();
            this.labAnswer = new System.Windows.Forms.Label();
            this.labLine = new System.Windows.Forms.Label();
            this.btnAddition = new System.Windows.Forms.Button();
            this.btnSaubraction = new System.Windows.Forms.Button();
            this.btnMultipication = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labNum1
            // 
            this.labNum1.AutoSize = true;
            this.labNum1.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labNum1.Location = new System.Drawing.Point(8, 43);
            this.labNum1.Name = "labNum1";
            this.labNum1.Size = new System.Drawing.Size(94, 34);
            this.labNum1.TabIndex = 0;
            this.labNum1.Text = "Num1";
            // 
            // labNum2
            // 
            this.labNum2.AutoSize = true;
            this.labNum2.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labNum2.Location = new System.Drawing.Point(8, 93);
            this.labNum2.Name = "labNum2";
            this.labNum2.Size = new System.Drawing.Size(94, 34);
            this.labNum2.TabIndex = 1;
            this.labNum2.Text = "Num2";
            // 
            // labAnswer
            // 
            this.labAnswer.AutoSize = true;
            this.labAnswer.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labAnswer.Location = new System.Drawing.Point(8, 176);
            this.labAnswer.Name = "labAnswer";
            this.labAnswer.Size = new System.Drawing.Size(108, 34);
            this.labAnswer.TabIndex = 2;
            this.labAnswer.Text = "Answer";
            // 
            // labLine
            // 
            this.labLine.AutoSize = true;
            this.labLine.Location = new System.Drawing.Point(12, 145);
            this.labLine.Name = "labLine";
            this.labLine.Size = new System.Drawing.Size(335, 12);
            this.labLine.TabIndex = 3;
            this.labLine.Text = "=======================================================";
            // 
            // btnAddition
            // 
            this.btnAddition.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAddition.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAddition.Location = new System.Drawing.Point(357, 27);
            this.btnAddition.Name = "btnAddition";
            this.btnAddition.Size = new System.Drawing.Size(49, 48);
            this.btnAddition.TabIndex = 4;
            this.btnAddition.Text = "+";
            this.btnAddition.UseVisualStyleBackColor = true;
            this.btnAddition.Click += new System.EventHandler(this.btnAddition_Click);
            // 
            // btnSaubraction
            // 
            this.btnSaubraction.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSaubraction.Location = new System.Drawing.Point(357, 81);
            this.btnSaubraction.Name = "btnSaubraction";
            this.btnSaubraction.Size = new System.Drawing.Size(49, 48);
            this.btnSaubraction.TabIndex = 5;
            this.btnSaubraction.Text = "-";
            this.btnSaubraction.UseVisualStyleBackColor = true;
            this.btnSaubraction.Click += new System.EventHandler(this.btnSaubraction_Click);
            // 
            // btnMultipication
            // 
            this.btnMultipication.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMultipication.Location = new System.Drawing.Point(357, 135);
            this.btnMultipication.Name = "btnMultipication";
            this.btnMultipication.Size = new System.Drawing.Size(49, 48);
            this.btnMultipication.TabIndex = 6;
            this.btnMultipication.Text = "*";
            this.btnMultipication.UseVisualStyleBackColor = true;
            this.btnMultipication.Click += new System.EventHandler(this.btnMultipication_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDivision.Location = new System.Drawing.Point(357, 189);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(49, 48);
            this.btnDivision.TabIndex = 7;
            this.btnDivision.Text = "/";
            this.btnDivision.UseVisualStyleBackColor = true;
            this.btnDivision.Click += new System.EventHandler(this.btnDivision_Click);
            // 
            // txtNum1
            // 
            this.txtNum1.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtNum1.Location = new System.Drawing.Point(122, 40);
            this.txtNum1.MaxLength = 6;
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(210, 43);
            this.txtNum1.TabIndex = 8;
            // 
            // txtNum2
            // 
            this.txtNum2.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtNum2.Location = new System.Drawing.Point(122, 89);
            this.txtNum2.MaxLength = 6;
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(210, 43);
            this.txtNum2.TabIndex = 9;
            // 
            // txtAnswer
            // 
            this.txtAnswer.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtAnswer.Location = new System.Drawing.Point(122, 173);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.ReadOnly = true;
            this.txtAnswer.Size = new System.Drawing.Size(210, 43);
            this.txtAnswer.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(10, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 27);
            this.label1.TabIndex = 12;
            this.label1.Text = "Num1、Num2皆限制輸入6位數！";
            // 
            // MyCalculate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(433, 270);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnMultipication);
            this.Controls.Add(this.btnSaubraction);
            this.Controls.Add(this.btnAddition);
            this.Controls.Add(this.labLine);
            this.Controls.Add(this.labAnswer);
            this.Controls.Add(this.labNum2);
            this.Controls.Add(this.labNum1);
            this.Name = "MyCalculate";
            this.Text = "MyCalculate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labNum1;
        private System.Windows.Forms.Label labNum2;
        private System.Windows.Forms.Label labAnswer;
        private System.Windows.Forms.Label labLine;
        private System.Windows.Forms.Button btnAddition;
        private System.Windows.Forms.Button btnSaubraction;
        private System.Windows.Forms.Button btnMultipication;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Label label1;
    }
}