using System;


namespace Fundamentele_Programarii_Homework.Setul_3
{
    class Problema5
    {
        static void Main(string[] args)
        {
            int[] vector = { 1, 2, 3, 4, 5 };
            int n=vector.Length;

            Console.WriteLine("Vectorul initial: ");
            AfisareVector(vector);

            Console.Write("Introduceti valoarea de inserat: ");
            int e=int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti pozitia unde inseram: ");
            int k = int.Parse(Console.ReadLine());

            InserareInVector(ref vector, n, e, k);
            Console.WriteLine("Vectorul actualizat: ");
            AfisareVector(vector);
        }

        private static void InserareInVector(ref int[] vector, int n, int e, int k)
        {
            Array.Resize(ref vector, n + 1);
            for(int i=n; i>k; i--) {
                vector[i] = vector[i - 1];
            }
            vector[k] = e;
        }

        private static void AfisareVector(int[] vector)
        {
            foreach(int element in vector)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }
    }
}