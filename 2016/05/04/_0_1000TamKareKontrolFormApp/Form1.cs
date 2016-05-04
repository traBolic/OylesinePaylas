using System;
using System.Windows.Forms;

namespace _0_1000TamKareKontrolFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            int[] sayilar = new int[1000];
            for (int i = 0; i < 1000; i++)
            {
                if (i != 0 && i == (Convert.ToInt64(Math.Sqrt(i)) * Convert.ToInt64(Math.Sqrt(i))))
                {
                    sayilar[i] = i;
                    listView1.Items.Add(sayilar[i]+"");
                }
            }
        }
    }
}
