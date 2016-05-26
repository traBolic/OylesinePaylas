using System;
using System.Windows.Forms;

namespace _10OgrdenAdiEnUzunOgrenciyiSecFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            string[] ogrenciler = txtOgrenciler.Text.Split(new string[] { "\n", "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            string mesaj = "";
            if (ogrenciler.Length == 10)
            {
                int buyuk = 0;
                for (int i = 0; i < 10; i++)
                    if (ogrenciler[i].Length > buyuk)
                        buyuk = i;
                mesaj = ogrenciler[buyuk];
            }
            else
                mesaj = "10 öğrenci olmalı";
            txtSonuc.Text = mesaj;
        }
    }
}
//http://eodev.com/gorev/8726293
