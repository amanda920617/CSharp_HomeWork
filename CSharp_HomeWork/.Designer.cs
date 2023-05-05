namespace CSharp_HomeWork
{
    partial class Home
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.labTitle = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.btnMethod = new System.Windows.Forms.Button();
            this.btnAlarm = new System.Windows.Forms.Button();
            this.btnGuess = new System.Windows.Forms.Button();
            this.btnPictureViewer = new System.Windows.Forms.Button();
            this.btnPainter = new System.Windows.Forms.Button();
            this.btnScreenSaver = new System.Windows.Forms.Button();
            this.btnXOGame = new System.Windows.Forms.Button();
            this.btnMyCalculate = new System.Windows.Forms.Button();
            this.btnStudentGrade = new System.Windows.Forms.Button();
            this.btnStudentStructFrom = new System.Windows.Forms.Button();
            this.btnPos = new System.Windows.Forms.Button();
            this.btnLoan = new System.Windows.Forms.Button();
            this.btnHello = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer1.Panel1.BackgroundImage")));
            this.splitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer1.Panel1.Controls.Add(this.labTitle);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(996, 631);
            this.splitContainer1.SplitterDistance = 150;
            this.splitContainer1.TabIndex = 0;
            // 
            // labTitle
            // 
            this.labTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labTitle.AutoSize = true;
            this.labTitle.BackColor = System.Drawing.Color.Transparent;
            this.labTitle.Font = new System.Drawing.Font("微軟正黑體", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labTitle.Location = new System.Drawing.Point(180, 68);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(643, 81);
            this.labTitle.TabIndex = 0;
            this.labTitle.Text = "CSharp_HomeWork";
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer2.Panel1.BackgroundImage")));
            this.splitContainer2.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer2.Panel1.Controls.Add(this.btnMethod);
            this.splitContainer2.Panel1.Controls.Add(this.btnAlarm);
            this.splitContainer2.Panel1.Controls.Add(this.btnGuess);
            this.splitContainer2.Panel1.Controls.Add(this.btnPictureViewer);
            this.splitContainer2.Panel1.Controls.Add(this.btnPainter);
            this.splitContainer2.Panel1.Controls.Add(this.btnScreenSaver);
            this.splitContainer2.Panel1.Controls.Add(this.btnXOGame);
            this.splitContainer2.Panel1.Controls.Add(this.btnMyCalculate);
            this.splitContainer2.Panel1.Controls.Add(this.btnStudentGrade);
            this.splitContainer2.Panel1.Controls.Add(this.btnStudentStructFrom);
            this.splitContainer2.Panel1.Controls.Add(this.btnPos);
            this.splitContainer2.Panel1.Controls.Add(this.btnLoan);
            this.splitContainer2.Panel1.Controls.Add(this.btnHello);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer2.Panel2.BackgroundImage")));
            this.splitContainer2.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer2.Size = new System.Drawing.Size(996, 477);
            this.splitContainer2.SplitterDistance = 287;
            this.splitContainer2.TabIndex = 0;
            // 
            // btnMethod
            // 
            this.btnMethod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMethod.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMethod.Location = new System.Drawing.Point(11, 177);
            this.btnMethod.Name = "btnMethod";
            this.btnMethod.Size = new System.Drawing.Size(263, 26);
            this.btnMethod.TabIndex = 16;
            this.btnMethod.Text = "Method";
            this.btnMethod.UseVisualStyleBackColor = true;
            this.btnMethod.Click += new System.EventHandler(this.btnMethod_Click);
            // 
            // btnAlarm
            // 
            this.btnAlarm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAlarm.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAlarm.Location = new System.Drawing.Point(11, 401);
            this.btnAlarm.Name = "btnAlarm";
            this.btnAlarm.Size = new System.Drawing.Size(263, 26);
            this.btnAlarm.TabIndex = 15;
            this.btnAlarm.Text = "Alarm(有寫例外狀況)";
            this.btnAlarm.UseVisualStyleBackColor = true;
            this.btnAlarm.Click += new System.EventHandler(this.btnAlarm_Click);
            // 
            // btnGuess
            // 
            this.btnGuess.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuess.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnGuess.Location = new System.Drawing.Point(11, 369);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(263, 26);
            this.btnGuess.TabIndex = 14;
            this.btnGuess.Text = "Guess";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // btnPictureViewer
            // 
            this.btnPictureViewer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPictureViewer.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPictureViewer.Location = new System.Drawing.Point(11, 337);
            this.btnPictureViewer.Name = "btnPictureViewer";
            this.btnPictureViewer.Size = new System.Drawing.Size(263, 26);
            this.btnPictureViewer.TabIndex = 13;
            this.btnPictureViewer.Text = "Picture Viewer(有寫例外狀況)";
            this.btnPictureViewer.UseVisualStyleBackColor = true;
            this.btnPictureViewer.Click += new System.EventHandler(this.btnPictureViewer_Click);
            // 
            // btnPainter
            // 
            this.btnPainter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPainter.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPainter.Location = new System.Drawing.Point(11, 305);
            this.btnPainter.Name = "btnPainter";
            this.btnPainter.Size = new System.Drawing.Size(263, 26);
            this.btnPainter.TabIndex = 12;
            this.btnPainter.Text = "小畫家";
            this.btnPainter.UseVisualStyleBackColor = true;
            this.btnPainter.Click += new System.EventHandler(this.btnPainter_Click);
            // 
            // btnScreenSaver
            // 
            this.btnScreenSaver.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnScreenSaver.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnScreenSaver.Location = new System.Drawing.Point(11, 273);
            this.btnScreenSaver.Name = "btnScreenSaver";
            this.btnScreenSaver.Size = new System.Drawing.Size(263, 26);
            this.btnScreenSaver.TabIndex = 10;
            this.btnScreenSaver.Text = "Screen Saver(點擊黑屏處解除)";
            this.btnScreenSaver.UseVisualStyleBackColor = true;
            this.btnScreenSaver.Click += new System.EventHandler(this.btnScreenSaver_Click);
            // 
            // btnXOGame
            // 
            this.btnXOGame.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXOGame.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnXOGame.Location = new System.Drawing.Point(11, 241);
            this.btnXOGame.Name = "btnXOGame";
            this.btnXOGame.Size = new System.Drawing.Size(263, 26);
            this.btnXOGame.TabIndex = 9;
            this.btnXOGame.Text = "X O Game";
            this.btnXOGame.UseVisualStyleBackColor = true;
            this.btnXOGame.Click += new System.EventHandler(this.btnXOGame_Click);
            // 
            // btnMyCalculate
            // 
            this.btnMyCalculate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMyCalculate.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMyCalculate.Location = new System.Drawing.Point(11, 209);
            this.btnMyCalculate.Name = "btnMyCalculate";
            this.btnMyCalculate.Size = new System.Drawing.Size(263, 26);
            this.btnMyCalculate.TabIndex = 7;
            this.btnMyCalculate.Text = "My Calculate";
            this.btnMyCalculate.UseVisualStyleBackColor = true;
            this.btnMyCalculate.Click += new System.EventHandler(this.btnMyCalculate_Click);
            // 
            // btnStudentGrade
            // 
            this.btnStudentGrade.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStudentGrade.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnStudentGrade.Location = new System.Drawing.Point(11, 145);
            this.btnStudentGrade.Name = "btnStudentGrade";
            this.btnStudentGrade.Size = new System.Drawing.Size(263, 26);
            this.btnStudentGrade.TabIndex = 5;
            this.btnStudentGrade.Text = "StudentGrade";
            this.btnStudentGrade.UseVisualStyleBackColor = true;
            this.btnStudentGrade.Click += new System.EventHandler(this.btnStudentGrade_Click);
            // 
            // btnStudentStructFrom
            // 
            this.btnStudentStructFrom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStudentStructFrom.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnStudentStructFrom.Location = new System.Drawing.Point(11, 113);
            this.btnStudentStructFrom.Name = "btnStudentStructFrom";
            this.btnStudentStructFrom.Size = new System.Drawing.Size(263, 26);
            this.btnStudentStructFrom.TabIndex = 4;
            this.btnStudentStructFrom.Text = "Student StructFrom";
            this.btnStudentStructFrom.UseVisualStyleBackColor = true;
            this.btnStudentStructFrom.Click += new System.EventHandler(this.btnStudentStructFrom_Click);
            // 
            // btnPos
            // 
            this.btnPos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPos.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPos.Location = new System.Drawing.Point(11, 81);
            this.btnPos.Name = "btnPos";
            this.btnPos.Size = new System.Drawing.Size(263, 26);
            this.btnPos.TabIndex = 3;
            this.btnPos.Text = "Pos";
            this.btnPos.UseVisualStyleBackColor = true;
            this.btnPos.Click += new System.EventHandler(this.btnPos_Click);
            // 
            // btnLoan
            // 
            this.btnLoan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoan.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnLoan.Location = new System.Drawing.Point(11, 49);
            this.btnLoan.Name = "btnLoan";
            this.btnLoan.Size = new System.Drawing.Size(263, 26);
            this.btnLoan.TabIndex = 2;
            this.btnLoan.Text = "Loan";
            this.btnLoan.UseVisualStyleBackColor = true;
            this.btnLoan.Click += new System.EventHandler(this.btnLoan_Click);
            // 
            // btnHello
            // 
            this.btnHello.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHello.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnHello.Location = new System.Drawing.Point(11, 17);
            this.btnHello.Name = "btnHello";
            this.btnHello.Size = new System.Drawing.Size(263, 26);
            this.btnHello.TabIndex = 0;
            this.btnHello.Text = "Hello";
            this.btnHello.UseVisualStyleBackColor = true;
            this.btnHello.Click += new System.EventHandler(this.btnHello_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(996, 631);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Home";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button btnHello;
        private System.Windows.Forms.Button btnScreenSaver;
        private System.Windows.Forms.Button btnXOGame;
        private System.Windows.Forms.Button btnMyCalculate;
        private System.Windows.Forms.Button btnStudentGrade;
        private System.Windows.Forms.Button btnStudentStructFrom;
        private System.Windows.Forms.Button btnPos;
        private System.Windows.Forms.Button btnLoan;
        private System.Windows.Forms.Label labTitle;
        private System.Windows.Forms.Button btnAlarm;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.Button btnPictureViewer;
        private System.Windows.Forms.Button btnPainter;
        private System.Windows.Forms.Button btnMethod;
    }
}

