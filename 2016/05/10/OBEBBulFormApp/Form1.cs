using System;
using System.Windows.Forms;

namespace OBEBBulFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOBEB_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(nmrSayi1.Value),
                sayi2 = Convert.ToInt32(nmrSayi2.Value),
                obeb = 1;

            for (int i = 1; i <= sayi1 && i <= sayi2; i++)
                if (sayi2 % i == 0 && sayi1 % i == 0)
                    obeb = i;

            txtSonuc.Text = "" + obeb;
        }
    }
}
//http://eodev.com/gorev/8553229
