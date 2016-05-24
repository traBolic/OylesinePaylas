using System;

namespace _0GirileneKadarToplaConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double sayi = 0,
                   topla = 0,
                   i = 0;

            for (; ; i++)
            {
                Console.Write("Sayı gir: ");
                sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi == 0)
                    break;
                Console.WriteLine(topla + "+" + sayi + " = " + (topla + sayi) + "\n");
                topla += sayi;
            }

            Console.Write("\n\n" + i + " adet sayı toplandı\nSonuç: " + topla + "\n\n");
        }
    }
}
//http://eodev.com/gorev/8712518
