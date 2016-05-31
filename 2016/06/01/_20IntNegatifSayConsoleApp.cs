using System;

namespace _20IntNegatifSayConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int say=0;
            for (int i = 0; i < 20; i++)
            {
                Console.Write((i+1)+". sayıyı gir: ");
                string deger = Console.ReadLine();
                if (deger != "")
                {
                    double sayi=Convert.ToDouble(deger);;
                    if (sayi < 0)
                        say++;
                }
                else
                    i--;
            }
            Console.Write("\nGirilen sayılarda "+say+" adet negatif sayı vardır\n\n");
        }
    }
}
//http://eodev.com/gorev/8759994
