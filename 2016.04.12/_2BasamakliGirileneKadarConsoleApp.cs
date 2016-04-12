using System;

namespace _2BasamakliGirileneKadarConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool kontrol = false;
            do
            {
                try // Sayı yerine harf girilirse hata vermemesi için var
                {
                    Console.Write("Sayı gir: ");
                    int sayi = Convert.ToInt32(Console.ReadLine());
                    if ( sayi.ToString().Length==2)
                    {
                        Console.Write("\nİki basamaklı sayı girildi\n\n");
                        kontrol = true;
                    }
                }
                catch { }
            } while (kontrol==false);
        }
    }
}
