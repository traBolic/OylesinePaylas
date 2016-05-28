using System;

namespace TcNoDogrulaConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, topla = 0;
            string tcno, mesaj;

            Console.Write("T.C. Kimlik numarası gir: ");
            tcno = Console.ReadLine();
            if (tcno.Length == 11)
            {
                for (i = 0; i < 10; i++)
                    topla += Convert.ToInt32(tcno[i].ToString());

                mesaj = "Hatalı kimlik numarası";
                if (topla % 10 == Convert.ToInt32(tcno[10].ToString()))
                    mesaj = "Doğru kimlik numarası";
            }
            else
                mesaj = "TC kimlik numarası 11 basamaklı olmalıdır";

            Console.WriteLine("\n" + mesaj + "\n");
        }
    }
}
//http://eodev.com/gorev/8741607
