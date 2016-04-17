using System;

namespace Girilen2SayidanBuyugunKaresiConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1, sayi2, buyuk, kare;

            Console.Write("1. sayıyı gir: ");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. sayıyı gir: ");
            sayi2 = Convert.ToInt32(Console.ReadLine());

            if (sayi1.ToString().Length > 0 && sayi2.ToString().Length > 0) // Eğer 1. sayı veya 2. sayı, numerik girilmişse
            {
                buyuk = (sayi1 > sayi2) ? sayi1 : sayi2;
                kare = buyuk * buyuk;
                Console.Write("\nBüyük olan " + buyuk + " sayısının karesi: " + kare + "\n\n");
            }
            else
            {
                Console.Write("Lütfen sayıları doğru girin");
            }
        }
    }
}
