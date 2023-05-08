namespace CSharp_HomeWork
{
    partial class NotePad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotePad));
            this.mS = new System.Windows.Forms.MenuStrip();
            this.檔案F = new System.Windows.Forms.ToolStripMenuItem();
            this.新增N = new System.Windows.Forms.ToolStripMenuItem();
            this.開啟O = new System.Windows.Forms.ToolStripMenuItem();
            this.tSSep3 = new System.Windows.Forms.ToolStripSeparator();
            this.儲存S = new System.Windows.Forms.ToolStripMenuItem();
            this.另存新檔A = new System.Windows.Forms.ToolStripMenuItem();
            this.tSSep4 = new System.Windows.Forms.ToolStripSeparator();
            this.列印P = new System.Windows.Forms.ToolStripMenuItem();
            this.預覽列印V = new System.Windows.Forms.ToolStripMenuItem();
            this.tSSep5 = new System.Windows.Forms.ToolStripSeparator();
            this.結束X = new System.Windows.Forms.ToolStripMenuItem();
            this.編輯E = new System.Windows.Forms.ToolStripMenuItem();
            this.復原U = new System.Windows.Forms.ToolStripMenuItem();
            this.取消復原R = new System.Windows.Forms.ToolStripMenuItem();
            this.tSSep6 = new System.Windows.Forms.ToolStripSeparator();
            this.剪下T = new System.Windows.Forms.ToolStripMenuItem();
            this.複製C = new System.Windows.Forms.ToolStripMenuItem();
            this.貼上P = new System.Windows.Forms.ToolStripMenuItem();
            this.tSSep7 = new System.Windows.Forms.ToolStripSeparator();
            this.全選A = new System.Windows.Forms.ToolStripMenuItem();
            this.工具T = new System.Windows.Forms.ToolStripMenuItem();
            this.自訂C = new System.Windows.Forms.ToolStripMenuItem();
            this.選項O = new System.Windows.Forms.ToolStripMenuItem();
            this.格式M = new System.Windows.Forms.ToolStripMenuItem();
            this.顏色C = new System.Windows.Forms.ToolStripMenuItem();
            this.字型Y = new System.Windows.Forms.ToolStripMenuItem();
            this.toUpperU = new System.Windows.Forms.ToolStripMenuItem();
            this.toLowerL = new System.Windows.Forms.ToolStripMenuItem();
            this.自動換行 = new System.Windows.Forms.ToolStripMenuItem();
            this.快選顏色 = new System.Windows.Forms.ToolStripMenuItem();
            this.紅色Red = new System.Windows.Forms.ToolStripMenuItem();
            this.綠色Green = new System.Windows.Forms.ToolStripMenuItem();
            this.藍色Blue = new System.Windows.Forms.ToolStripMenuItem();
            this.黑色Black = new System.Windows.Forms.ToolStripMenuItem();
            this.說明H = new System.Windows.Forms.ToolStripMenuItem();
            this.關於AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tS = new System.Windows.Forms.ToolStrip();
            this.tSBtn1 = new System.Windows.Forms.ToolStripButton();
            this.tSBtn2 = new System.Windows.Forms.ToolStripButton();
            this.tSBtn3 = new System.Windows.Forms.ToolStripButton();
            this.tSBtn4 = new System.Windows.Forms.ToolStripButton();
            this.tSSep1 = new System.Windows.Forms.ToolStripSeparator();
            this.tSBtn5 = new System.Windows.Forms.ToolStripButton();
            this.tSBtn6 = new System.Windows.Forms.ToolStripButton();
            this.tSBtn7 = new System.Windows.Forms.ToolStripButton();
            this.tSSep2 = new System.Windows.Forms.ToolStripSeparator();
            this.tSBtn8 = new System.Windows.Forms.ToolStripButton();
            this.Rtxt = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.mS.SuspendLayout();
            this.tS.SuspendLayout();
            this.SuspendLayout();
            // 
            // mS
            // 
            this.mS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.檔案F,
            this.編輯E,
            this.工具T,
            this.格式M,
            this.說明H});
            this.mS.Location = new System.Drawing.Point(0, 0);
            this.mS.Name = "mS";
            this.mS.Size = new System.Drawing.Size(800, 24);
            this.mS.TabIndex = 0;
            this.mS.Text = "menuStrip1";
            // 
            // 檔案F
            // 
            this.檔案F.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新增N,
            this.開啟O,
            this.tSSep3,
            this.儲存S,
            this.另存新檔A,
            this.tSSep4,
            this.列印P,
            this.預覽列印V,
            this.tSSep5,
            this.結束X});
            this.檔案F.Name = "檔案F";
            this.檔案F.Size = new System.Drawing.Size(57, 20);
            this.檔案F.Text = "檔案(F)";
            // 
            // 新增N
            // 
            this.新增N.Name = "新增N";
            this.新增N.Size = new System.Drawing.Size(169, 22);
            this.新增N.Text = "新增(N)     Ctrl+N";
            this.新增N.Click += new System.EventHandler(this.新增Add_Click);
            // 
            // 開啟O
            // 
            this.開啟O.Name = "開啟O";
            this.開啟O.Size = new System.Drawing.Size(169, 22);
            this.開啟O.Text = "開啟(O)     Ctrl+O";
            this.開啟O.Click += new System.EventHandler(this.開啟Open_Click);
            // 
            // tSSep3
            // 
            this.tSSep3.Name = "tSSep3";
            this.tSSep3.Size = new System.Drawing.Size(166, 6);
            // 
            // 儲存S
            // 
            this.儲存S.Name = "儲存S";
            this.儲存S.Size = new System.Drawing.Size(169, 22);
            this.儲存S.Text = "儲存(S)     Ctrl+S";
            this.儲存S.Click += new System.EventHandler(this.儲存Save_Click);
            // 
            // 另存新檔A
            // 
            this.另存新檔A.Name = "另存新檔A";
            this.另存新檔A.Size = new System.Drawing.Size(169, 22);
            this.另存新檔A.Text = "另存新檔(&A)";
            this.另存新檔A.Click += new System.EventHandler(this.另存新檔OtherSave_Click);
            // 
            // tSSep4
            // 
            this.tSSep4.Name = "tSSep4";
            this.tSSep4.Size = new System.Drawing.Size(166, 6);
            // 
            // 列印P
            // 
            this.列印P.Name = "列印P";
            this.列印P.Size = new System.Drawing.Size(169, 22);
            this.列印P.Text = "列印(P)     Ctrl+P";
            this.列印P.Click += new System.EventHandler(this.列印Print_Click);
            // 
            // 預覽列印V
            // 
            this.預覽列印V.Name = "預覽列印V";
            this.預覽列印V.Size = new System.Drawing.Size(169, 22);
            this.預覽列印V.Text = "預覽列印(&V)";
            this.預覽列印V.Click += new System.EventHandler(this.預覽列印View_Click);
            // 
            // tSSep5
            // 
            this.tSSep5.Name = "tSSep5";
            this.tSSep5.Size = new System.Drawing.Size(166, 6);
            // 
            // 結束X
            // 
            this.結束X.Name = "結束X";
            this.結束X.Size = new System.Drawing.Size(169, 22);
            this.結束X.Text = "結束(&X)";
            // 
            // 編輯E
            // 
            this.編輯E.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.復原U,
            this.取消復原R,
            this.tSSep6,
            this.剪下T,
            this.複製C,
            this.貼上P,
            this.tSSep7,
            this.全選A});
            this.編輯E.Name = "編輯E";
            this.編輯E.Size = new System.Drawing.Size(58, 20);
            this.編輯E.Text = "編輯(E)";
            // 
            // 復原U
            // 
            this.復原U.Name = "復原U";
            this.復原U.Size = new System.Drawing.Size(188, 22);
            this.復原U.Text = "復原(U)     Ctrl+Z";
            this.復原U.Click += new System.EventHandler(this.復原Undo_Click);
            // 
            // 取消復原R
            // 
            this.取消復原R.Name = "取消復原R";
            this.取消復原R.Size = new System.Drawing.Size(188, 22);
            this.取消復原R.Text = "取消復原(R)     Ctrl+Y";
            this.取消復原R.Click += new System.EventHandler(this.取消復原Redo_Click);
            // 
            // tSSep6
            // 
            this.tSSep6.Name = "tSSep6";
            this.tSSep6.Size = new System.Drawing.Size(185, 6);
            // 
            // 剪下T
            // 
            this.剪下T.Name = "剪下T";
            this.剪下T.Size = new System.Drawing.Size(188, 22);
            this.剪下T.Text = "剪下(T)     Ctrl+X";
            this.剪下T.Click += new System.EventHandler(this.剪下Cut_Click);
            // 
            // 複製C
            // 
            this.複製C.Name = "複製C";
            this.複製C.Size = new System.Drawing.Size(188, 22);
            this.複製C.Text = "複製(C)     Ctrl+C";
            this.複製C.Click += new System.EventHandler(this.複製Copy_Click);
            // 
            // 貼上P
            // 
            this.貼上P.Name = "貼上P";
            this.貼上P.Size = new System.Drawing.Size(188, 22);
            this.貼上P.Text = "貼上(P)     Ctrl+V";
            this.貼上P.Click += new System.EventHandler(this.貼上Paste_Click);
            // 
            // tSSep7
            // 
            this.tSSep7.Name = "tSSep7";
            this.tSSep7.Size = new System.Drawing.Size(185, 6);
            // 
            // 全選A
            // 
            this.全選A.Name = "全選A";
            this.全選A.Size = new System.Drawing.Size(188, 22);
            this.全選A.Text = "全選(A)     Ctrl+A";
            this.全選A.Click += new System.EventHandler(this.全選All_Click);
            // 
            // 工具T
            // 
            this.工具T.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.自訂C,
            this.選項O});
            this.工具T.Name = "工具T";
            this.工具T.Size = new System.Drawing.Size(58, 20);
            this.工具T.Text = "工具(T)";
            // 
            // 自訂C
            // 
            this.自訂C.Name = "自訂C";
            this.自訂C.Size = new System.Drawing.Size(180, 22);
            this.自訂C.Text = "自訂(&C)";
            // 
            // 選項O
            // 
            this.選項O.Name = "選項O";
            this.選項O.Size = new System.Drawing.Size(180, 22);
            this.選項O.Text = "選項(&O)";
            // 
            // 格式M
            // 
            this.格式M.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.顏色C,
            this.字型Y,
            this.toUpperU,
            this.toLowerL,
            this.自動換行,
            this.快選顏色});
            this.格式M.Name = "格式M";
            this.格式M.Size = new System.Drawing.Size(63, 20);
            this.格式M.Text = "格式(M)";
            // 
            // 顏色C
            // 
            this.顏色C.Name = "顏色C";
            this.顏色C.Size = new System.Drawing.Size(145, 22);
            this.顏色C.Text = "顏色(&C)";
            this.顏色C.Click += new System.EventHandler(this.顏色Color_Click);
            // 
            // 字型Y
            // 
            this.字型Y.Name = "字型Y";
            this.字型Y.Size = new System.Drawing.Size(145, 22);
            this.字型Y.Text = "字型(&Y)";
            this.字型Y.Click += new System.EventHandler(this.字型Font_Click);
            // 
            // toUpperU
            // 
            this.toUpperU.Name = "toUpperU";
            this.toUpperU.Size = new System.Drawing.Size(145, 22);
            this.toUpperU.Text = "To Upper(&U)";
            this.toUpperU.Click += new System.EventHandler(this.toUpper_Click);
            // 
            // toLowerL
            // 
            this.toLowerL.Name = "toLowerL";
            this.toLowerL.Size = new System.Drawing.Size(145, 22);
            this.toLowerL.Text = "To Lower(&L)";
            this.toLowerL.Click += new System.EventHandler(this.toLower_Click);
            // 
            // 自動換行
            // 
            this.自動換行.Checked = true;
            this.自動換行.CheckState = System.Windows.Forms.CheckState.Checked;
            this.自動換行.Name = "自動換行";
            this.自動換行.Size = new System.Drawing.Size(145, 22);
            this.自動換行.Text = "自動換行";
            this.自動換行.Click += new System.EventHandler(this.自動換行Enter_Click);
            // 
            // 快選顏色
            // 
            this.快選顏色.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.紅色Red,
            this.綠色Green,
            this.藍色Blue,
            this.黑色Black});
            this.快選顏色.Name = "快選顏色";
            this.快選顏色.Size = new System.Drawing.Size(145, 22);
            this.快選顏色.Text = "快選顏色";
            // 
            // 紅色Red
            // 
            this.紅色Red.Name = "紅色Red";
            this.紅色Red.Size = new System.Drawing.Size(141, 22);
            this.紅色Red.Text = "紅色   Red";
            this.紅色Red.Click += new System.EventHandler(this.紅色R_Click);
            // 
            // 綠色Green
            // 
            this.綠色Green.Name = "綠色Green";
            this.綠色Green.Size = new System.Drawing.Size(141, 22);
            this.綠色Green.Text = "綠色   Green";
            this.綠色Green.Click += new System.EventHandler(this.綠色G_Click);
            // 
            // 藍色Blue
            // 
            this.藍色Blue.Name = "藍色Blue";
            this.藍色Blue.Size = new System.Drawing.Size(141, 22);
            this.藍色Blue.Text = "藍色   Blue";
            this.藍色Blue.Click += new System.EventHandler(this.藍色Bu_Click);
            // 
            // 黑色Black
            // 
            this.黑色Black.Name = "黑色Black";
            this.黑色Black.Size = new System.Drawing.Size(141, 22);
            this.黑色Black.Text = "黑色   Black";
            this.黑色Black.Click += new System.EventHandler(this.黑色Bk_Click);
            // 
            // 說明H
            // 
            this.說明H.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.關於AToolStripMenuItem});
            this.說明H.Name = "說明H";
            this.說明H.Size = new System.Drawing.Size(60, 20);
            this.說明H.Text = "說明(H)";
            // 
            // 關於AToolStripMenuItem
            // 
            this.關於AToolStripMenuItem.Name = "關於AToolStripMenuItem";
            this.關於AToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.關於AToolStripMenuItem.Text = "關於(&A)";
            this.關於AToolStripMenuItem.Click += new System.EventHandler(this.關於AToolStripMenuItem_Click);
            // 
            // tS
            // 
            this.tS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSBtn1,
            this.tSBtn2,
            this.tSBtn3,
            this.tSBtn4,
            this.tSSep1,
            this.tSBtn5,
            this.tSBtn6,
            this.tSBtn7,
            this.tSSep2,
            this.tSBtn8});
            this.tS.Location = new System.Drawing.Point(0, 24);
            this.tS.Name = "tS";
            this.tS.Size = new System.Drawing.Size(800, 25);
            this.tS.TabIndex = 1;
            this.tS.Text = "toolStrip1";
            // 
            // tSBtn1
            // 
            this.tSBtn1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSBtn1.Image = ((System.Drawing.Image)(resources.GetObject("tSBtn1.Image")));
            this.tSBtn1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBtn1.Name = "tSBtn1";
            this.tSBtn1.Size = new System.Drawing.Size(23, 22);
            this.tSBtn1.Text = "toolStripButton1";
            // 
            // tSBtn2
            // 
            this.tSBtn2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSBtn2.Image = ((System.Drawing.Image)(resources.GetObject("tSBtn2.Image")));
            this.tSBtn2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBtn2.Name = "tSBtn2";
            this.tSBtn2.Size = new System.Drawing.Size(23, 22);
            this.tSBtn2.Text = "toolStripButton2";
            // 
            // tSBtn3
            // 
            this.tSBtn3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSBtn3.Image = ((System.Drawing.Image)(resources.GetObject("tSBtn3.Image")));
            this.tSBtn3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBtn3.Name = "tSBtn3";
            this.tSBtn3.Size = new System.Drawing.Size(23, 22);
            this.tSBtn3.Text = "toolStripButton3";
            // 
            // tSBtn4
            // 
            this.tSBtn4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSBtn4.Image = ((System.Drawing.Image)(resources.GetObject("tSBtn4.Image")));
            this.tSBtn4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBtn4.Name = "tSBtn4";
            this.tSBtn4.Size = new System.Drawing.Size(23, 22);
            this.tSBtn4.Text = "toolStripButton4";
            // 
            // tSSep1
            // 
            this.tSSep1.Name = "tSSep1";
            this.tSSep1.Size = new System.Drawing.Size(6, 25);
            // 
            // tSBtn5
            // 
            this.tSBtn5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSBtn5.Image = ((System.Drawing.Image)(resources.GetObject("tSBtn5.Image")));
            this.tSBtn5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBtn5.Name = "tSBtn5";
            this.tSBtn5.Size = new System.Drawing.Size(23, 22);
            this.tSBtn5.Text = "toolStripButton5";
            // 
            // tSBtn6
            // 
            this.tSBtn6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSBtn6.Image = ((System.Drawing.Image)(resources.GetObject("tSBtn6.Image")));
            this.tSBtn6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBtn6.Name = "tSBtn6";
            this.tSBtn6.Size = new System.Drawing.Size(23, 22);
            this.tSBtn6.Text = "toolStripButton6";
            // 
            // tSBtn7
            // 
            this.tSBtn7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSBtn7.Image = ((System.Drawing.Image)(resources.GetObject("tSBtn7.Image")));
            this.tSBtn7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBtn7.Name = "tSBtn7";
            this.tSBtn7.Size = new System.Drawing.Size(23, 22);
            this.tSBtn7.Text = "toolStripButton7";
            // 
            // tSSep2
            // 
            this.tSSep2.Name = "tSSep2";
            this.tSSep2.Size = new System.Drawing.Size(6, 25);
            // 
            // tSBtn8
            // 
            this.tSBtn8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSBtn8.Image = ((System.Drawing.Image)(resources.GetObject("tSBtn8.Image")));
            this.tSBtn8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBtn8.Name = "tSBtn8";
            this.tSBtn8.Size = new System.Drawing.Size(23, 22);
            this.tSBtn8.Text = "toolStripButton8";
            // 
            // Rtxt
            // 
            this.Rtxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Rtxt.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Rtxt.Location = new System.Drawing.Point(0, 49);
            this.Rtxt.Name = "Rtxt";
            this.Rtxt.Size = new System.Drawing.Size(800, 401);
            this.Rtxt.TabIndex = 2;
            this.Rtxt.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "純文字檔案|*.txt";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "純文字檔案|*.txt";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // NotePad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Rtxt);
            this.Controls.Add(this.tS);
            this.Controls.Add(this.mS);
            this.KeyPreview = true;
            this.MainMenuStrip = this.mS;
            this.Name = "NotePad";
            this.Text = "NotePad";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NotePad_KeyDown);
            this.mS.ResumeLayout(false);
            this.mS.PerformLayout();
            this.tS.ResumeLayout(false);
            this.tS.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mS;
        private System.Windows.Forms.ToolStripMenuItem 檔案F;
        private System.Windows.Forms.ToolStripMenuItem 新增N;
        private System.Windows.Forms.ToolStripMenuItem 編輯E;
        private System.Windows.Forms.ToolStripMenuItem 工具T;
        private System.Windows.Forms.ToolStripMenuItem 格式M;
        private System.Windows.Forms.ToolStripMenuItem 說明H;
        private System.Windows.Forms.ToolStripMenuItem 開啟O;
        private System.Windows.Forms.ToolStripMenuItem 儲存S;
        private System.Windows.Forms.ToolStripMenuItem 列印P;
        private System.Windows.Forms.ToolStripMenuItem 預覽列印V;
        private System.Windows.Forms.ToolStripMenuItem 結束X;
        private System.Windows.Forms.ToolStripMenuItem 復原U;
        private System.Windows.Forms.ToolStripMenuItem 取消復原R;
        private System.Windows.Forms.ToolStripMenuItem 剪下T;
        private System.Windows.Forms.ToolStripMenuItem 複製C;
        private System.Windows.Forms.ToolStripMenuItem 貼上P;
        private System.Windows.Forms.ToolStripMenuItem 全選A;
        private System.Windows.Forms.ToolStripMenuItem 自訂C;
        private System.Windows.Forms.ToolStripMenuItem 選項O;
        private System.Windows.Forms.ToolStripMenuItem 顏色C;
        private System.Windows.Forms.ToolStripMenuItem 字型Y;
        private System.Windows.Forms.ToolStripMenuItem toUpperU;
        private System.Windows.Forms.ToolStripMenuItem toLowerL;
        private System.Windows.Forms.ToolStripMenuItem 自動換行;
        private System.Windows.Forms.ToolStripMenuItem 快選顏色;
        private System.Windows.Forms.ToolStripMenuItem 紅色Red;
        private System.Windows.Forms.ToolStripMenuItem 綠色Green;
        private System.Windows.Forms.ToolStripMenuItem 藍色Blue;
        private System.Windows.Forms.ToolStripMenuItem 黑色Black;
        private System.Windows.Forms.ToolStripMenuItem 關於AToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator tSSep3;
        private System.Windows.Forms.ToolStripMenuItem 另存新檔A;
        private System.Windows.Forms.ToolStripSeparator tSSep4;
        private System.Windows.Forms.ToolStripSeparator tSSep5;
        private System.Windows.Forms.ToolStripSeparator tSSep6;
        private System.Windows.Forms.ToolStripSeparator tSSep7;
        private System.Windows.Forms.ToolStrip tS;
        private System.Windows.Forms.ToolStripButton tSBtn1;
        private System.Windows.Forms.ToolStripButton tSBtn2;
        private System.Windows.Forms.ToolStripButton tSBtn3;
        private System.Windows.Forms.ToolStripButton tSBtn4;
        private System.Windows.Forms.ToolStripSeparator tSSep1;
        private System.Windows.Forms.ToolStripButton tSBtn5;
        private System.Windows.Forms.ToolStripButton tSBtn6;
        private System.Windows.Forms.ToolStripButton tSBtn7;
        private System.Windows.Forms.ToolStripSeparator tSSep2;
        private System.Windows.Forms.ToolStripButton tSBtn8;
        private System.Windows.Forms.RichTextBox Rtxt;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}