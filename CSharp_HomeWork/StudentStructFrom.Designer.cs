namespace CSharp_HomeWork
{
    partial class StudentStructFrom
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
            this.labName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnShowScore = new System.Windows.Forms.Button();
            this.txtChScore = new System.Windows.Forms.TextBox();
            this.labChScore = new System.Windows.Forms.Label();
            this.txtEnScore = new System.Windows.Forms.TextBox();
            this.labEnScore = new System.Windows.Forms.Label();
            this.txtMathScore = new System.Windows.Forms.TextBox();
            this.labMathScore = new System.Windows.Forms.Label();
            this.Score = new System.Windows.Forms.GroupBox();
            this.labHighestLowestSubject = new System.Windows.Forms.Label();
            this.labShowScore = new System.Windows.Forms.Label();
            this.btnHighestLowestSubject = new System.Windows.Forms.Button();
            this.Score.SuspendLayout();
            this.SuspendLayout();
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labName.Location = new System.Drawing.Point(85, 65);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(96, 34);
            this.labName.TabIndex = 0;
            this.labName.Text = "姓名：";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName.Location = new System.Drawing.Point(187, 62);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 43);
            this.txtName.TabIndex = 1;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnShowScore
            // 
            this.btnShowScore.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnShowScore.Location = new System.Drawing.Point(50, 335);
            this.btnShowScore.Name = "btnShowScore";
            this.btnShowScore.Size = new System.Drawing.Size(277, 45);
            this.btnShowScore.TabIndex = 3;
            this.btnShowScore.Text = "儲存並顯示儲存內容";
            this.btnShowScore.UseVisualStyleBackColor = true;
            this.btnShowScore.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // txtChScore
            // 
            this.txtChScore.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtChScore.Location = new System.Drawing.Point(187, 122);
            this.txtChScore.Name = "txtChScore";
            this.txtChScore.Size = new System.Drawing.Size(100, 43);
            this.txtChScore.TabIndex = 5;
            this.txtChScore.Text = "0";
            this.txtChScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labChScore
            // 
            this.labChScore.AutoSize = true;
            this.labChScore.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labChScore.Location = new System.Drawing.Point(85, 125);
            this.labChScore.Name = "labChScore";
            this.labChScore.Size = new System.Drawing.Size(96, 34);
            this.labChScore.TabIndex = 4;
            this.labChScore.Text = "國文：";
            // 
            // txtEnScore
            // 
            this.txtEnScore.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEnScore.Location = new System.Drawing.Point(187, 182);
            this.txtEnScore.Name = "txtEnScore";
            this.txtEnScore.Size = new System.Drawing.Size(100, 43);
            this.txtEnScore.TabIndex = 7;
            this.txtEnScore.Text = "0";
            this.txtEnScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labEnScore
            // 
            this.labEnScore.AutoSize = true;
            this.labEnScore.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labEnScore.Location = new System.Drawing.Point(85, 185);
            this.labEnScore.Name = "labEnScore";
            this.labEnScore.Size = new System.Drawing.Size(96, 34);
            this.labEnScore.TabIndex = 6;
            this.labEnScore.Text = "英文：";
            // 
            // txtMathScore
            // 
            this.txtMathScore.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMathScore.Location = new System.Drawing.Point(187, 242);
            this.txtMathScore.Name = "txtMathScore";
            this.txtMathScore.Size = new System.Drawing.Size(100, 43);
            this.txtMathScore.TabIndex = 9;
            this.txtMathScore.Text = "0";
            this.txtMathScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labMathScore
            // 
            this.labMathScore.AutoSize = true;
            this.labMathScore.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labMathScore.Location = new System.Drawing.Point(85, 245);
            this.labMathScore.Name = "labMathScore";
            this.labMathScore.Size = new System.Drawing.Size(96, 34);
            this.labMathScore.TabIndex = 8;
            this.labMathScore.Text = "數學：";
            // 
            // Score
            // 
            this.Score.Controls.Add(this.labHighestLowestSubject);
            this.Score.Controls.Add(this.labShowScore);
            this.Score.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Score.Location = new System.Drawing.Point(383, 62);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(367, 248);
            this.Score.TabIndex = 11;
            this.Score.TabStop = false;
            this.Score.Text = "成績";
            // 
            // labHighestLowestSubject
            // 
            this.labHighestLowestSubject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labHighestLowestSubject.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labHighestLowestSubject.Location = new System.Drawing.Point(6, 159);
            this.labHighestLowestSubject.Name = "labHighestLowestSubject";
            this.labHighestLowestSubject.Size = new System.Drawing.Size(355, 86);
            this.labHighestLowestSubject.TabIndex = 1;
            // 
            // labShowScore
            // 
            this.labShowScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labShowScore.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labShowScore.Location = new System.Drawing.Point(6, 39);
            this.labShowScore.Name = "labShowScore";
            this.labShowScore.Size = new System.Drawing.Size(355, 113);
            this.labShowScore.TabIndex = 0;
            // 
            // btnHighestLowestSubject
            // 
            this.btnHighestLowestSubject.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnHighestLowestSubject.Location = new System.Drawing.Point(490, 335);
            this.btnHighestLowestSubject.Name = "btnHighestLowestSubject";
            this.btnHighestLowestSubject.Size = new System.Drawing.Size(260, 45);
            this.btnHighestLowestSubject.TabIndex = 12;
            this.btnHighestLowestSubject.Text = "最高分/最低分科目";
            this.btnHighestLowestSubject.UseVisualStyleBackColor = true;
            this.btnHighestLowestSubject.Click += new System.EventHandler(this.btnHighestLowestSubject_Click);
            // 
            // StudentStructFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHighestLowestSubject);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.txtMathScore);
            this.Controls.Add(this.labMathScore);
            this.Controls.Add(this.txtEnScore);
            this.Controls.Add(this.labEnScore);
            this.Controls.Add(this.txtChScore);
            this.Controls.Add(this.labChScore);
            this.Controls.Add(this.btnShowScore);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labName);
            this.Name = "StudentStructFrom";
            this.Text = "Student_StructFrom";
            this.Score.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnShowScore;
        private System.Windows.Forms.TextBox txtChScore;
        private System.Windows.Forms.Label labChScore;
        private System.Windows.Forms.TextBox txtEnScore;
        private System.Windows.Forms.Label labEnScore;
        private System.Windows.Forms.TextBox txtMathScore;
        private System.Windows.Forms.Label labMathScore;
        private System.Windows.Forms.GroupBox Score;
        private System.Windows.Forms.Label labHighestLowestSubject;
        private System.Windows.Forms.Label labShowScore;
        private System.Windows.Forms.Button btnHighestLowestSubject;
    }
}