using System;

namespace Fundamentele_Programarii_Homework.Setul_3
{
    class Problema1
    {
        static void Main(string[] args)
        {
            int n,suma=0;
            Console.WriteLine("Dati n: ");
            n=int.Parse(Console.ReadLine());
            int[] v = new int[n];
            for(int i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
                if (v[i] % 2 == 0)
                    suma = suma + v[i];
            }
            Console.WriteLine("Suma elementelor pare din vector este: " + suma);
                
        }
    }
}