using System;

namespace EnUzumIsmiBulConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            string[] ogrenciler = new string[10];

            do
            {
                Console.Write((i + 1) + ". Öğrenci: ");
                string deger = Console.ReadLine();
                if (deger != "")
                {
                    ogrenciler[i] = deger;
                    i++;
                }
            } while (i < ogrenciler.Length);

            Console.WriteLine();

            // 1. yol
            Array.Sort(ogrenciler, (x, y) => x.Length.CompareTo(y.Length));
            Console.WriteLine("Uzun isim: " + ogrenciler[ogrenciler.Length - 1]);

            // 2. yol
            int uzun = 0;
            for (i = 0; i < ogrenciler.Length; i++)
                if (ogrenciler[i].Length > ogrenciler[uzun].Length)
                    uzun = i;

            Console.Write("Uzun isim: " + ogrenciler[uzun] + "\n\n");
        }
    }
}
//http://eodev.com/gorev/8710322
