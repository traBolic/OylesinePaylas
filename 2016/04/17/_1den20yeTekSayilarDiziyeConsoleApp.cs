using System;
using System.Linq;

namespace _1den20yeTekSayilarDiziyeConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = new int[20];
            int sayi,
                i = 1;
            do
            {
                Console.Write(i + ". sayıyı gir: ");
                string deger = Console.ReadLine();
                if (deger != "" && deger.All(char.IsDigit))
                {
                    sayi = Convert.ToInt32(deger);
                    if (sayi % 2 == 1)
                    {
                        dizi[i - 1] = sayi;
                        Console.Write("dizi[" + (i - 1) + "] = " + dizi[i - 1] + "\n\n");
                        i++;
                    }
                    else
                        Console.Write("Gireceğin sayı tek olmalı. Tekrar ");
                }
                else
                    Console.Write("Sadece sayılara izin var. Tekrar ");
            } while (i <= 20);
        }
    }
}
