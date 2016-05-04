using System;
using System.Windows.Forms;

namespace _20IntCiftOrtalaFormsApp
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
            int topla = 0,
                i,
                k = 0,
                sayi;

            for (i = 0; i < sayilar.Length; i++)
            {
                sayi = Convert.ToInt32(sayilar[i]);
                if (sayi % 2 == 0)
                {
                    topla += sayi;
                    k++;
                }
            }

            double ort = topla / Convert.ToDouble(k);
            sonuc.Text = "" + ort;
        }
    }
}
