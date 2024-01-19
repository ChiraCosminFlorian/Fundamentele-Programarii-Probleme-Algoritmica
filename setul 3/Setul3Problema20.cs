using System;

class Program
{
    static void Main()
    {
        string s1 = "BBWBW";
        string s2 = "WBWBB";

        int overlappings = CountOverlappings(s1, s2);

        Console.WriteLine($"Numărul de suprapuneri este: {overlappings}");
    }

    static int CountOverlappings(string s1, string s2)
    {
        int count = 0;

        for (int i = 0; i < s1.Length; i++)
        {
            for (int j = 0; j < s2.Length; j++)
            {
                int overlappedCount = 0;

                // Verificăm suprapunerea la începutul actual
                for (int k = 0; k < Math.Min(s1.Length - i, s2.Length - j); k++)
                {
                    if (s1[i + k] == s2[j + k])
                    {
                        overlappedCount++;
                    }
                    else
                    {
                        break;
                    }
                }

                count += overlappedCount;
            }
        }

        return count;
    }
}
