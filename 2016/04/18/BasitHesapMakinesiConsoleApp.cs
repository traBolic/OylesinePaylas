using System;
using System.Data;

namespace BasitHesapMakinesiConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Örnek işlem biçimi: 2+2\n\nİşlem girin:");
            string deger = Console.ReadLine();

            if (deger != "" && deger.Length > 2)
            {
                DataTable dt = new DataTable();
                var hesapla = dt.Compute(deger, "");
                Console.Write("\nSonuç: " + hesapla + "\n\n");
            }
        }
    }
}
