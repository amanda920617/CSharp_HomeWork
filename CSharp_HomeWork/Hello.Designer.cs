namespace CSharp_HomeWork
{
    partial class Hello
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hello));
            this.btnSayHello = new System.Windows.Forms.Button();
            this.btnSayHi = new System.Windows.Forms.Button();
            this.txtChName = new System.Windows.Forms.TextBox();
            this.labChName = new System.Windows.Forms.Label();
            this.labEnName = new System.Windows.Forms.Label();
            this.labGender = new System.Windows.Forms.Label();
            this.labConstellation = new System.Windows.Forms.Label();
            this.txtEnName = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.txtConstellation = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSayHello
            // 
            this.btnSayHello.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSayHello.Font = new System.Drawing.Font("微軟正黑體", 20F, System.Drawing.FontStyle.Bold);
            this.btnSayHello.Location = new System.Drawing.Point(683, 379);
            this.btnSayHello.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSayHello.Name = "btnSayHello";
            this.btnSayHello.Size = new System.Drawing.Size(200, 62);
            this.btnSayHello.TabIndex = 0;
            this.btnSayHello.Text = "Say Hello";
            this.btnSayHello.UseVisualStyleBackColor = false;
            this.btnSayHello.Click += new System.EventHandler(this.btnSayHello_Click);
            // 
            // btnSayHi
            // 
            this.btnSayHi.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSayHi.Font = new System.Drawing.Font("微軟正黑體", 20F, System.Drawing.FontStyle.Bold);
            this.btnSayHi.Location = new System.Drawing.Point(891, 379);
            this.btnSayHi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSayHi.Name = "btnSayHi";
            this.btnSayHi.Size = new System.Drawing.Size(160, 62);
            this.btnSayHi.TabIndex = 1;
            this.btnSayHi.Text = "Say Hi";
            this.btnSayHi.UseVisualStyleBackColor = false;
            this.btnSayHi.Click += new System.EventHandler(this.btnSayHi_Click);
            // 
            // txtChName
            // 
            this.txtChName.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtChName.Location = new System.Drawing.Point(891, 94);
            this.txtChName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtChName.Name = "txtChName";
            this.txtChName.Size = new System.Drawing.Size(159, 52);
            this.txtChName.TabIndex = 2;
            // 
            // labChName
            // 
            this.labChName.AutoSize = true;
            this.labChName.BackColor = System.Drawing.Color.Transparent;
            this.labChName.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labChName.ForeColor = System.Drawing.Color.White;
            this.labChName.Location = new System.Drawing.Point(703, 98);
            this.labChName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labChName.Name = "labChName";
            this.labChName.Size = new System.Drawing.Size(155, 43);
            this.labChName.TabIndex = 3;
            this.labChName.Text = "中文名字";
            // 
            // labEnName
            // 
            this.labEnName.AutoSize = true;
            this.labEnName.BackColor = System.Drawing.Color.Transparent;
            this.labEnName.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labEnName.ForeColor = System.Drawing.Color.White;
            this.labEnName.Location = new System.Drawing.Point(703, 171);
            this.labEnName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labEnName.Name = "labEnName";
            this.labEnName.Size = new System.Drawing.Size(155, 43);
            this.labEnName.TabIndex = 4;
            this.labEnName.Text = "英文名字";
            // 
            // labGender
            // 
            this.labGender.AutoSize = true;
            this.labGender.BackColor = System.Drawing.Color.Transparent;
            this.labGender.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labGender.ForeColor = System.Drawing.Color.White;
            this.labGender.Location = new System.Drawing.Point(703, 242);
            this.labGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labGender.Name = "labGender";
            this.labGender.Size = new System.Drawing.Size(87, 43);
            this.labGender.TabIndex = 5;
            this.labGender.Text = "性別";
            // 
            // labConstellation
            // 
            this.labConstellation.AutoSize = true;
            this.labConstellation.BackColor = System.Drawing.Color.Transparent;
            this.labConstellation.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labConstellation.ForeColor = System.Drawing.Color.White;
            this.labConstellation.Location = new System.Drawing.Point(703, 312);
            this.labConstellation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labConstellation.Name = "labConstellation";
            this.labConstellation.Size = new System.Drawing.Size(87, 43);
            this.labConstellation.TabIndex = 6;
            this.labConstellation.Text = "星座";
            // 
            // txtEnName
            // 
            this.txtEnName.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEnName.Location = new System.Drawing.Point(891, 168);
            this.txtEnName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEnName.Name = "txtEnName";
            this.txtEnName.Size = new System.Drawing.Size(159, 52);
            this.txtEnName.TabIndex = 7;
            // 
            // txtGender
            // 
            this.txtGender.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtGender.Location = new System.Drawing.Point(891, 239);
            this.txtGender.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(159, 52);
            this.txtGender.TabIndex = 8;
            // 
            // txtConstellation
            // 
            this.txtConstellation.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtConstellation.Location = new System.Drawing.Point(891, 309);
            this.txtConstellation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtConstellation.Name = "txtConstellation";
            this.txtConstellation.Size = new System.Drawing.Size(159, 52);
            this.txtConstellation.TabIndex = 9;
            // 
            // Hello
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.txtConstellation);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.txtEnName);
            this.Controls.Add(this.labConstellation);
            this.Controls.Add(this.labGender);
            this.Controls.Add(this.labEnName);
            this.Controls.Add(this.labChName);
            this.Controls.Add(this.txtChName);
            this.Controls.Add(this.btnSayHi);
            this.Controls.Add(this.btnSayHello);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Hello";
            this.Text = "Hello";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSayHello;
        private System.Windows.Forms.Button btnSayHi;
        private System.Windows.Forms.TextBox txtChName;
        private System.Windows.Forms.Label labChName;
        private System.Windows.Forms.Label labEnName;
        private System.Windows.Forms.Label labGender;
        private System.Windows.Forms.Label labConstellation;
        private System.Windows.Forms.TextBox txtEnName;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.TextBox txtConstellation;
    }
}