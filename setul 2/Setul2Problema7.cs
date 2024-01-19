using System;

namespace Fundamentele_Programarii_Homework.Setul_2
{
    class Problema7
    {
        static void Main()
        {
            int n;
            Console.WriteLine("Dati n: ");
            n=int.Parse(Console.ReadLine());
            Console.WriteLine($"Dati cele {n} numere: ");
            int minim, maxim;
            int x = int.Parse(Console.ReadLine());
            minim = maxim = x;
            for(int i = 1; i < n; i++)
            {
                int y=int.Parse(Console.ReadLine());
                if (minim > y)
                    minim = y;
                else if (maxim < y)
                    maxim = y;
                
            }
            Console.WriteLine($"Minimul din secventa este {minim}, maximul din secventa este {maxim} ");

        }
    }
}