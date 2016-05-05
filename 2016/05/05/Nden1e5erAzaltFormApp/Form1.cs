using System;
using System.Windows.Forms;

namespace Nden1e5erAzaltFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        decimal? oncekideger = null;
        private void nmrSayi_ValueChanged(object sender, EventArgs e)
        {
            decimal? deger = nmrSayi.Value;
            if (deger != null && oncekideger != deger)
            {
                Sonuc.Items.Clear();
                int sayi = Convert.ToInt32(deger);
                for (int i = sayi; i > 1; i -= 5)
                {
                    Sonuc.Items.Add(i + "");
                }
                oncekideger = deger;
            }
        }
    }
}
//http://eodev.com/gorev/8553416
