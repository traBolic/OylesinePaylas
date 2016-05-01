using System;

namespace YildizOlusturConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int boyut = 5;

            Console.Write(" 1. Resimdeki soru\n");
            for (int i = 1; i <= boyut; i++)
            {
                for (int j = 1; j <= boyut - i; j++)
                    Console.Write(" ");
                for (int k = 1; k <= i; k++)
                    Console.Write("*");
                Console.WriteLine();

            }

            Console.Write("\n 2. Resimdeki soru\n");
            for (int i = boyut; i >= 1; i--)
            {
                for (int j = 1; j <= boyut - i; j++)
                    Console.Write(" ");
                for (int k = 1; k <= i; k++)
                    Console.Write("*");
                Console.WriteLine();
            }
        }
    }
}
