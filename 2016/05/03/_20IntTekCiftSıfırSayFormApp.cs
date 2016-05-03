using System;
using System.Windows.Forms;

namespace _20IntTekCiftSıfırSayFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string[] sayilar = txtSayilar.Text.Split(' ');
            int tek = 0,
                cift = 0,
                sifir = 0,
                i,
                sayi;

            for (i = 0; i < sayilar.Length; i++)
            {
                sayi = Convert.ToInt32(sayilar[i]);
                if (sayi == 0)
                    sifir++;
                if (sayi % 2 == 0)
                    cift++;
                else
                    tek++;
            }
            label2.Text = "Girilen sayılarda";
            sonuc.Text = sifir + " adet Sıfır\n" +
                         cift + " adet Çift\n" +
                         tek + " adet Tek";
            label3.Text = "var";
        }
    }
}
