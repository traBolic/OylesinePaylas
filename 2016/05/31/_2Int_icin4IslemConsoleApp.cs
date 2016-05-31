using System;

namespace _2Int_icin4IslemConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double s1,
                   s2;
            string s_s1 = "",
                   s_s2 = "",
                   islem = "",
                   sonuc;
            while (true)
            {
                bool sifir = false;
                sonuc = "Sonuç: ";
                if (s_s1 == "")
                {
                    Console.Write("1. sayı: ");
                    s_s1 = Console.ReadLine();
                }
                else if (s_s2 == "")
                {
                    Console.Write("2. sayı: ");
                    s_s2 = Console.ReadLine();
                }
                else if (islem == "")
                {
                    Console.Write("İşlem seç( + - * / ): ");
                    islem = Console.ReadLine();
                }
                else
                {
                    s1 = Convert.ToDouble(s_s1);
                    s2 = Convert.ToDouble(s_s2);
                    switch (islem)
                    {
                        case "+":
                            sonuc += "" + (s1 + s2);
                            break;
                        case "-":
                            sonuc += "" + (s1 - s2);
                            break;
                        case "*":
                            sonuc += "" + (s1 * s2);
                            break;
                        case "/":
                            if (s1 == 0 || s2 == 0)
                            {
                                if (s1 == 0)
                                    s_s1 = "";
                                if (s2 == 0)
                                    s_s2 = "";
                                sonuc = "Bölme işleminde sıfır girilemez\n";
                                sifir = true;
                            }
                            else
                                sonuc += "" + (s1 / s2);
                            break;
                        default:
                            sonuc = "Hatalı operatör seçimi";
                            break;
                    }
                    Console.Write("\n" + sonuc + "\n\n");
                    if (sifir == false)
                        break;
                }
            }
        }
    }
}
//http://eodev.com/gorev/8761366
