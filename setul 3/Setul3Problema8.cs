using System;

namespace Fundamentele_Programarii_Homework.Setul_3
{

    class Problema8
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Dati n: ");
            n = int.Parse(Console.ReadLine());
            int[]vector = new int[n];
            CitireElementeVector(ref vector, n);

            int primul_element = vector[0];
            for(int i = 1; i <n; i++)
            {
                vector[i-1] = vector[i];
            }
            vector[n-1] = primul_element;

            Console.WriteLine("Vectorul rotit este: ");
            Afisare(vector);
        }

        private static void Afisare(int[] vector)
        {
            foreach(int element in vector)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }

        private static void CitireElementeVector(ref int[] vector, int n)
        {
            for(int i = 0; i < n; i++)
            {
                vector[i] = int.Parse(Console.ReadLine());
            }
        }
    }
}