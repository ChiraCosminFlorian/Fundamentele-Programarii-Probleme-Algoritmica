using System;

namespace Fundamentele_Programarii_Homework.Setul_3
{
    class Problema15
    {
        static void Main()
        {
            int n=0;
            int[] array = { 1, 1, 2, 3, 4, 2, 5, 6 };
            Console.WriteLine("Array-ul initial este: ");
            AfisareArray(array);
            EliminareElementeRepetate(ref array, n);
            Console.WriteLine("Array-ul actualizat este: ");
            AfisareArray(array);
        }

        private static void EliminareElementeRepetate(ref int[] array, int n)
        {
             n = array.Length;
            int newSize = 1;
            for (int i = 1; i < n; i++)
            {
                bool isDuplicate = false;
                for (int j = 0; j < newSize; j++)
                {
                    if (array[i] == array[j])
                    {
                        isDuplicate = true;
                        break;
                    }
                }
                if (!isDuplicate)
                {
                    array[newSize++] = array[i];
                }
            }
            Array.Resize(ref array, newSize);
        }

        static void AfisareArray(int[] array)
        {
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

    }
}