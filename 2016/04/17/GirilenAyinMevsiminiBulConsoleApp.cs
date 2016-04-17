using System;
using System.Linq;

namespace GirilenAyinMevsiminiBulConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hangi ayın mevsimi? : ");
            string Ay = Console.ReadLine().ToLower(),
                   metin=null;
            if (Ay.Length > 0)
            {
                switch (Ay)
                {
                    case "eylül": case "ekim": case "kasım":
                        metin = "Sonbahar";
                    break;

                    case "aralık": case "ocak": case "şubat":
                        metin = "Kış";
                    break;

                    case "mart": case "nisan": case "mayıs":
                        metin = "İlkbahar";
                    break;

                    case "haziran": case "temmuz": case "ağustos":
                        metin = "Yaz";
                    break;
                }

                    // 36. satır, klavyeden girilen ay adının ilk harfini büyük yapmak için var
                    // İstersen silebilirsin, çok önemli bir şey değil.
                Ay = Ay.First().ToString().ToUpper() + Ay.Substring(1);

                metin = metin != null ? Ay + " ayı " + metin + " mevsimi içerisindedir" : "Lütfen ay adını doğru girin";
            }
            Console.Write("\n" + metin + "\n\n");
        }
    }
}
