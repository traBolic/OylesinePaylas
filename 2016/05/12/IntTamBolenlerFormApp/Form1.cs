using System;
using System.Windows.Forms;

namespace IntTamBolenlerFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        decimal oncekiDeger;
        private void button1_Click(object sender, EventArgs e)
        {
            decimal sayi = numSayi.Value;
            if (oncekiDeger != sayi)
            {
                listSayilar.Items.Clear();
                for (decimal i = 1; i <= sayi; i++)
                    if (sayi % i == 0)
                        listSayilar.Items.Add(i + "");
                oncekiDeger = sayi;
            }
        }
    }
}

//http://eodev.com/gorev/8614399
