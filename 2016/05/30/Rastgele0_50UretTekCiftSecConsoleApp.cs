using System;

namespace Rastgele0_50UretTekCiftSecConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int?[] dizi = new int?[50],
                  tekler = new int?[50],
                  ciftler = new int?[50];
            Random rast = new Random();

            for (int i = 0; i < 50; i++)
            {
                dizi[i] = rast.Next(1, 50);
            }

            for (int i = 0, j = 0, k = 0; i < 50; i++)
            {
                if (dizi[i] % 2 == 1)
                {
                    tekler[j] = dizi[i];
                    j++;
                }
                else
                {
                    ciftler[k] = dizi[i];
                    k++;
                }
            }

            Console.Write("\nTekler : ");
            foreach (int? tek in tekler)
                if(tek!=null)
                    Console.Write(tek+", ");
            Console.Write("\n\nÇiftler : ");
            foreach (int? cift in ciftler)
                if (cift != null)
                    Console.Write(cift + ", ");
            Console.Write("\n\n\n");
        }
    }
}
//http://eodev.com/gorev/8746561
