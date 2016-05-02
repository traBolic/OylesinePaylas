using System;

namespace GirileninBasamaklariniYaz_v2Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sayı girin: ");
            string deger = Console.ReadLine();
            long basamak = 1;
            if (deger != "")
            {
                long sayi = Convert.ToInt64(deger);
                if (sayi.ToString().Length != 1)
                {
                    for (int i = sayi.ToString().Length - 1; i >= 0; i--)
                    {
                        /* 24. satırda basamaklara nokta ekliyor. 
                         * 100.000.000 gibi. Yoksa normalde 100000000 şeklinde yazılır.
                         * İstersen bunu kaldırabilirsin ve 
                         * 25. satırdaki noktaliBasamak değişkenini basamak olarak değiştirebilirsin
                         */
                        string noktaliBasamak = string.Format("{0:#,0}", basamak);
                        Console.WriteLine(deger[i] + " > " + noktaliBasamak + " basamağı");
                        basamak *= 10;
                    }
                }
            }
        }
    }
}
