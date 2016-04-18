using System;

namespace N_Elemanlı1_50RastgeleDiziConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Dizi boyutunu belirleyin: ");
            string deger = Console.ReadLine(),
                   metin = "";
            if (deger != "")
            {
                int n = Convert.ToInt32(deger);
                if (n > 0)
                {
                    int[] dizi = new int[n],
                         dizi2 = new int[50];
                    Random rast = new Random();

                    int k = 0;
                    for (int i = 0; i < dizi.Length; i++)
                    {
                        /*
                         * 28. satır 1 - 50 arasında rastgele sayı üreterek
                         * dizi içerisine sırasıyla atar.
                         */
                        dizi[i] = rast.Next(1, 50);
                        int tane = 0;
                        for (int j = 0; j < dizi.Length; j++)
                        {
                            if (dizi[i] == dizi[j])
                                tane++;
                        }
                        Console.Write("Dizi içerisinde " + tane + " adet " + dizi[i] + " var\n");

                        if (dizi[i] % 15 == 0 && k < 50)
                        {
                            dizi2[k] = dizi[i];
                            k++;
                        }
                    }
                    metin = n + " elemanlı dizi içerisinde " + k + " adet 3 ve 5 in katları var\n\n";
                    Console.Write("\n");
                }
            }
            else
                metin = "N degerini boş geçemezsiniz";
            Console.Write(metin);
        }
    }
}
