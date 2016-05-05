using System;
using System.Windows.Forms;

namespace _0_100ArasiTamKareFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i < 100; i++)
                if (i != 0 && i == Convert.ToInt64(Math.Sqrt(i)) * Convert.ToInt64(Math.Sqrt(i)))
                    listSayilar.Items.Add(i + "");
        }
    }
}
//http://eodev.com/gorev/8560341
