using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool isFirst = false;
        bool isEqLast = false;
        double s1 = 0, s2 = 0;
        char islem = ' ';
        char[] islemler = new char[] { '+', '-', '*', '/', '=' };

        private void btnIslem(object sender, EventArgs e)
        {
            Button tiklanan = sender as Button;
            if (islem != ' ') Hesapla(tiklanan.Text);
            islemSec(tiklanan.Text);
        }

        private void islemSec(string text)
        {
            isEqLast = false;
            if (islem == ' ') s1 = Convert.ToDouble(txtDisplay.Text);

            switch (text)
            {
                case "+": islem = '+'; break;
                case "-": islem = '-'; break;
                case "x":
                case "*": islem = '*'; break;
                case "÷":
                case "/": islem = '/'; break;

                default: isEqLast = true; break;
            }
            isFirst = true;
        }

        private void Hesapla(string sonrakiIslem)
        {
            if (!isEqLast) s2 = Convert.ToDouble(txtDisplay.Text);
            if (!isFirst || sonrakiIslem == "=")
            {
                switch (islem)
                {
                    case '+': s1 += s2; break;
                    case '-': s1 -= s2; break;
                    case '*': s1 *= s2; break;
                    case '/': s1 /= s2; break;
                }
            }
            txtDisplay.Text = s1.ToString();

        }

        private void btnC_Click(object sender, EventArgs e)
        {
            
            txtDisplay.Text = "0";
            isFirst = isEqLast = false;
            s1 = s2 = 0;
            islem = ' ';
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DeleteToDisplay();
        }

        private void DeleteToDisplay()
        {
            if (txtDisplay.Text.Length > 1)
            {
                txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);
            }
            else
            {
                txtDisplay.Text = "0";
            }
        }

        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {
            if (txtDisplay.Text == ",")
            {
                txtDisplay.Text = "0,";
            }
            
        }

        private void KlavyedenBasilan(object sender, KeyPressEventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "";
            }

            
            if (isFirst && islem != ' ') txtDisplay.Text = "0";    
            

            if (!char.IsNumber(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != (int)Keys.Back && !islemler.Contains(e.KeyChar) || (e.KeyChar == ',' && txtDisplay.Text.Contains(',')))
            {
                e.Handled = true;
            }
            else if (islemler.Contains(e.KeyChar))
            {
                islemSec(e.KeyChar.ToString());
            }
            else if (e.KeyChar == (int)Keys.Back)
            {
                DeleteToDisplay();
            }
            else
            {
                WriteToDisplay(e.KeyChar.ToString());
            }

        }

        private void btnNumPad(object sender, EventArgs e)
        {
            Button tiklanan = sender as Button;

            WriteToDisplay(tiklanan.Text);
        }

        private void WriteToDisplay(string basilacak)
        {
            if (basilacak == "," && txtDisplay.Text.Contains(",")) return;

            if (txtDisplay.Text == "0" && basilacak != ",") txtDisplay.Text = "";
            if (isFirst && islem != ' ') txtDisplay.Text = "";

            txtDisplay.Text += basilacak;
            isFirst = false;
        }
    }
}
