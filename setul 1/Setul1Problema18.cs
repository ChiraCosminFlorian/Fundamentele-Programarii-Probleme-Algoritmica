using System;

namespace Fundamentele_Programarii_Homework.Setul_1
{
    class Problema18
    {
        static void Main(string[] args)
        {
            int n, d = 2;
            Console.WriteLine("Dati n: ");
            n=int.Parse(Console.ReadLine());
            while(n > 1)
            {
                int p = 0;
                while(n % d == 0)
                {
                    n = n / d;
                    p++;
                }
                if (p != 0)
                    Console.Write(d + "^" + p + " x ");
                d++;
                if (d * d > n)
                    d = n;
            }
        }
    }
}