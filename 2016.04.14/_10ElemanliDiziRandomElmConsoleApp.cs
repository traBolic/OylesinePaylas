using System;

namespace _10ElemanliDiziRandomElmConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = new int[10];
            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                dizi[i] = 2 * random.Next( 50 /2); // Rastgele 0 ile 50 arasında sayı üreterek diziye atayacaktır.

                Console.WriteLine((i + 1) + ". eleman = " + dizi[i]);
            }
        }
    }
}
