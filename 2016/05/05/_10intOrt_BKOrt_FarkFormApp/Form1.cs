using System;
using System.Windows.Forms;

namespace _10intOrt_BKOrt_FarkFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            string[] sayilar = txtSayilar.Text.Split(' ');
            if (sayilar.Length == 10)
            {
                double tOrt,
                       bkOrt;
                int i,
                    topla = 0,
                    buyuk = Convert.ToInt32(sayilar[0]),
                    kucuk = buyuk,
                    sayi;

                for (i = 0; i < sayilar.Length; i++)
                {
                    sayi = Convert.ToInt32(sayilar[i]);
                    topla += sayi;
                    if (sayi > buyuk)
                        buyuk = sayi;
                    if (sayi < kucuk)
                        kucuk = sayi;
                }

                tOrt = topla / Convert.ToDouble(sayilar.Length);
                bkOrt = (buyuk + kucuk) / 2.0;

                txtSonuc.Text = "" + (tOrt - bkOrt);
            }
            else
                txtSonuc.Text = "10 sayı olmalı!";
        }
    }
}
//http://eodev.com/gorev/8552298
