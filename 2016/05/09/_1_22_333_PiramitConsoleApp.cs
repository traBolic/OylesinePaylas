using System;

namespace _1_22_333_PiramitConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sayı gir: ");
            int x = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= x; i++)
            {
                for (int j = 0; j < i; j++)
                    Console.Write(i);
                Console.WriteLine();
            }
        }
    }
}
//http://eodev.com/gorev/8580273
