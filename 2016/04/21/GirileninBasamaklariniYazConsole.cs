using System;

namespace GirileninBasamaklariniYazConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] basamaklar = {"Birler", "Onlar", "Yüzler",
                                   "Binler", "Milyonlar", "Milyarlar",
                                   "Trilyonlar", "Katrilyonlar", "Kentilyonlar"};

            int limit = basamaklar.Length * 3 - 6,
                sayi,
                j = 0,
                i;

            Console.Write("Maksimum " + limit + " haneli bir sayı girin:");
            string deger = Console.ReadLine(),
                   metin = "";

            /* 31. ve 32. satır: girilen metin biçimindeki rakamları, sayıya dönüştürüyor.
             * İki seçenek eklememin sebebi:
             * TryParse değeri dönüştürmeyi dener. Yani 123456+ şeklinde bir sayı girilirse bunu kabul etmeyip
             * sayıyı 0 olarak belirleyecektir. Bu da programın hata vermesini engelleyecektir.
             * 
             * Convert seçeneği ise 123456+ girildiğinde programın çalışmasını durdurup hata verecektir.
             * 
             * Bu yüzden TryParse kullanımı daha sağlıklı.
             */
            int.TryParse(deger, out sayi);
            //sayi = Convert.ToInt32(deger);

            if (sayi.ToString().Length == deger.Length)
                if (sayi.ToString().Length <= limit)
                {
                    for (i = sayi.ToString().Length - 1; i >= 0; i--)
                    {
                        metin += deger[i] + " < " + basamaklar[j] + " Basamağı\n";
                        if (j > 2)
                        {
                            if (i != 0)
                            {
                                i--;
                                metin += deger[i] + " < On " + basamaklar[j] + " Basamağı\n";
                            }
                            if (i != 0)
                            {
                                i--;
                                metin += deger[i] + " < Yüz " + basamaklar[j] + " Basamağı\n";
                            }
                        }
                        j++;
                    }
                }
                else
                    metin = "Maksimum " + limit + " basamaklı sayı girebilirsin.\n";
            else
                metin = "Sadece sayı girebilirsin.\n";
            Console.Write("\n" + metin + "\n");
        }
    }
}
