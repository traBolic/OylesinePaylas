using System;

namespace SayininUssunuAlConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sayı: ");
            double x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Üs: ");
            int y = Convert.ToInt32(Console.ReadLine());

            double sonuc = 1;
            for (int i = 1; i <= y; i++)
            {
                sonuc *= x;
            }

            Console.WriteLine("Sonuç: " + sonuc);
        }
    }
}
