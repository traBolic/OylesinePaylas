using System;

namespace ParalelEsDegerBaglanti2ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Boş değer girerek hesaplamayı tamamlayabilirsiniz\n\n");
            string deger = "z";
            double R = .0,
                   r = .0;
            for (int i = 1; deger != ""; i++)
            {
                Console.Write("R" + i + " = ");
                R = (deger = Console.ReadLine()) != "" ? (r = Convert.ToDouble(deger)) != .0 ? R + (1 / r) : R : R;
            }

            R = R != .0 ? 1 / R : R;

            Console.Write("\n\nRt: {0:F} ohm  dur.\n\n", R);
        }
    }
}
//http://eodev.com/gorev/8733723
