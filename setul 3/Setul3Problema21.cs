using System;

class Program
{
    static void Main()
    {
        int[] vector1 = { 1, 2, 3, 4 };
        int[] vector2 = { 1, 2, 3, 5 };

        int result = CompareLexicographically(vector1, vector2);

        if (result < 0)
        {
            Console.WriteLine("Vectorul 1 este înaintea vectorului 2 în ordinea lexicografică.");
        }
        else if (result > 0)
        {
            Console.WriteLine("Vectorul 2 este înaintea vectorului 1 în ordinea lexicografică.");
        }
        else
        {
            Console.WriteLine("Vectorii sunt egali în ordinea lexicografică.");
        }
    }

    static int CompareLexicographically(int[] vector1, int[] vector2)
    {
        int minLength = Math.Min(vector1.Length, vector2.Length);

        for (int i = 0; i < minLength; i++)
        {
            if (vector1[i] < vector2[i])
            {
                return -1; // vector1 este înainte lexicografic
            }
            else if (vector1[i] > vector2[i])
            {
                return 1; // vector2 este înainte lexicografic
            }
            // Dacă elementele sunt egale, continuăm la următoarea poziție
        }

        // Dacă ajungem aici, un vector este prefix al celuilalt sau sunt egale până la lungimea minimă
        return vector1.Length.CompareTo(vector2.Length);
    }
}
