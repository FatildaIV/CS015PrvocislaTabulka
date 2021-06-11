using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS015PrvocislaTabulka
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nSoučet prvnočísel do pětiset: ");
            long soucet = 0;
            int cislo = 1;
            while (cislo < 500)
            {
                if (JePrvocislo(cislo))
                {
                    soucet += cislo;
                }

                Console.ForegroundColor = 
                    (JePrvocislo(cislo)) ?
                    ConsoleColor.Yellow :
                    ConsoleColor.Gray;

                Console.Write("{0,8}", cislo);

                if ((cislo % 8) == 0) //Kazde osme cislo odradkovat
                {
                    Console.WriteLine();
                }
                //cislo++ = zvysit cislo o jedna (cislo += 1)
                cislo++;
            }

            Console.WriteLine();
            Console.WriteLine("\nVysledny soucet: {0}", soucet);
            Console.ReadKey();
        }
        //Funkce ktera urcuje jestli je cislo prvocislo nebo ne
        public static bool JePrvocislo(int n)
        {
            int x = (int)Math.Floor(Math.Sqrt(n));

            if (n == 1) return false;
            if (n == 2) return true;

            for (int i = 2; i <= x; ++i)
                if (n % i == 0) return false;
            return true;
        }
    }
}
