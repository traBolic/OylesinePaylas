using System;
using System.Windows.Forms;

namespace N_FaktorBulFormApp
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
                int sayi = Convert.ToInt32(deger);
                double mfak = 1;
                for (int i = 1; i <= sayi; i++)
                {
                    mfak *= Convert.ToDouble(i);
                }
                Sonuc.Text = "" + mfak;
            }
        }
    }
}
//http://eodev.com/gorev/8553450
