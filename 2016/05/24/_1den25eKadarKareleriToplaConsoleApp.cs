using System;

namespace _1den25eKadarKareleriToplaConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1, topla = 0;
            do
                topla += i * i;
            while ((++i) < 25);
            Console.WriteLine(topla);
        }
    }
}
//http://eodev.com/gorev/8714558 
