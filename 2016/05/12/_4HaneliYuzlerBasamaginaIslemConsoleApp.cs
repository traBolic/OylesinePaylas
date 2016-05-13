using System;

namespace _4HaneliYuzlerBasamaginaIslemConsoleApp
{
    class Program
    {
        private static void Hesapla()
        {
            Console.Write("Sayı gir: ");
            string deger = Console.ReadLine();
            if (deger.Length == 4)
            {
                int sayi = Convert.ToInt32(deger);
                deger = "" + ((((sayi % 1000) / 100) % 3) - (sayi % 10));
            }
            else
                deger = "4 Haneli Sayı Gir";
            Console.Write("\n" + deger + "\n\n");
        }
        static void Main(string[] args)
        {
            Hesapla();
        }
    }
}
//http://eodev.com/gorev/8622676
