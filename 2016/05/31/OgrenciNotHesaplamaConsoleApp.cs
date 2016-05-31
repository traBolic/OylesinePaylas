using System;

namespace OgrenciNotHesaplamaConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string mesaj = "\n";
            string[] adsoyad = { "Mehmet Altın", "Zeynep Ata", "Ali Bal", "Fatih Deniz", "Elif Gönül" };
            int[,] notlar = {
                                {0,75,85,50},
                                {1,60,70,75},
                                {2,20,10,45},
                                {3,75,100,100},
                                {4,10,10,45}
                               };
            for (int i = 0; i < 5; i++)
            {
                int ort, kaldigi = 0;
                ort = notlar[i, 1] + notlar[i, 2] + notlar[i, 3] / 3;
                if (notlar[i, 1] < 55)
                    kaldigi++;
                if (notlar[i, 2] < 55)
                    kaldigi++;
                if (notlar[i, 3] < 55)
                    kaldigi++;
                mesaj += adsoyad[notlar[i, 0]] + " isimli öğrencinin\n  Ortalaması " + ort;
                if (notlar[i, 1] < 55 || notlar[i, 2] < 55 || notlar[i, 3] < 55 && ort < 60)
                    mesaj += " ve 55 altında ders notu olduğundan kalmıştır.";
                mesaj += "\n";
                mesaj += "  Notları > " + notlar[i, 1] + ", " + notlar[i, 2] + ", " + notlar[i, 3] + "\n" +
                         "  Kaldığı ders sayısı > " + kaldigi + "\n\n\n";
            }
            Console.Write(mesaj);
        }
    }
}
//http://eodev.com/gorev/8754559
