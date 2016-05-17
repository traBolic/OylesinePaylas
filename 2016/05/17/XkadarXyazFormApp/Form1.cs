using System;
using System.Windows.Forms;

namespace XkadarXyazFormApp
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
            decimal sayi = nmrSayi.Value,
                    i,j;
            string deger = "";
            if (sayi != oncekideger)
            {
                listSonuc.Items.Clear();
                for (i = 0; i < sayi; i++)
                {
                    for (j = 0; j < i; j++)
                        deger += "" + i;
                    listSonuc.Items.Add(deger);
                    deger = "";
                }
                oncekideger = sayi;
            }
        }
    }
}

//http://eodev.com/gorev/8654512
