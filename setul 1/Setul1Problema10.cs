using System;
namespace Fundamentele_Programarii_Homework.Setul_1
{
    class Problema10
    {
        public static void Main()
        {
            int n, nrdiv = 1, d = 2;
            Console.WriteLine("Dati numarul: ");
            n = Convert.ToInt32(Console.ReadLine());
            while (n > 1)
            {
                int p = 0;
                while (n % d == 0)
                {
                    n /= d;
                    p++;
                }
                nrdiv *= (p + 1);
                d++;
                if (d * d > n)
                    d = n;
            }
            if (nrdiv != 2)
            {
                Console.WriteLine("Nu este prim ");
            }
            else
                Console.WriteLine("Este prim ");
        }
    }
}