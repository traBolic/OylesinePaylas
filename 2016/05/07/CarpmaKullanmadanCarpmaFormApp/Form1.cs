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
                double sayi1 = Convert.ToInt32(tSayi1),
                       sayi2 = Convert.ToInt32(tSayi2),
                       topla=0;
                for (int i = 1; i <=sayi2; i++)
                {
                    topla += sayi1;
                }
                txtSonuc.Text = "" + topla;
            }
        }
    }
}
//http://eodev.com/gorev/8569029
