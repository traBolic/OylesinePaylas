using System;

namespace DikdortgenAlanHesaplaConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double d_uk,
                   d_kk,
                   alan;
            string s_uk = "",
                   s_kk = "";

            while (true)
            {
                if (s_uk == "" || s_uk == "0")
                {
                    Console.Write("Uzun kenar gir: ");
                    s_uk = Console.ReadLine();
                }
                else if (s_kk == "" || s_kk == "0")
                {
                    Console.Write("Kısa kenar gir: ");
                    s_kk = Console.ReadLine();
                }
                else
                {
                    d_uk = Convert.ToDouble(s_uk);
                    d_kk = Convert.ToDouble(s_kk);
                    
                    if (d_uk < 1)
                        s_uk = "";
                    else if (d_kk < 1)
                        s_kk = "";
                    else
                    {
                        alan = d_uk * d_kk;

                        Console.Write("\nBelirlenen dikdörtgenin alanı: " + alan + "\n\n");
                        break;
                    }
                }
            }
        }
    }
}
//http://eodev.com/gorev/8757808
