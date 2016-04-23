using System;

namespace _2sayiKontrolEiseTekrarConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string deger;
            do
            {
                Console.Write("1. sayı: ");
                int sayi1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("2. sayı: ");
                int sayi2 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Sonuç: "+sayi1 + " + " + sayi2 + " = " + (sayi1 + sayi2)+

                "\n\nBaşka bir işlem yapmak istiyor musun? > ");
                deger = Console.ReadLine();
                Console.Write("\n\n");
            } while (deger == "e" || deger == "E");

            Console.WriteLine("İşleminiz sonlandı.");
        }
    }
}
