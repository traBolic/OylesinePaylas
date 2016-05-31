using System;

namespace CharAdSoyBoslukBulConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ad soyad gir: ");
            char[] adsoy=Console.ReadLine().ToCharArray();
            int bosluk=-1;
            for (int i = 0; i < adsoy.Length; i++)
            {
                if (adsoy[i] == ' ')
                    bosluk = i+1;
            }
            if (bosluk == -1)
                Console.WriteLine("Boşluk bulunamadı");
            else
                Console.WriteLine("Boşluk "+bosluk+". sırada");
        }
    }
}
//http://eodev.com/gorev/8754549
