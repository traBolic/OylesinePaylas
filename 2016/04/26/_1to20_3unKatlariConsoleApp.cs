using System;

namespace _1to20_3unKatlariConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            do
            {
                i++;
                if (i % 3 != 0) continue;
                Console.WriteLine(i);
            } while (i < 20);
        }
    }
}
