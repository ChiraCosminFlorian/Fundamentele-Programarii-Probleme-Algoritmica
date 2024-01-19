using System;

class Program
{
    static void Main()
    {
        int[] vector = { 3, 0, 8, 0, 2, 0, 1 };

        Console.WriteLine("Vectorul original:");
        AfisareVector(vector);

        SortareCuZeroLaSfarsit(vector);

        Console.WriteLine("\nVectorul după interschimbare:");
        AfisareVector(vector);
    }

    static void SortareCuZeroLaSfarsit(int[] vector)
    {
        int n = vector.Length;
        int index = 0;

        // Parcurge vectorul și mută toate valorile nenule la început
        for (int i = 0; i < n; i++)
        {
            if (vector[i] != 0)
            {
                // Dacă elementul nu este zero, îl mutăm la început
                int temp = vector[i];
                vector[i] = vector[index];
                vector[index] = temp;
                index++;
            }
        }
    }

    static void AfisareVector(int[] vector)
    {
        foreach (var element in vector)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }
}
