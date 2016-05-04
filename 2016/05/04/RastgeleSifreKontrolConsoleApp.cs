using System;

namespace RastgeleSifreKontrolConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int uret = new Random().Next(1, 1000);
            int deger=0,i;

            for (i = 0; i < 5 && deger != uret; i++)
            {
                Console.Write("Pin girin: ");
                deger = Convert.ToInt32(Console.ReadLine());
            }

            if (deger == uret)
                Console.WriteLine("Başarılı giriş.");
            else
                Console.WriteLine("5 kere başarısız giriş.");
        }
    }
}
