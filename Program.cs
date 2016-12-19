using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ciklusok
{
    class Program
    {
        static void Main(string[] args)
        {
            int osszeg = 0;

            // for ciklus
            for (int i = 1; i < 101; i++)
            {
                osszeg += i;
            }

            Console.WriteLine("A szamok osszege (for) 1..100-ig: {0}",osszeg);

            // while
            int j = 1;
            osszeg = 0;
            while (j < 101)
            {
                osszeg += j++;
                // j++;
            }

            Console.WriteLine("A szamok osszege (while) 1..100-ig: {0}", osszeg);

            // do-while
            j = 1;
            osszeg = 0;
            do
            {
                osszeg += j++;
                //j++;
            } while (j < 101);

            Console.WriteLine("A szamok osszege (do - while) 1..100-ig: {0}", osszeg);

            Console.ReadKey();

        }
    }
}
