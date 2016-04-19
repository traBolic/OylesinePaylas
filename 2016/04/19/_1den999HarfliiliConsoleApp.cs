using System;

namespace _1den999HarfliiliConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 999; i++)
            {
                string harfli = "";
                int y = i % 1000 / 100;
                harfli += y == 9 ? "DOKUZYÜZ " :
                          y == 8 ? "SEKİZYÜZ " :
                          y == 7 ? "YEDİYÜZ " :
                          y == 6 ? "ALTIYÜZ " :
                          y == 5 ? "BEŞYÜZ " :
                          y == 4 ? "DÖRTYÜZ " :
                          y == 3 ? "ÜÇYÜZ " :
                          y == 2 ? "İKİYÜZ " :
                          y == 1 ? "YÜZ " :
                          "";
                int o = i % 100 / 10;
                harfli += o == 9 ? "DOKSAN " :
                          o == 8 ? "SEKSEN " :
                          o == 7 ? "YETMİŞ " :
                          o == 6 ? "ALTMIŞ " :
                          o == 5 ? "ELLİ " :
                          o == 4 ? "KIRK " :
                          o == 3 ? "OTUZ " :
                          o == 2 ? "YİRMİ " :
                          o == 1 ? "ON " :
                          "";
                int b = i % 10;
                harfli += b == 9 ? "DOKUZ" :
                          b == 8 ? "SEKİZ" :
                          b == 7 ? "YEDİ" :
                          b == 6 ? "ALTI" :
                          b == 5 ? "BEŞ" :
                          b == 4 ? "DÖRT" :
                          b == 3 ? "ÜÇ" :
                          b == 2 ? "İKİ" :
                          b == 1 ? "BİR" :
                          "";
                if (i == 0)
                    Console.WriteLine("SIFIR");
                Console.Write(i+" "+harfli + "\n");
            }
        }
    }
}
