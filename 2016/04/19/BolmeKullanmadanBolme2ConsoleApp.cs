using System;

namespace BolmeKullanmadanBolme2ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, bolum;

            Console.Write("A: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("B: ");
            b = Convert.ToInt32(Console.ReadLine());

            for (bolum = 0; b > 0 && a - b >= 0; bolum++)
            {
                a = a - b;
            }

            
            Console.Write("Bölüm=");
            Console.WriteLine(bolum);

            Console.Write("Kalan=");
            Console.WriteLine(a);

            Console.ReadKey();
        }
    }
}
