using System;

namespace DizidenSebzeSecConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sebze = { "biber", "patlıcan", "maydonoz", "fasulye", "nohut", "havuç", "mısır", "brokoli", "bamya", "kabak" };
            int sayi, i = 0;
            string deger, mesaj = "";
            do
            {
                Console.Write("Sebzeyi seçmek için 0 ile " + (sebze.Length - 1) + " arası bir sayı girin: ");
                deger = Console.ReadLine();
                if (deger != "")
                {
                    sayi = Convert.ToInt32(deger);
                    if (sayi < sebze.Length)
                    {
                        mesaj = sebze[sayi];
                        i++;
                    }
                    else
                        mesaj = "Hatalı seçim tekrar deneyin";
                }
                else
                    mesaj = "Boş geçemezsiniz";
                Console.WriteLine(mesaj + "\n");
            } while (i < sebze.Length - 1);
        }
    }
}
