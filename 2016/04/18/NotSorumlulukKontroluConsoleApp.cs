using System;

namespace NotSorumlulukKontroluConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Öğrencinin notunu girin: ");
            string metin = "";
            int not = Convert.ToInt32(Console.ReadLine());
            if (not < 50)
            {
                Console.Write("Öğrencinin sorumluluk sınavı notunu girin: ");
                int sorumluluk = Convert.ToInt32(Console.ReadLine());

                metin = sorumluluk < 50 ? "Başarısız" : "Başarılı";
            }
            else
                metin = "Başarılı";
            Console.WriteLine(metin);
        }
    }
}
