using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace CSharp_HomeWork
{
    public partial class Method : Form
    {
        public Method()
        {
            InitializeComponent();
        }

        private void btnNumberJudge_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNumber.Text,out int Number))
            {
                if (Number % 2 == 0)
                    labShowResult.Text = $"輸入的數 {Number} 為 偶數";
                else
                    labShowResult.Text = $"輸入的數 {Number} 為 奇數";
            }
            else
            {
                MessageBox.Show("請輸入整數");
                txtNumber.Clear();
                txtNumber.Focus();
            }
        }

        int[] array = new int[10] {11, 99, 22, 88, 33, 77, 44, 66, 55, 100};
        string result = "";

        private void btnNumbers_Click(object sender, EventArgs e)
        {
            int odd=0, even=0;
            for (int i = 0; i < 10; i++)
            {
                if (array[i] % 2 != 0)
                    odd++;
                else 
                    even++;
                result += $"{array[i].ToString()}, ";
            }
            result = result.Substring(0, result.Length - 2);
            labShowResult.Text = $"int陣列array[{result}]\n";
            labShowResult.Text += $"奇數共 {odd} 個\n";
            labShowResult.Text += $"偶數共 {even} 個";
            result = "";
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            int Max = array[0];
            for (int i = 0; i < 10; i++)
            {
                if (array[i] > Max)
                    Max = array[i];
                result += $"{array[i].ToString()}, ";
            }
            result = result.Substring(0, result.Length - 2);
            labShowResult.Text = $"int陣列array[{result}]\n";
            labShowResult.Text += $"最大值為 {Max}";
            result = "";
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            int Min = array[0];
            for (int i = 0; i < 10; i++)
            {
                if (array[i] < Min)
                    Min = array[i];
                result += $"{array[i].ToString()}, ";
            }
            result = result.Substring(0, result.Length - 2);
            labShowResult.Text = $"int陣列array[{result}]\n";
            labShowResult.Text += $"最小值為 {Min}";
            result = "";
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            int Sum = 0;
            for (int i = 0; i < 10; i++)
            {
                Sum += array[i];
                result += $"{array[i].ToString()}, ";
            }
            result = result.Substring(0, result.Length - 2);
            labShowResult.Text = $"int陣列array[{result}]\n";
            labShowResult.Text += $"加總為 {Sum}";
            result = "";
        }

        private void btnMaxMin_Click(object sender, EventArgs e)
        {
            int Max = array[0], Min = array[0];
            for (int i = 0; i < 10; i++)
            {
                if (array[i] > Max)
                    Max = array[i];
                if (array[i] < Min)
                    Min = array[i];
                result += $"{array[i].ToString()}, ";
            }
            result = result.Substring(0, result.Length - 2);
            labShowResult.Text = $"int陣列array[{result}]\n";
            labShowResult.Text += $"最大值為 {Max}\n";
            labShowResult.Text += $"最小值為 {Min}";
            result = "";
        }

        string[] str = new string[5] { "Amanda", "Mark", "Sabrina", "Amy", "James" };

        private void btnLongName_Click(object sender, EventArgs e)
        {
            string LongName = str[0];
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].Length > LongName.Length)
                    LongName = str[i];
                result += $"{str[i]}, ";
            }
            result = result.Substring(0, result.Length - 2);
            labShowResult.Text = $"string陣列str[{result}]\n";
            labShowResult.Text += $"最長的名字為 {LongName}";
            result = "";
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].Contains('M') || str[i].Contains('m'))
                    count++;
                result += $"{str[i]}, ";
            }
            result = result.Substring(0, result.Length - 2);
            labShowResult.Text = $"string陣列str[{result}]\n";
            labShowResult.Text += $"有'M'或'm'的名字共有 {count} 個";
            result = "";
        }

        int size = 10;

        private void btn10_Click(object sender, EventArgs e)
        {
            int[,] arr = new int[size,size];
            for(int i = 0; i < size; i++)
            {
                for(int j = 0; j < size; j++)
                {
                    if (i == size - 1 || i == 0 || j == size - 1 || j == 0)
                        arr[i,j] = 1;
                    else
                        arr[i, j] = 0;
                    result += $"{arr[i, j]} ";
                }
                result += "\n";
            }
            result = result.Substring(0, result.Length - 1);
            labShowResult.Text = $"{result}";
            result = "";
        }

        private void btn01_Click(object sender, EventArgs e)
        {
            int[,] arr = new int[size, size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (i == size - 1 || i == 0 || j == size - 1 || j == 0)
                        arr[i, j] = 0;
                    else
                        arr[i, j] = 1;
                    result += $"{arr[i, j]} ";
                }
                result += "\n";
            }
            result = result.Substring(0, result.Length - 1);
            labShowResult.Text = $"{result}";
            result = "";
        }

        private void btn1001_Click(object sender, EventArgs e)
        {
            int[,] arr = new int[size, size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if ((i % 2 == 0 && j % 2 == 0) || (i % 2 == 1 && j % 2 == 1))
                        arr[i, j] = 1;
                    else
                        arr[i, j] = 0;
                    result += $"{arr[i, j]} ";
                }
                result += "\n";
            }
            result = result.Substring(0, result.Length - 1);
            labShowResult.Text = $"{result}";
            result = "";
        }

        int n1 = 100, n2 = 50;

        private void btnSwap_Click(object sender, EventArgs e)
        {
            int temp;
            labShowResult.Text = $"換位前 n1 = {n1} , n2 = {n2}\n";
            temp = n1;
            n1 = n2;
            n2 = temp;
            labShowResult.Text += $"換位後 n1 =  {n1}  , n2 =  {n2} \n";
        }

        private void btnTree_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtInput.Text, out int Input))
            {
                for (int i = 1; i <= Input; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        result += "*";
                    }
                    result += "\n";
                }
                result = result.Substring(0, result.Length - 1);
                labShowResult.Text = $"{result}";
                result = "";
            }
            else
            {
                MessageBox.Show("請輸入整數");
                txtInput.Clear();
                txtInput.Focus();
            }
        }

        private void btnNineNineTable_Click(object sender, EventArgs e)
        {
            string Ans;
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    Ans = string.Format("{0,2}", (j * i));
                    result += $"{j} * {i} = {Ans} | ";
                }
                result += "\n";
            }
            labShowResult.Text = $"{result}";
            result = "";
        }

        private void btnBinary_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtInput.Text, out int Input))
            {
                while (Input > 0)
                {
                    result = result.Insert(0, (Input % 2).ToString());
                    Input /= 2;
                }
                labShowResult.Text = $"{result}";
                result = "";
            }
            else
            {
                MessageBox.Show("請輸入整數");
                txtInput.Clear();
                txtInput.Focus();
            }
        }

        private void btnRandomLotto_Click(object sender, EventArgs e)
        {
            int[] lotto = new int[6];
            Random random = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < 6; i++)
            {
                lotto[i] = random.Next(1, 50);
                for (int j = 0; j < i; j++)
                {
                    if (lotto[i] == lotto[j])
                    {
                        lotto[i] = random.Next(1, 50);
                        j = -1;
                    }
                }
                result += $"{lotto[i]}, ";
            }
            result = result.Substring(0, result.Length - 2);
            labShowResult.Text = $"樂透號碼\n{result}";
            result = "";
        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            if (!(int.TryParse(txtFrom.Text, out int From)))
            {
                MessageBox.Show("From 請輸入整數");
                txtFrom.Clear();
                txtFrom.Focus();
            }
            else if(!(int.TryParse(txtTo.Text, out int To)))
            {
                MessageBox.Show("To 請輸入整數");
                txtTo.Clear();
                txtTo.Focus();
            }
            else if (!(int.TryParse(txtStep.Text, out int Step)))
            {
                MessageBox.Show("Step 請輸入整數");
                txtStep.Clear();
                txtStep.Focus();
            }
            else
            {
                int Sum = 0;
                for (int i = From; i <= To; i += Step)
                    Sum += i;
                labShowResult.Text = $"For迴圈\n";
                labShowResult.Text += $"{From} 到 {To} 相隔 {Step}\n";
                labShowResult.Text += $"加總為 {Sum}"; 
            }
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            if (!(int.TryParse(txtFrom.Text, out int From)))
            {
                MessageBox.Show("From 請輸入整數");
                txtFrom.Clear();
                txtFrom.Focus();
            }
            else if (!(int.TryParse(txtTo.Text, out int To)))
            {
                MessageBox.Show("To 請輸入整數");
                txtTo.Clear();
                txtTo.Focus();
            }
            else if (!(int.TryParse(txtStep.Text, out int Step)))
            {
                MessageBox.Show("Step 請輸入整數");
                txtStep.Clear();
                txtStep.Focus();
            }
            else
            {
                int Sum = 0;
                int i = From;
                while (i <= To)
                {
                    Sum += i;
                    i += Step;
                }
                labShowResult.Text = $"While迴圈\n";
                labShowResult.Text += $"{From} 到 {To} 相隔 {Step}\n";
                labShowResult.Text += $"加總為 {Sum}";
            }
        }

        private void btnDoWhile_Click(object sender, EventArgs e)
        {
            if (!(int.TryParse(txtFrom.Text, out int From)))
            {
                MessageBox.Show("From 請輸入整數");
                txtFrom.Clear();
                txtFrom.Focus();
            }
            else if (!(int.TryParse(txtTo.Text, out int To)))
            {
                MessageBox.Show("To 請輸入整數");
                txtTo.Clear();
                txtTo.Focus();
            }
            else if (!(int.TryParse(txtStep.Text, out int Step)))
            {
                MessageBox.Show("Step 請輸入整數");
                txtStep.Clear();
                txtStep.Focus();
            }
            else
            {
                int Sum = 0;
                int i = From;
                do
                {
                    Sum += i;
                    i += Step;
                }
                while (i <= To);
                labShowResult.Text = $"Do While迴圈\n";
                labShowResult.Text += $"{From} 到 {To} 相隔 {Step}\n";
                labShowResult.Text += $"加總為 {Sum}";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            labShowResult.Text = "結果";
        }
    }
}
