using System;

namespace NotKontroluConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int not = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(not < 50 ? "BAŞARISIZ" : "BAŞARILI");
        }
    }
}
