using System;

namespace A_Z_Z_A_YazConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            for (char c = 'A'; c <= 'Z'; c++)
                Console.Write(c + " ");

            Console.WriteLine("\n-----");

            for (char c = 'Z'; c >= 'A'; c--)
                Console.WriteLine("  " + c);
        }
    }
}
//http://eodev.com/gorev/8565435
