using System;
using System.Windows.Forms;

namespace HesapYap8542047FormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnArti.Click += new EventHandler(btn_Click);
            btnEksi.Click += new EventHandler(btn_Click);
            btnCarp.Click += new EventHandler(btn_Click);
            btnBol.Click += new EventHandler(btn_Click);
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string islem = Convert.ToString(btn.Text),
                   tSayi1 = txtSayi1.Text,
                   tSayi2 = txtSayi2.Text,
                   metin="Geçerli bir sayı girin";
            double? sayi1, sayi2, sonuc=null;

            if (tSayi1 != "" && tSayi2 != "")
            {
                sayi1 = Convert.ToDouble(tSayi1);
                sayi2 = Convert.ToDouble(tSayi2);
                metin = "";
                if (islem == "+")
                    sonuc = sayi1 + sayi2;
                if (islem == "-")
                    sonuc = sayi1 - sayi2;
                if (islem == "*")
                    sonuc = sayi1 * sayi2;
                if (islem == "/")
                    sonuc = sayi1 / sayi2;
            }
            txtSonuc.Text = metin + Convert.ToString(sonuc);
        }
    }
}
