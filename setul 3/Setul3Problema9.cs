using System;

namespace Fundamentele_Programarii_Homework.Setul_1
{
    class Problema9
    {
        static void Main(string[] args)
        {
            int n,k;
            n = int.Parse(Console.ReadLine());
            int[]v = new int[n];
            CitireVector(v, n);
            Console.WriteLine("Vectorul initial este: ");
            AfisareVector(v);
            Console.WriteLine("Dati k: ");
            k=int.Parse(Console.ReadLine());
            RotireStanga(ref v, k,n);
            Console.WriteLine("Vectorul rotit cu k pozitii spre stanga este: ");
            AfisareVector(v);


        }

        private static void RotireStanga(ref int[] v, int k, int n)
        {
            for(int i = 0; i < k; i++)
            {
                int temp = v[0];
                for(int j = 0; j < n - 1; j++)
                {
                    v[j] = v[j + 1];
                }
                v[n - 1] = temp;
            }
        }

        private static void AfisareVector(int[] v)
        {foreach(int element in v)
            {
                Console.Write(element + " ");
            }
        Console.WriteLine();
        }

        private static void CitireVector(int[] v, int n)
        {
            for(int i = 0; i < n; i++)
            {
                v[i]=int.Parse(Console.ReadLine());
            }
        }
    }

}