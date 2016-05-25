using System;

namespace DikUcgenKontroluConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double k1, k2, k3;

            Console.Write("1. Kenarı girin: ");
            k1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("2. Kenarı girin: ");
            k2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("3. Kenarı girin: ");
            k3 = Convert.ToDouble(Console.ReadLine());

            Console.Write(islem(k1, k2, k3));
        }
        static private string islem(double a, double b, double c)
        {
            string metin;
            if (a * a == b * b + c * c ||
                b * b == a * a + c * c ||
                c * c == b * b + a * a)
                metin = "Dik Üçgen";
            else
                metin = "Dik Üçgen Değil";
            return "\n" + metin + "\n\n";
        }
    }
}
//http://eodev.com/gorev/8720757
