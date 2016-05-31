using System;

namespace _0GirileneKadarSayiOrtalaConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double sayi,
                   topla=0,
                   t_ort,
                   i=.0;
            string deger="";
            while (true)
            {
                Console.Write((i+1)+". sayı gir: ");
                deger = Console.ReadLine();
                if (deger != "")
                {
                    sayi = Convert.ToDouble(deger);

                    if (sayi == 0)
                        break;
                    else
                    {
                        topla += sayi;
                        i++;
                    }
                }
            }
            t_ort =topla/i;

            Console.Write("\nSayıların ortalaması: " + t_ort + "\n\n");
        }
    }
}
//http://eodev.com/gorev/8760158
