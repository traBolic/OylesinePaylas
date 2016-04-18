using System;

namespace DevamsizlikKontroluConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Öğrencinin devamsızlık sayısını girin: ");
            int devamsizlik = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(devamsizlik >= 10 ? "KALDI" : "GEÇTİ");
        }
    }
}
