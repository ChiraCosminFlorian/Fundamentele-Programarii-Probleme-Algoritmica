using System;

class Program
{
    static void Main()
    {
        int[] vector = { 5, 2, 8, 1, 7, 3 };
        int index = 3;

        int valoareSortata = ValoareSortataDupaIndex(vector, index);

        Console.WriteLine($"Valoarea la pozitia {index} dupa sortare: {valoareSortata}");
    }

    static int ValoareSortataDupaIndex(int[] vector, int index)
    {
        // Cream o copie a vectorului pentru a nu modifica vectorul original
        int[] copieVector = new int[vector.Length];
        Array.Copy(vector, copieVector, vector.Length);

        // Sortam copia vectorului
        Array.Sort(copieVector);

        // Accesam elementul de la pozitia index in vectorul sortat
        return copieVector[index];
    }
}
