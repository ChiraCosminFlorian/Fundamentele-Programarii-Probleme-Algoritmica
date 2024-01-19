using System;

namespace Fundamentele_Programarii_Homework.Setul_3
{
    class Problema2
    {
        static void Main(string[] args)
        {
            int n, k;
            Console.WriteLine("Dati n: ");
            n=int.Parse(Console.ReadLine());
            Console.WriteLine("Dati k: ");
            k=int.Parse(Console.ReadLine());
            int[]v = new int[n];
            for(int i = 0; i < n; i++)
            {
                v[i]=int.Parse(Console.ReadLine());
            }
            Console.WriteLine(ReturneazaPozitia(v, k, n));
        }

        static int ReturneazaPozitia(int[] v, int k, int n) { 
            for(int i = 0; i < n; i++)
            {
                if (v[i] == k)
                    return i;
            }
            return -1;
        }                    

                    

    }
}