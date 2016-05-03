using System;

namespace DikUcgenKontroluConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double k1, k2, k3;
            string metin;

            Console.Write("1. Kenarı girin: ");
            k1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("2. Kenarı girin: ");
            k2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("3. Kenarı girin: ");
            k3 = Convert.ToDouble(Console.ReadLine());

            if (k1 * k1 == k2 * k2 + k3 * k3 ||
                k2 * k2 == k1 * k1 + k3 * k3 ||
                k3 * k3 == k2 * k2 + k1 * k1)
                metin = "Dik Üçgen";
            else
                metin = "Dik Üçgen Değil";

            Console.Write("\n" + metin + "\n\n");
        }
    }
}
