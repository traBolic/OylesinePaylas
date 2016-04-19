using System;

namespace Topla5ve5inKatlarıConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("For ile");
            int topla = 0;
            for (int i = 0; i <= 100; i += 5)
            {
                topla += i;
            }
            Console.WriteLine(topla);

            Console.WriteLine("\nWhile ile");
            topla = 0;
            int j = 0;
            while ((j += 5) <= 100)
            {
                topla += j;
            }
            Console.WriteLine(topla+"\n");
        }
    }
}
