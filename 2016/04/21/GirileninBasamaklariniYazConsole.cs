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

            Console.Write("Limit " + long.MinValue + "\n  ile  " + long.MaxValue + " dir.\n\n" +
                          "Lütfen, yukarıda gördüğün limitler arasında bir sayı gir: ");
            string deger = Console.ReadLine(),
                   metin = "";

            /* 29. ve 30. satır: girilen metin biçimindeki rakamları, sayıya dönüştürüyor.
             * İki seçenek eklememin sebebi:
             * TryParse değeri dönüştürmeyi dener. Yani 123456+ şeklinde bir sayı girilirse bunu kabul etmeyip
             * sayıyı 0 olarak belirleyecektir. Bu da programın hata vermesini engelleyecektir.
             * 
             * Convert seçeneği ise 123456+ girildiğinde programın çalışmasını durdurup hata verecektir.
             * 
             * Bu yüzden TryParse kullanımı daha sağlıklı.
             */
            long sayi;
            long.TryParse(deger, out sayi);
            //sayi = Convert.ToInt64(deger);

            if (sayi.ToString().Length != 1)
            {
                int j = 0, i;
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
                metin = "Sadece sayı ve belirlenmiş limitler arasında bir sayı girebilirsin.\n";
            Console.Write("\n" + metin + "\n");
        }
    }
}
