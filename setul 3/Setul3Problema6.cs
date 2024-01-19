using System;

namespace Fundamentele_Programarii_Homework.Setul_3
{
    class Problema6
    {
        static void Main(string[] args)
        {
            int[] vector = {7, 23, 12, 17, 34, 65, 0, 32, 16, 17};
            int n = vector.Length;
            Console.WriteLine("Vectorul initial este: ");
            AfisareVector(vector);
            Console.WriteLine("Dati pozitia de pe care vreti sa stergem elementul: ");
            int k = int.Parse(Console.ReadLine());

            StergereDinVector(ref vector, ref n, k);
            Console.WriteLine("Vectorul actualizat este: ");
            AfisareVector(vector);


        }

        private static void StergereDinVector(ref int[] vector, ref int n, int k)
        {
           for(int i=k;i<n-1;i++)
                 vector[i] = vector[i+1];
           Array.Resize(ref vector, n-1);   
            n=n-1;
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

