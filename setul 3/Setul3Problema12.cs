using System;

namespace Fundamentele_Programarii_Homework.Setul_3
{
    class Problema12
    {
        //selection sort = search trough an array and keep track of the minimum value during each iteration
        //At the end of each iteration, we swap variables O(n^2)

        static void Main(string[] args)
        {
            int n;
            n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for(int i = 0; i < n; i++)
            {
                array[i]= int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Vectorul initial este: ");
            AfisareVector(array);

            Console.WriteLine("Vectorul sortat este: ");
            SelectionSort(ref array);
            AfisareVector(array);
        }

        private static void AfisareVector(int[] array)
        {
            foreach(int i in array)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        private static void SelectionSort(ref int[]array)
        {
            for(int i = 0; i < array.Length - 1; i++)
            {
                int min = i;
                for(int j = i + 1; j < array.Length; j++)
                {
                    if (array[min] > array[j]) //ascending order
                        min = j;
                }
                int aux = array[i];
                array[i]= array[min];
                array[min]= aux;
            }
        }
    }

}