using System;

namespace BasamaklardaSifirBulConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string deger = "";
            while (deger == "0" || deger == "")
            {
                Console.Write("Sayı gir: ");
                deger = Console.ReadLine();
                for (int i = deger.Length - 1, j = 0, k = 1; i >= 0 && j < 1 && deger != "0"; i--, k++)
                    if (deger[i] == '0')
                    {
                        j++;
                        Console.Write("\n" + k + ". basamak 0\n\n");
                    }
            }
        }
    }
}
//http://eodev.com/gorev/8578342
