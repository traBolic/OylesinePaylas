using System;
using System.Windows.Forms;

namespace BaklavaDilimiFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int boyut;
            boyut = Convert.ToInt32(textBox1.Text);
            label2.Text = "";
            for (int i = 1; i <= boyut; i++)
            {
                for (int g = boyut; g > i; g--)
                {
                    label2.Text += " ";
                }
                for (int j = 1; j <= i; j++)
                {
                    label2.Text += "* ";
                }
                label2.Text += "\r\n";
            }
            for (int k = 1; k <= boyut; k++)
            {
                for (int l = 1; l <= k; l++)
                {
                    label2.Text += " ";
                }
                for (int m = boyut; m > k; m--)
                {
                    label2.Text += "* ";
                }
                label2.Text += "\r\n";
            }
        }
    }
}
