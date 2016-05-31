using System;

namespace KacTanePoz_NegConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int pozsay = 0,
                sayi;
            for (int i = 20; i > 0; i--)
            {
                Console.Write(i+". sayıyı gir: ");
                string deger = Console.ReadLine();
                if (deger != "")
                {
                    sayi = Convert.ToInt32(deger);
                    if (sayi >= 0)
                        pozsay++;
                }
                else
                    i++;
            }
            Console.WriteLine("\nGirdiğiniz sayılarda "+pozsay+" adet pozitif sayı vardır.\n\n");
        }
    }
}
//http://eodev.com/gorev/8757506
