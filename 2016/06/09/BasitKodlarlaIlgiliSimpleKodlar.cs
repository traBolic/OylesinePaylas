using System;

namespace BasitKodlarlaIlgiliSimpleKodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Merhaba Dünya");
            Console.WriteLine("Günaydın");

            int a = 1,
                b = 5;
            Console.WriteLine("Sonuç: " + (a + b));

            Console.Write("İsim gir: ");
            string deger = Console.ReadLine();
            Console.WriteLine("Bugün nasılsın " + deger + "\n");
        }
    }
}
