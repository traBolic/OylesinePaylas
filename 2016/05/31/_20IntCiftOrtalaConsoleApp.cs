using System;

namespace _20IntCiftOrtalaConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double topla = .0,
                   t_ort,
                   i,
                   j = 0,
                   sayi;
            for (i = 0; i < 20; )
            {
                Console.Write((i + 1) + ". sayıyı gir: ");
                string deger = Console.ReadLine();
                if (deger != "")
                {
                    sayi = Convert.ToDouble(deger);
                    if (sayi % 2 == 0)
                    {
                        topla += sayi;
                        j++;
                    }
                    i++;
                }
            }
            t_ort = topla / j;
            Console.Write("\nGirilen çift sayıların ortalaması: " + t_ort.ToString("F1") + "\n\n");
        }
    }
}
//http://eodev.com/gorev/8760425
