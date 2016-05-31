using System;

namespace ParalelEsDegerBaglantiConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Boş değer girerek hesaplamayı tamamlayabilirsiniz\n\n");
            string deger = "";
            double R = .0,
                   r = .0,
                   i = 1;
            do
            {
                Console.Write("R" + i + " = ");
                deger = Console.ReadLine();
                if (deger != "")
                {
                    r = Convert.ToDouble(deger);
                    if (r != .0)
                        R += (1 / r);
                    i++;
                }
            }while (deger != "");

            if (R != .0)
                R = 1 / R;

            Console.Write("\n\nR_t: {0:F} ohm  dur.\n\n", R);
        }
    }
}
//http://eodev.com/gorev/8759992
