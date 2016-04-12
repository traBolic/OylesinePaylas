using System;

namespace _20IntTekCiftSayConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int? tek = 0,
                cift = 0,
                sayi = null,
                i = 1;
            do
            {
                try
                {
                    Console.Write(i + ". sayı: ");
                    string deger = Console.ReadLine();
                    sayi = Convert.ToInt32(deger);
                    if (deger != "" && sayi != null)
                    {
                        i++;
                        if (sayi % 2 == 0)
                            cift++;
                        else
                            tek++;
                    }
                }
                catch { }
            } while (i <= 20);
            Console.Write("\n" + tek + " adet Tek\n" + cift + " adet Çift\n\n");
        }
    }
}


