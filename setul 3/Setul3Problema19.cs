using System;

class Program
{
    static void Main()
    {
        int[] s = { 1, 2, 1, 2, 1, 3, 1, 2, 1 };
        int[] p = { 1, 2, 1 };

        int count = CountOccurrences(s, p);

        Console.WriteLine($"Vectorul p apare în vectorul s de {count} ori.");
    }

    static int CountOccurrences(int[] s, int[] p)
    {
        int count = 0;
        int n = s.Length;
        int m = p.Length;

        for (int i = 0; i <= n - m; i++)
        {
            bool match = true;

            // Verificăm dacă vectorul p apare începând de la poziția i în vectorul s
            for (int j = 0; j < m; j++)
            {
                if (s[i + j] != p[j])
                {
                    match = false;
                    break;
                }
            }

            if (match)
            {
                count++;
            }
        }

        return count;
    }
}