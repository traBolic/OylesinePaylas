using System;

namespace _20SayidanAsalOlanSecConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int?[] asal = new int?[20];
            int sayi, i = 0, k = 0;
            string deger;
            do
            {
                Console.Write((i + 1) + ". sayıyı girin: ");
                deger = Console.ReadLine();

                if (deger != "")
                {
                    sayi = Convert.ToInt32(deger);
                    for (int j = 2; j <= sayi; j++)
                    {
                        if (sayi % j == 0)
                            break;
                        if (j == sayi - 1)
                        {
                            asal[k] = sayi;
                            Console.Write(sayi + " diziye atıldı\n\n");
                            k++;
                            break;
                        }
                    }
                    i++;
                }
            } while (i < 20);
            Console.Clear();
            for (i = 0; i < asal.Length; i++)
            {
                if (asal[i] != null)
                    Console.Write("asal[" + i + "] = " + asal[i] + "\n\n");
            }
        }
    }
}
