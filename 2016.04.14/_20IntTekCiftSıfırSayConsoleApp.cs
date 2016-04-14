using System;

namespace _20IntTekCiftSıfırSayConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int tek = 0,
                cift = 0,
                sifir = 0,
                sayi,
                i = 1;
            do
            {
                try // Sayı yerine harf girilirse, program hata vermemesi için var
                {
                    Console.Write(i + ". sayı: ");
                    sayi = Convert.ToInt32(Console.ReadLine());
                    if (sayi != null)
                    {
                        i++;
                        if (sayi == 0)
                            sifir++;
                        if (sayi % 2 == 0)
                            cift++;
                        else
                            tek++;
                    }
                }
                catch { }
            } while (i <= 20);
            Console.Write("\n" + sifir + " adet Sıfır\n" +
                                  cift + " adet Çift\n" +
                                   tek + " adet Tek\n\n");
        }
    }
}
