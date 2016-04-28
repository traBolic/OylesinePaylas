using System;

namespace RandomuTahminEtConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0, uret, say = 0;
            int[] sayilar = new int[6];
            Console.Write("1 ile 49 arasında\n");
            do
            {
                Console.Write((i + 1) + ". sayıyı girin: ");
                string deger = Console.ReadLine();
                if (deger != "")
                {
                    int sayi = Convert.ToInt32(deger);
                    if (sayi > 1 && sayi < 49)
                    {
                        sayilar[i] = sayi;
                        i++;
                    }
                }
            } while (i < 6);

            uret = new Random().Next(1, 50);
            for (i = 0; i < sayilar.Length; i++)
                if (sayilar[i] == uret)
                    say++;

            Console.Write("\nÜretilen sayı: " + uret + "\n" + say + " tane tahminin tuttu\n\n");
        }
    }
}
