using System;
using System.Linq;

namespace RasgeleUret_3_5KatlariDiziyeConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Dizi boyutunu girin: ");
            int N = Convert.ToInt32(Console.ReadLine());
            if (N > 0)
            {
                Random uret = new Random();
                int[] dizi = new int[N];
                for (int i = 0; i < N - 1; i++)
                    dizi[i] = uret.Next(1, 50);

                foreach (var grup in dizi.GroupBy(v => v))
                    Console.WriteLine("Dizi içerisinde " + grup.Key + " " + grup.Count() + " adet var.");

                int[] _50 = new int[50];
                for (int i = 0; i < 50; i++)
                    if (dizi[i] > 0 && dizi[i] % 3 == 0)
                        _50[i] = dizi[i];
            }
        }
    }
}
//http://eodev.com/gorev/8745248
