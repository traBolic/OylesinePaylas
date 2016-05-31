using System;

namespace Nden5er5erAzaltYazConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sayı gir: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = n; i >=1; i -= 5)
            {
                Console.WriteLine(i);
            }
        }
    }
}
//http://eodev.com/gorev/8757460
