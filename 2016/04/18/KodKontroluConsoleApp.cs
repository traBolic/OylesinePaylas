using System;

namespace KodKontroluConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            a = 13;
            b = 6;
            if (a < 10)
            {
                Console.WriteLine(a++);
                if (b > 10)
                {
                    Console.WriteLine(++a);
                }
                else if (b > 5)
                {
                    b += a;
                    Console.WriteLine(b);
                }
            }
            else
            {
                a -= b;
                Console.WriteLine(a);
            }
            if (a > b)
            {
                b += 2;
                Console.WriteLine(b);
            }
            Console.ReadKey();
        }
    }
}
