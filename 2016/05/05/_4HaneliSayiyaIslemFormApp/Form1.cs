using System;
using System.Windows.Forms;

namespace _4HaneliSayiyaIslemFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string deger = textBox1.Text;
            if (deger.Length==4)
            {
                int sayi = Convert.ToInt32(deger);
                textBox2.Text = "" + ((((sayi % 1000) / 100) % 3) - (sayi % 10));
            }
            else
                textBox2.Text = "4 Haneli Sayı Gir";
        }
    }
}
//http://eodev.com/gorev/8546471
