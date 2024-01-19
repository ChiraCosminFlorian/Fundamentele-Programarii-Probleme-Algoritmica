using System;

namespace Fundamentele_Programarii_Homework.Setul_3
{
    class Problema4
    {
        static void Main(string[] args)
        {
            int cntmin=0,cntmax=0,n;
            Console.WriteLine("Dati n: ");
            n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
    
            for(int i = 0; i < n; i++)
            {
                v[i]=int.Parse(Console.ReadLine());
            }
            int maxim = v[0];
            int minim = v[0];
            for(int i = 0; i < n; i++)
            {
                if (v[i] < minim)
                {
                    minim = v[i];
                    cntmin = 1;
                }
                else if (v[i] == minim)
                {
                    cntmin++;
                }
                if (v[i] > maxim)
                {
                    maxim = v[i];
                    cntmax = 1;
                }
                else if (v[i] == maxim)
                {
                    cntmax++;
                }
            }
            Console.WriteLine("Cel mai mic element din vector este " + minim + " , iar acesta apare de " + cntmin + " ori");
            Console.WriteLine("Cel mai mare element din vector este " + maxim + " , iar acesta apare de " + cntmax + " ori");
        }
    }
}