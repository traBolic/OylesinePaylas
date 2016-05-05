using System;
using System.Windows.Forms;

namespace BolmeKullanmadanBolmeFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBol_Click(object sender, EventArgs e)
        {
            double a, b, bolum;

            a = Convert.ToDouble(txtSayi1.Text);
            b = Convert.ToDouble(txtSayi2.Text);

            for (bolum = 0; b > 0 && a - b >= 0; bolum++)
                a = a - b;

            txtBolum.Text = bolum + "";
            txtKalan.Text = a + "";
        }
    }
}
//http://eodev.com/gorev/8553203
