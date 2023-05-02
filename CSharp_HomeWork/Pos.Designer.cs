namespace CSharp_HomeWork
{
    partial class Pos
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
            this.labMenu = new System.Windows.Forms.Label();
            this.labTotalPrice = new System.Windows.Forms.Label();
            this.labPaymentMethod = new System.Windows.Forms.Label();
            this.labList = new System.Windows.Forms.Label();
            this.btnBeer = new System.Windows.Forms.Button();
            this.btnTequila = new System.Windows.Forms.Button();
            this.btnWhisky = new System.Windows.Forms.Button();
            this.btnWine = new System.Windows.Forms.Button();
            this.labShowPrice = new System.Windows.Forms.Label();
            this.labDiscount = new System.Windows.Forms.Label();
            this.btnPayCash = new System.Windows.Forms.Button();
            this.btnCard = new System.Windows.Forms.Button();
            this.labShowList = new System.Windows.Forms.Label();
            this.btnClearList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labMenu
            // 
            this.labMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labMenu.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labMenu.Location = new System.Drawing.Point(12, 65);
            this.labMenu.Name = "labMenu";
            this.labMenu.Size = new System.Drawing.Size(232, 321);
            this.labMenu.TabIndex = 0;
            this.labMenu.Text = "菜單 Menu";
            // 
            // labTotalPrice
            // 
            this.labTotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labTotalPrice.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labTotalPrice.Location = new System.Drawing.Point(261, 65);
            this.labTotalPrice.Name = "labTotalPrice";
            this.labTotalPrice.Size = new System.Drawing.Size(284, 116);
            this.labTotalPrice.TabIndex = 1;
            this.labTotalPrice.Text = "總金額 Total Price";
            // 
            // labPaymentMethod
            // 
            this.labPaymentMethod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labPaymentMethod.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labPaymentMethod.Location = new System.Drawing.Point(261, 243);
            this.labPaymentMethod.Name = "labPaymentMethod";
            this.labPaymentMethod.Size = new System.Drawing.Size(284, 115);
            this.labPaymentMethod.TabIndex = 2;
            this.labPaymentMethod.Text = "付款方式 Payment Method";
            // 
            // labList
            // 
            this.labList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labList.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labList.Location = new System.Drawing.Point(562, 65);
            this.labList.Name = "labList";
            this.labList.Size = new System.Drawing.Size(308, 321);
            this.labList.TabIndex = 3;
            this.labList.Text = "購物清單 List";
            // 
            // btnBeer
            // 
            this.btnBeer.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnBeer.Location = new System.Drawing.Point(30, 110);
            this.btnBeer.Name = "btnBeer";
            this.btnBeer.Size = new System.Drawing.Size(97, 118);
            this.btnBeer.TabIndex = 4;
            this.btnBeer.Text = "啤酒\r\nBeer\r\nNT120";
            this.btnBeer.UseVisualStyleBackColor = true;
            this.btnBeer.Click += new System.EventHandler(this.btnBeer_Click);
            // 
            // btnTequila
            // 
            this.btnTequila.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnTequila.Location = new System.Drawing.Point(133, 110);
            this.btnTequila.Name = "btnTequila";
            this.btnTequila.Size = new System.Drawing.Size(92, 118);
            this.btnTequila.TabIndex = 5;
            this.btnTequila.Text = "龍舌蘭\r\nTequila\r\nNT180\r\n";
            this.btnTequila.UseVisualStyleBackColor = true;
            this.btnTequila.Click += new System.EventHandler(this.btnTequila_Click);
            // 
            // btnWhisky
            // 
            this.btnWhisky.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnWhisky.Location = new System.Drawing.Point(30, 234);
            this.btnWhisky.Name = "btnWhisky";
            this.btnWhisky.Size = new System.Drawing.Size(97, 118);
            this.btnWhisky.TabIndex = 6;
            this.btnWhisky.Text = "威士忌\r\nWhisky\r\nNT350";
            this.btnWhisky.UseVisualStyleBackColor = true;
            this.btnWhisky.Click += new System.EventHandler(this.btnWhisky_Click);
            // 
            // btnWine
            // 
            this.btnWine.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnWine.Location = new System.Drawing.Point(133, 234);
            this.btnWine.Name = "btnWine";
            this.btnWine.Size = new System.Drawing.Size(92, 118);
            this.btnWine.TabIndex = 7;
            this.btnWine.Text = "紅酒\r\nWine\r\nNT320";
            this.btnWine.UseVisualStyleBackColor = true;
            this.btnWine.Click += new System.EventHandler(this.btnWine_Click);
            // 
            // labShowPrice
            // 
            this.labShowPrice.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labShowPrice.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labShowPrice.ForeColor = System.Drawing.Color.White;
            this.labShowPrice.Location = new System.Drawing.Point(274, 110);
            this.labShowPrice.Name = "labShowPrice";
            this.labShowPrice.Size = new System.Drawing.Size(250, 49);
            this.labShowPrice.TabIndex = 8;
            this.labShowPrice.Text = "NT$ 0";
            this.labShowPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labDiscount
            // 
            this.labDiscount.BackColor = System.Drawing.SystemColors.Control;
            this.labDiscount.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labDiscount.Location = new System.Drawing.Point(402, 333);
            this.labDiscount.Name = "labDiscount";
            this.labDiscount.Size = new System.Drawing.Size(138, 19);
            this.labDiscount.TabIndex = 9;
            this.labDiscount.Text = "信用卡享九折優惠";
            // 
            // btnPayCash
            // 
            this.btnPayCash.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPayCash.Location = new System.Drawing.Point(280, 277);
            this.btnPayCash.Name = "btnPayCash";
            this.btnPayCash.Size = new System.Drawing.Size(120, 53);
            this.btnPayCash.TabIndex = 10;
            this.btnPayCash.Text = "付現\r\nPay Cash";
            this.btnPayCash.UseVisualStyleBackColor = true;
            this.btnPayCash.Click += new System.EventHandler(this.btnPayCash_Click);
            // 
            // btnCard
            // 
            this.btnCard.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCard.Location = new System.Drawing.Point(406, 277);
            this.btnCard.Name = "btnCard";
            this.btnCard.Size = new System.Drawing.Size(118, 53);
            this.btnCard.TabIndex = 11;
            this.btnCard.Text = "刷卡\r\nCredit Card";
            this.btnCard.UseVisualStyleBackColor = true;
            this.btnCard.Click += new System.EventHandler(this.btnCard_Click);
            // 
            // labShowList
            // 
            this.labShowList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labShowList.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labShowList.Location = new System.Drawing.Point(573, 100);
            this.labShowList.Name = "labShowList";
            this.labShowList.Size = new System.Drawing.Size(284, 215);
            this.labShowList.TabIndex = 12;
            this.labShowList.Text = "尚未點餐";
            this.labShowList.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnClearList
            // 
            this.btnClearList.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClearList.Location = new System.Drawing.Point(767, 318);
            this.btnClearList.Name = "btnClearList";
            this.btnClearList.Size = new System.Drawing.Size(90, 58);
            this.btnClearList.TabIndex = 13;
            this.btnClearList.Text = "清除清單\r\nClear List";
            this.btnClearList.UseVisualStyleBackColor = true;
            this.btnClearList.Click += new System.EventHandler(this.btnClearList_Click);
            // 
            // Pos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 504);
            this.Controls.Add(this.btnClearList);
            this.Controls.Add(this.labShowList);
            this.Controls.Add(this.btnCard);
            this.Controls.Add(this.btnPayCash);
            this.Controls.Add(this.labDiscount);
            this.Controls.Add(this.labShowPrice);
            this.Controls.Add(this.btnWine);
            this.Controls.Add(this.btnWhisky);
            this.Controls.Add(this.btnTequila);
            this.Controls.Add(this.btnBeer);
            this.Controls.Add(this.labList);
            this.Controls.Add(this.labPaymentMethod);
            this.Controls.Add(this.labTotalPrice);
            this.Controls.Add(this.labMenu);
            this.Name = "Pos";
            this.Text = "Pos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labMenu;
        private System.Windows.Forms.Label labTotalPrice;
        private System.Windows.Forms.Label labPaymentMethod;
        private System.Windows.Forms.Label labList;
        private System.Windows.Forms.Button btnBeer;
        private System.Windows.Forms.Button btnTequila;
        private System.Windows.Forms.Button btnWhisky;
        private System.Windows.Forms.Button btnWine;
        private System.Windows.Forms.Label labShowPrice;
        private System.Windows.Forms.Label labDiscount;
        private System.Windows.Forms.Button btnPayCash;
        private System.Windows.Forms.Button btnCard;
        private System.Windows.Forms.Label labShowList;
        private System.Windows.Forms.Button btnClearList;
    }
}