using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3HakPinKoduConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int hak = 3;
            string dogruPin = "1234",
                iste = dogruPin;
            while (hak > 0)
            {
                hak--;
                Console.Write("Pin kodu girin: ");
                iste = Console.ReadLine();

                if ((iste == "" || iste != dogruPin) && hak != 0)
                {
                    Console.Write("\nLütfen pin kodunu doğru girin.\n\n" + hak + " hakkınız kaldı.\n");
                }
                else if (iste == dogruPin)
                {
                    Console.Write("\n\nHoşgeldiniz\n\n");
                    break;
                }
            }
            if (hak == 0 && iste != dogruPin)
                Console.Write("\n\nÇok hakıda hatalı girişten dolayı\nPin kodunuz bloke oldu.\n\n");
        }
    }
}
