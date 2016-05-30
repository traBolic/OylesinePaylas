using System;

namespace eE_GireneKadarYazConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            char tus = '\0';
            while (tus != 'e' && tus != 'E')
            {
                while (!Console.KeyAvailable)
                    Console.Write("ismet\n");

                tus = Console.ReadKey(true).KeyChar;
            }
        }
    }
}
//http://eodev.com/gorev/8751546
