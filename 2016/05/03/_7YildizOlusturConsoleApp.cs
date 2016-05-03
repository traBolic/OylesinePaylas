using System;

namespace _7YildizOlusturConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int boyut = 7;

            Console.Write(" Ödev 1\n");
            for (int i = boyut; i >= 1; i--)
            {
                for (int k = 1; k <= i; k++)
                    Console.Write("*");
                Console.WriteLine();
            }

            Console.Write("\n Ödev 2\n");
            for (int i = boyut; i >= 1; i--)
            {
                for (int j = 1; j <= boyut - i; j++)
                    Console.Write(" ");
                for (int k = 1; k <= i; k++)
                    Console.Write("*");
                Console.WriteLine();
            }

            Console.Write("\n Ödev 3\n");
            for (int i = 1; i <= boyut; i++)
            {
                for (int j = 1; j <= boyut - i; j++)
                    Console.Write(" ");
                for (int k = 1; k <= i; k++)
                    Console.Write("*");
                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}
