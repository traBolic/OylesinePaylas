using System;

namespace Bankamatik_KacTLKacTaneConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Çekmek istediğiniz miktar girin:");
            int miktar = Convert.ToInt32(Console.ReadLine());
            string mesaj = "";
            if (miktar % 5 != 0 || miktar < 5)
                mesaj = "Lütfen 5 ve 5'in katları bir miktar girin\n";
            else 
            {
                if (miktar >= 200)
                {
                    mesaj += miktar / 200 + " adet 200 TL'lik banknot\n";
                    miktar -= ((miktar / 200) * 200);
                }
                if (miktar >= 100)
                {
                    mesaj += miktar / 100 + " adet 100 TL'lik banknot\n";
                    miktar -= ((miktar / 100) * 100);

                }
                if (miktar >= 50)
                {
                    mesaj += miktar / 50 + " adet 50 TL'lik banknot\n";
                    miktar -= ((miktar / 50) * 50);
                }
                if (miktar >= 20)
                {
                    mesaj += miktar / 20 + " adet 20 TL'lik banknot\n";
                    miktar -= ((miktar / 20) * 20);
                }
                if (miktar >= 10)
                {
                    mesaj += miktar / 10 + " adet 10 TL'lik banknot\n";
                    miktar -= ((miktar / 10) * 10);
                }
                if (miktar >= 5)
                {
                    mesaj += miktar / 5 + " adet 5 TL'lik banknot\n";
                }
            }
            Console.Write("\n" + mesaj + "\n");

        }
    }
}
//http://eodev.com/gorev/8760781
