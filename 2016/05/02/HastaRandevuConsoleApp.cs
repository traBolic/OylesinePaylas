using System;

namespace HastaRandevuConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string ad,
                   soyad,
                   bolum,
                   doktor,
                   tarih,
                   saat,
                   ilaclar;

            Console.Write("Lütfen hasta bilgilerini girin\n\nHastanın adı: ");
            ad = Console.ReadLine();
            Console.Write("Hastanın soyadı: ");
            soyad = Console.ReadLine();
            Console.Write("Gitmek istediği bölüm: ");
            bolum = Console.ReadLine();
            Console.Write("Gitmek istediği doktor: ");
            doktor = Console.ReadLine();
            Console.Write("Randevu tarihi (01.01.2016): ");
            tarih = Console.ReadLine();
            Console.Write("Randevu saati (09:00 ve 17:30 arası): ");
            saat = Console.ReadLine();
            Console.Write("Varsa kullandığınız ilaçlar(virgül ile ayırın): ");
            ilaclar = Console.ReadLine();

            Console.Write("\n\n>  Sayın " + ad + " " + soyad + ";\n   Girdiğiniz bilgiler ile, "+tarih+" tarihinde ve " + saat + " saatinde, DR. " + doktor + " ile randevunuz alınmıştır.\n\n");

            
            /* Eski kod
             Console.Write("Hastanın bilgilerini girin\n\nHastanın adı: ");
            ad = Console.ReadLine();
            Console.Write("Hastanın soyadı: ");
            soyad = Console.ReadLine();
            Console.Write("Gitmek istediği doktor: ");
            doktor = Console.ReadLine();
            Console.Write("Randevu saati (09-17): ");
            saat = Console.ReadLine();
            Console.Write("Randevu dakikası (00-59): ");
            dakika = Console.ReadLine();

            Console.Write("\n\n" + ad + " " + soyad + " isimli hastanın " + saat + ":" + dakika + " saatinde, DR. " + doktor + " ile randevusu alınmıştır.\n\n");*/
        }
    }
}

//http://eodev.com/gorev/8493956
