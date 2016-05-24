using System;

namespace _5IntBasamakGosterConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sayı gir: ");
            string deger = Console.ReadLine(), sonuc;
            if (deger.Length == 5)
            {
                int sayi = Convert.ToInt32(deger);
                sonuc = "Birler   = " + sayi % 10 +
                        "\nOnlar    = " + (sayi % 100) / 10 +
                        "\nYuzler   = " + (sayi % 1000) / 100 +
                        "\nBinler   = " + (sayi % 10000) / 1000 +
                        "\nOnbinler = " + (sayi % 100000) / 10000;

            }
            else
                sonuc = "5 haneli sayı girin";
            Console.Write("\n" + sonuc + "\n\n");
        }
    }
}
//http://eodev.com/gorev/8709873
