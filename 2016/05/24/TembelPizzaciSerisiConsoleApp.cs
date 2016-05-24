using System;

namespace TembelPizzaciSerisiConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0, topla = 0;
            do
                topla += ((i * i) + i + 2) / 2;
            while ((++i) < 100);

            Console.WriteLine(topla);
        }
    }
}
//http://eodev.com/gorev/8714516
