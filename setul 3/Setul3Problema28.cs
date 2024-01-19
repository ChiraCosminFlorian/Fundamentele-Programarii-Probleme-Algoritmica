using System;

class Problema28
{
    static void Main()
    {
        int[] vector = { 5, 2, 8, 1, 7, 3 };

        Console.Write("Vectorul initial: ");
        AfiseazaVector(vector);

        Quicksort(vector, 0, vector.Length - 1);

        Console.Write("Vectorul sortat (Quicksort): ");
        AfiseazaVector(vector);
    }

    static void Quicksort(int[] vector, int stanga, int dreapta)
    {
        if (stanga < dreapta)
        {
            int pivotIndex = Partitie(vector, stanga, dreapta);
            Quicksort(vector, stanga, pivotIndex - 1);
            Quicksort(vector, pivotIndex + 1, dreapta);
        }
    }

    static int Partitie(int[] vector, int stanga, int dreapta)
    {
        int pivot = vector[dreapta];
        int i = stanga - 1;

        for (int j = stanga; j < dreapta; j++)
        {
            if (vector[j] < pivot)
            {
                i++;
                SchimbaElemente(vector, i, j);
            }
        }

        SchimbaElemente(vector, i + 1, dreapta);
        return i + 1;
    }

    static void SchimbaElemente(int[] vector, int index1, int index2)
    {
        int temp = vector[index1];
        vector[index1] = vector[index2];
        vector[index2] = temp;
    }

    static void AfiseazaVector(int[] vector)
    {
        foreach (int element in vector)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }
}