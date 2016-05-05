using System;
using System.Windows.Forms;

namespace _20intPozNegSayFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSay_Click(object sender, EventArgs e)
        {
            string[] sayilar = txtSayilar.Text.Split(' ');
            int i,
                poz = 0,
                neg = 0,
                sayi;

            for (i = 0; i < sayilar.Length; i++)
            {
                sayi = Convert.ToInt32(sayilar[i]);
                if (sayi < 0)
                    neg++;
                else
                    poz++;
            }

            txtPoz.Text = "" + neg;
            txtNeg.Text = "" + poz;
        }
    }
}
//http://eodev.com/gorev/8552180
