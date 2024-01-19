using System;

namespace Fundamentele_Programarii_Homework.Setul_1
{
    class Problema20
    {
      
        private static void Main()
        {
            int m = 13;
            int n = 30;
            double d;

            d = (double)m / n;
            Console.WriteLine(d);

            double fract = d - Math.Truncate(d);

            int maxDecimal = 6;
            while (maxDecimal > 0 && fract != 0)
            {
                // fract = 0.43
                int cifraZecimala;
                cifraZecimala = (int)Math.Truncate(fract * 10);
                Console.WriteLine($"{cifraZecimala} ");


                fract = fract * 10 - Math.Truncate(fract * 10);


                maxDecimal--;
            }
        }
    }
}