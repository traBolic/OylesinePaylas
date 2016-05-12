using System;

namespace _2sayiHesaplaOperatorleConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1. Sayı: ");
            double s1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("2. Sayı: ");
            double? s2 = Convert.ToDouble(Console.ReadLine()),
                    sonuc;

            Console.Write("\nİşlem ( + - * / ): ");
            String o = Console.ReadLine();

            sonuc = (o == "+" ? s1 + s2 :
                     o == "-" ? s1 - s2 :
                     o == "*" ? s1 * s2 :
                     o == "/" ? s1 / s2 :
                     null);

            Console.Write("\n" + (sonuc != null ? "Sonuç: " + sonuc : "Hatalı operatör seçimi") + "\n\n");
        }
    }
}
//http://eodev.com/gorev/8613173
