using System;

namespace Fundamentele_Programarii_Homework.Setul_1
{
    class Problema13
    {
        //Insertion sort = after comparing elemens to the left
        //                 shift elements to the right to make room to insert a value
        // starts from 1 so it can compare to the first element and swap them if it s the case
        static void Main(string[] args)
        {
            int n;
            n = int.Parse(Console.ReadLine());
            int[] array= new int[n];

            for(int i = 0; i < n; i++)
                array[i] =int.Parse(Console.ReadLine());
            Console.WriteLine("Vectorul inainte sa fie sortat: ");
            AfisareElemente(array);

            Console.WriteLine("Vectorul dupa sortare: ");
            InsertionSort(ref array);
            AfisareElemente(array);
        }

        private static void InsertionSort(ref int[] array)
        {
            
            for(int i = 1; i < array.Length; i++)
            {
                int temp = array[i];
                int j = i - 1; //this will comppare to the left of the variable we are currently iterating
                while(j >= 0 && array[j] > temp)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = temp;
            }
        }

        private static void AfisareElemente(int[] array)
        {
            foreach(int i in array)
            {
                Console.WriteLine(i + " ");
            }
            Console.WriteLine();
        }
    }

}