using System;
using System.Windows.Forms;

namespace _2Ara1FinalHesaplaFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            string t1Ara = txt1Ara.Text,
                   t2Ara = txt2Ara.Text,
                   tFinal = txtFinal.Text;
            if (t1Ara == "")
                txtSonuc.Text = "1. Ara sınavı notu girin";
            else if (t2Ara == "")
                txtSonuc.Text = "2. Ara sınavı notu girin";
            else if (tFinal == "")
                txtSonuc.Text = "Final sınavı notu girin";
            else
            {
                int i1Ara = Convert.ToInt32(t1Ara),
                    i2Ara = Convert.ToInt32(t2Ara),
                    iFinal = Convert.ToInt32(tFinal),
                    sonuc = (i1Ara * 20 / 100) + (i2Ara * 30 / 100) + (iFinal * 50 / 100);
                txtSonuc.Text = "" + sonuc;
            }
        }
    }
}
//http://eodev.com/gorev/8532589
