using System;

namespace SondaSifirBulConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string deger = "",
                   mesaj;

            while (deger == "0" || deger == "")
            {
                Console.Write("\nSayı gir: ");
                deger = Console.ReadLine();

                if (deger != "0" && deger != "")
                {
                    Console.Write("\n\n--- 1. yol ---\n");
                    int sira = deger.LastIndexOf("0");
                    mesaj = "Girilen sayıda sıfır bulunamadı";
                    if (sira >= 0)
                        mesaj = "Sondan " + (deger.Length - sira) + ". basamak sıfır";
                    Console.Write(mesaj);

                    Console.Write("\n\n\n--- 2. yol ---\n");
                    mesaj = "Girilen sayıda sıfır bulunamadı";
                    for (int i = deger.Length - 1; i >= 0; i--)
                    {
                        if (deger[i] >= '0' && deger[i] <= '9')
                        {
                            if (deger[i] == '0')
                            {
                                mesaj = "Sondan " + (deger.Length - i) + ". basamak sıfır";
                                break;
                            }
                        }
                        else
                            continue;
                    }
                    Console.Write(mesaj);

                    Console.Write("\n\n\n--- 3. yol ---\n");
                    long sayi = Convert.ToInt64(deger);
                    for (long i = 0, basamak = 10; i < sayi.ToString().Length; i++, basamak *= 10)
                    {
                        long rakam = (sayi % basamak) / (basamak / 10);
                        if (rakam == 0)
                        {
                            mesaj = "Sondan " + (i + 1) + ". basamak sıfır";
                            break;
                        }
                    }
                    Console.Write(mesaj);
                }
            }
            Console.Write("\n\n\n\n");
        }
    }
}
//http://eodev.com/gorev/8750490
