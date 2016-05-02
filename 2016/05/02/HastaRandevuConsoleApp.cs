using System;

namespace HastaRandevuConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string ad,
                   soyad,
                   doktor,
                   saat,
                   dakika;
            Console.Write("Hastanın bilgilerini girin\n\nHastanın adı: ");
            ad=Console.ReadLine();
            Console.Write("Hastanın soyadı: ");
            soyad=Console.ReadLine();
            Console.Write("Gitmek istediği doktor: ");
            doktor=Console.ReadLine();
            Console.Write("Randevu saati (09-17): ");
            saat=Console.ReadLine();
            Console.Write("Randevu dakikası (00-59): ");
            dakika=Console.ReadLine();

            Console.Write("\n\n"+ad+" "+soyad+" isimli hastanın "+saat+":"+dakika+" saatinde, DR. "+doktor+" ile randevusu alınmıştır.\n\n");
        }
    }
}
