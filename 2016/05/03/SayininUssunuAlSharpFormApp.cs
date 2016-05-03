using System;
using System.Windows.Forms;

namespace SayininUssunuAlSharpFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sonuc = 1;
            int X = Convert.ToInt32(txtX.Text),
                i = Convert.ToInt32(txti.Text),
                k;
            for (k = 1; k <= i; k++)
            {
                sonuc *= X;
            }
            txtSonuc.Text = "Sonuç:   " + X + "^" + i + " = " + sonuc;
        }
    }
}
