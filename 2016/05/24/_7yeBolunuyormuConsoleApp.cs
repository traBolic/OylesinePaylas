using System;

namespace _7yeBolunuyormuConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sayır gir: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi % 7 == 0)
                Console.WriteLine("Bölünüyor");
            else
                Console.WriteLine("Bölünmüyor");
        }
    }
}
//http://eodev.com/gorev/8709823
