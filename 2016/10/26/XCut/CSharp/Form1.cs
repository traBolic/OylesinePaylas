using System;
using System.Windows.Forms;

namespace XKut
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int A = Convert.ToInt32(textBox1.Text),
                B = Convert.ToInt32(textBox2.Text),
                C = Convert.ToInt32(textBox3.Text);

            if (C >= 30)
            {
                double fakt = 1,
                    sonuc;

                for (int i = 1; i < A; i++)
                    fakt *= (double)i;

                sonuc = fakt + C / B;

                textBox4.Text = "" + sonuc;
            }
            else if (C < 30 && C > 0)
            {
                int toplam = 0;

                for (int i = 1; i < C; i++)
                    toplam += i * i;

                textBox4.Text = "" + toplam;
            }
            else if (C < 0)
            {
                int s = A;

                for (int i = 1; i < B; i++)
                    s *= A;

                textBox4.Text = "" + s;
            }
        }
    }
}
