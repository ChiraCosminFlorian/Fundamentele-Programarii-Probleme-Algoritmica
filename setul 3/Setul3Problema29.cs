using System;

class Problema29
{
    static void Main()
    {
        int[] vector = { 5, 2, 8, 1, 7, 3 };

        Console.Write("Vectorul initial: ");
        AfiseazaVector(vector);

        MergeSort(vector, 0, vector.Length - 1);

        Console.Write("Vectorul sortat (MergeSort): ");
        AfiseazaVector(vector);
    }

    static void MergeSort(int[] vector, int stanga, int dreapta)
    {
        if (stanga < dreapta)
        {
            int mijloc = (stanga + dreapta) / 2;

            MergeSort(vector, stanga, mijloc);
            MergeSort(vector, mijloc + 1, dreapta);

            Interclaseaza(vector, stanga, mijloc, dreapta);
        }
    }

    static void Interclaseaza(int[] vector, int stanga, int mijloc, int dreapta)
    {
        int n1 = mijloc - stanga + 1;
        int n2 = dreapta - mijloc;

        int[] stangaTemp = new int[n1];
        int[] dreaptaTemp = new int[n2];

        Array.Copy(vector, stanga, stangaTemp, 0, n1);
        Array.Copy(vector, mijloc + 1, dreaptaTemp, 0, n2);

        int i = 0, j = 0, k = stanga;

        while (i < n1 && j < n2)
        {
            if (stangaTemp[i] <= dreaptaTemp[j])
            {
                vector[k] = stangaTemp[i];
                i++;
            }
            else
            {
                vector[k] = dreaptaTemp[j];
                j++;
            }
            k++;
        }

        while (i < n1)
        {
            vector[k] = stangaTemp[i];
            i++;
            k++;
        }

        while (j < n2)
        {
            vector[k] = dreaptaTemp[j];
            j++;
            k++;
        }
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