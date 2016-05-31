using System;

namespace _20IntTekCiftSifirSayConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int sifir = 0,
                tek = 0,
                cift = 0;
            for (int i = 0; i < 20; i++)
            {
                Console.Write((i+1)+". sayıyı gir: ");
                string deger = Console.ReadLine();
                if (deger != "")
                {
                    int sayi = Convert.ToInt32(deger);
                    if (sayi == 0)
                        sifir++;
                    if (sayi % 2 == 0)
                        cift++;
                    if (sayi % 2 == 1)
                        tek++;
                }
                else
                    i--;
            }
            Console.Write("\nGirilen sayılarda: " + sifir + " adet sıfır," +
                          "\n\t\t   " + cift + " adet çift," +
                          "\n\t\t   " + tek + " adet tek vardır.\n\n");
        }
    }
}
//http://eodev.com/gorev/8760119
