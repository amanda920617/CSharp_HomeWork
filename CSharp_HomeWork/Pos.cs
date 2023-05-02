using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_HomeWork
{
    public partial class Pos : Form
    {
        public int TotalPrice=0, Beer=0, Tequila=0, Whisky=0, Wine=0;
        public Pos()
        {
            InitializeComponent();
        }
        private void btnBeer_Click(object sender, EventArgs e)
        {
            TotalPrice += 120;
            Beer++;
            ShowListPrice();
        }

        private void btnTequila_Click(object sender, EventArgs e)
        {
            TotalPrice += 180;
            Tequila++;
            ShowListPrice();
        }

        private void btnWhisky_Click(object sender, EventArgs e)
        {
            TotalPrice += 350;
            Whisky++;
            ShowListPrice();
        }

        private void btnWine_Click(object sender, EventArgs e)
        {
            TotalPrice += 320;
            Wine++;
            ShowListPrice();
        }

        private void ShowListPrice()
        {
            labShowPrice.Text = "NT$ " + TotalPrice;
            labShowList.Text = string.Empty;
            if (Beer != 0)
                labShowList.Text = "啤酒 Beer x " + Beer + ",共NT$ " + Beer * 120 + "\n";
            if (Tequila != 0)
                labShowList.Text += "龍舌蘭 Tequila x " + Tequila + ",共NT$ " + Tequila * 180 + "\n";
            if (Whisky != 0)
                labShowList.Text += "威士忌 Whisky x " + Whisky + ",共NT$ " + Whisky * 350 + "\n";
            if (Wine != 0)
                labShowList.Text += "紅酒 Wine x " + Wine + ",共NT$ " + Wine * 320 + "\n";
        }

        private void btnPayCash_Click(object sender, EventArgs e)
        {
            MessageBox.Show("總金額：NT$" + TotalPrice);
        }

        private void btnCard_Click(object sender, EventArgs e)
        {
            MessageBox.Show("總金額：NT$" + TotalPrice + "\n" + "折扣後金額：NT$" + TotalPrice * 0.9);
        }

        private void btnClearList_Click(object sender, EventArgs e)
        {
            TotalPrice = 0;
            Beer = 0;
            Tequila = 0;
            Whisky = 0;
            Wine = 0;
            labShowList.Text = "尚未點餐";
            labShowPrice.Text = "NT$ " + TotalPrice;
        }
    }
}
