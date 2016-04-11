using System;

namespace BirimCevirmeConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1 - inch > cm\n" +
                          "2 - °C > °F\n" +
                          "3 - kg > gr\n" +
                          "Çevirmek istediğiniz birimin sayısını girin:");
            string islem = Console.ReadLine(),
                   deger;
            if (islem != "")
            {
                double sayi;
                Console.Write("\nSayı girin: ");
                deger = Console.ReadLine();
                if (deger != "")
                {
                    sayi = Convert.ToDouble(deger);
                    if (islem == "1")
                        deger = "\n" + sayi + " inch  >  " + (sayi * 2.54) + " cm dir.\n";
                    else if (islem == "2")
                        deger = "\n" + sayi + "°C  >  " + ((9.0 / 5.0) * sayi + 32).ToString("F04") + "°F dır.\n";
                    else if (islem == "3")
                        deger = "\n" + sayi + " kg  >  " + (sayi * 1000) + " gram dır.\n";
                    else
                        deger = "Böyle bir birim çevirisi bulunmamaktadır.";
                }
                else
                    deger = "\nSayıyı boş giremezsin\n\n";
            }
            else
                deger = "\nBoş seçim yapmamalısın\n\n";

            Console.Write(deger);
        }
    }
}
