using System;
using System.Windows.Forms;

namespace OrtasiniBulFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(numSayi1.Value),
                sayi2 = Convert.ToInt32(numSayi2.Value),
                sayi3 = Convert.ToInt32(numSayi3.Value),
                orta = 0;

            // 1. Yol - Dizi sıralama  -  yapımı.
            int[] dizi = { sayi1, sayi2, sayi3 };
            Array.Sort(dizi);
            orta = dizi[1];
            //------------------------------------

            // 2. Yol - Max ve Min fonksiyonları  -  yapımı
            orta = Math.Max(Math.Min(sayi1, sayi2), Math.Min(Math.Max(sayi1, sayi2), sayi3));
            //------------------------------------

            // 3. Yol  - İç içe koşullar ile if kullanarak
            orta = sayi3;
            if ((sayi2 < sayi1 && sayi1 < sayi3) || (sayi2 > sayi1 && sayi1 > sayi3))
                orta = sayi1;

            if ((sayi1 < sayi2 && sayi2 < sayi3) || (sayi1 > sayi2 && sayi2 > sayi3))
                orta = sayi2;
            //------------------------------------

            // 4. Yol  - Koşulları adım adım yazıp, if kullanarak.
            if (sayi1 >= sayi2)
                if (sayi1 >= sayi3)
                    if (sayi2 >= sayi3)
                        orta = sayi2;
                    else
                        orta = sayi3;
                else
                    orta = sayi1;
            else
                if (sayi2 >= sayi3)
                    if (sayi1 >= sayi3)
                        orta = sayi1;
                    else
                        orta = sayi3;
                else
                    orta = sayi2;
            //------------------------------------

            txtSonuc.Text = "" + orta;
        }
    }
}
//http://eodev.com/gorev/8593042
