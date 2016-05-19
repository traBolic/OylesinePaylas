using System;
using System.Windows.Forms;
using System.Linq;

namespace _20IntBuyukKucukBulFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnBul_Click(object sender, EventArgs e)
        {
            // 1. yol
            int i=0;
            int[] sayilar = (from s in txtSayilar.Text.Split(' ') where int.TryParse(s, out i) select i).ToArray();
            Array.Sort(sayilar);

            txtKucuk.Text = "" + sayilar[0];
            txtBuyuk.Text = "" + sayilar.Last();

            //2. yol
            string[] sayilar2 = txtSayilar.Text.Split(' ');
            int buyuk = Convert.ToInt32(sayilar2[0]),
                kucuk = buyuk,
                sayi;

            foreach (string item in sayilar2)
            {
                sayi = Convert.ToInt32(item);
                if (sayi > buyuk)
                    buyuk = sayi;
                if (sayi < kucuk)
                    kucuk = sayi;
            }
            txtKucuk.Text = "" + kucuk;
            txtBuyuk.Text = "" + buyuk;
        }
    }
}

//http://eodev.com/gorev/8614289
