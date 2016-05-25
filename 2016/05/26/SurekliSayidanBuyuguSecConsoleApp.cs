using System;

namespace SurekliSayidanBuyuguSecConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string devam = "e";
            int sayi, buyuk = int.MinValue;

            for (; devam == "e" || devam == "E"; )
            {
                Console.Write("Sayı gir: ");
                sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi > buyuk) buyuk = sayi;
                Console.Write("Devam etmek istiyor musun? [E/H]: ");
                devam = Console.ReadLine();
                Console.WriteLine();
            }
            Console.Write("\nGirilen büyük sayı: " + buyuk + "\n\n");
        }
    }
}
//http://eodev.com/gorev/8725002
