using System;

namespace _10IntBulBuyukKucukOrtalaConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int buyuk = int.MinValue,
                kucuk = int.MaxValue,
                topla = 0;
            double t_ort,
                   b_k_ort;

            for (int i = 10; i > 0; i--)
            {
                Console.Write(i + ". sayıyı gir: ");
                string deger = Console.ReadLine();

                if (deger != "")
                {
                    int sayi = Convert.ToInt32(deger);
                    if (sayi > buyuk)
                        buyuk = sayi;
                    if (sayi < kucuk)
                        kucuk = sayi;
                    topla += sayi;
                }
                else
                    i++;
            }
            t_ort = topla / 10.0;
            b_k_ort = (buyuk + kucuk) / 2.0;
            Console.WriteLine("\nGirilen sayıların ortalması: " + t_ort +
                              "\nEn küçük sayı: " + kucuk +
                              "\nEn büyük sayı: " + buyuk +
                              "\nBu sayıların ortalaması: " + b_k_ort +
                              "\nBu sayıların farkı: " + (t_ort - b_k_ort).ToString("F1") + "\n\n");
        }
    }
}
//http://eodev.com/gorev/8757470
