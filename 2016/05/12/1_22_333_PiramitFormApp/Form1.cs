using System;
using System.Windows.Forms;

namespace _1_22_333_PiramitFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            decimal x = numSayi.Value,
                    i, j;
            string metin="";
            for (i = 1; i <= x; i++)
            {
                for (j = 0; j < i; j++)
                    metin += i;
                listSayilar.Items.Add(metin);
                metin = "";
            }
        }
    }
}

//http://eodev.com/gorev/8580273
