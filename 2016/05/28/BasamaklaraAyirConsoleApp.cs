using System;

namespace BasamaklaraAyirConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sayı gir: ");
            string sayi = Console.ReadLine(),
                   mesaj = "";

            if (sayi.Length == 5)
                for (int i = sayi.Length - 1, k = 1; i >= 0; i--, k++)
                    mesaj += k + ". basamak " + sayi[i] + "\n";
            else
                mesaj = "5 basamaklı sayı girin\n";

            Console.Write("\n" + mesaj + "\n");
        }
    }
}
//http://eodev.com/gorev/8739917
