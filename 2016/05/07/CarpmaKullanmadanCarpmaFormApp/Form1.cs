using System;
using System.Windows.Forms;

namespace CarpmaKullanmadanCarpmaFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCarp_Click(object sender, EventArgs e)
        {
            string tSayi1 = txtSayi1.Text,
                   tSayi2 = txtSayi2.Text;

            if (tSayi1 != "" && tSayi2 != "")
            {
                double sayi1 = Convert.ToDouble(tSayi1),
                       sayi2 = Convert.ToDouble(tSayi2),
                       topla = 0;

                for (; sayi2 > 0; sayi2--)
                    topla += sayi1;

                txtSonuc.Text = "" + topla;
            }
        }
    }
}
//http://eodev.com/gorev/8569029
