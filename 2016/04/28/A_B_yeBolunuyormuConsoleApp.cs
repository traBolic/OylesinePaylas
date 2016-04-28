using System;

namespace A_B_yeBolunuyormuConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            if (a % b == 0)
                Console.WriteLine(a + " " + b + " sayısına tam bölünüyor");
            else
                Console.WriteLine(a + " " + b + " sayısına tam bölünmüyor");
        }
    }
}
