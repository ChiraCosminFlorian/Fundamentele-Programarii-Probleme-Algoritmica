using System;

namespace Fundamentele_Programarii_Homework.Setul_3
{

    class Problema7
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Dati n: ");
            n=int.Parse(Console.ReadLine());
            int[] vector = new int[n];
            CitireVector(ref vector,n);
            Console.WriteLine("Vectorul initial este: ");
            AfisareVector(vector);
            Array.Reverse(vector);
            Console.WriteLine("Vectorul inversat este: ");
            AfisareVector(vector);

        }

        private static void AfisareVector(int[] vector)
        {
            foreach(int element in vector)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }

        private static void CitireVector(ref int[] vector,int n)
        {
            for(int i = 0; i < n; i++)
            {
                vector[i] = int.Parse(Console.ReadLine());
            }
        }
    }
}