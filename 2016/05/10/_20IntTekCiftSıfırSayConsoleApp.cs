using System;

namespace _20IntTekCiftSıfırSayConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int tek = 0,
                cift = 0,
                sifir = 0,
                sayi = 0;
            for (int i = 1; i <= 20; i++)
            {
                Console.Write(i + ". sayı: ");
                sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi == 0)
                    sifir++;
                if (sayi % 2 == 0)
                    cift++;
                else
                    tek++;
            }
            Console.Write("\n" + sifir + " adet Sıfır\n" +
                                  cift + " adet Çift\n" +
                                   tek + " adet Tek\n\n");
        }
    }
}

//http://eodev.com/gorev/8593286
