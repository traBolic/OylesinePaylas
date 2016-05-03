using System;

namespace SayininUssunuAlConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sayı: ");
            double X = Convert.ToInt32(Console.ReadLine());
            Console.Write("Üs: ");
            int i = Convert.ToInt32(Console.ReadLine());

            double sonuc = 1;
            for (int k = 1; k <= i; k++)
            {
                sonuc *= X;
            }

            Console.Write("\nSonuç:   " + X + "^" + i + " = " + sonuc + "\n\n");
        }
    }
}
