using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[] v1 = { 1, 2, 3, 4, 5 };
        int[] v2 = { 3, 4, 5, 6, 7 };

        Intersection(v1, v2);
        Union(v1, v2);
        Difference(v1, v2);
        Difference(v2, v1);
    }

    static void Intersection(int[] v1, int[] v2)
    {
        Console.Write("Intersectia: ");
        List<int> result = new List<int>();

        int i = 0, j = 0;
        while (i < v1.Length && j < v2.Length)
        {
            if (v1[i] == v2[j])
            {
                result.Add(v1[i]);
                i++;
                j++;
            }
            else if (v1[i] < v2[j])
            {
                i++;
            }
            else
            {
                j++;
            }
        }

        Console.WriteLine(string.Join(", ", result));
    }

    static void Union(int[] v1, int[] v2)
    {
        Console.Write("Reuniunea: ");
        List<int> result = new List<int>();

        int i = 0, j = 0;
        while (i < v1.Length && j < v2.Length)
        {
            if (v1[i] == v2[j])
            {
                result.Add(v1[i]);
                i++;
                j++;
            }
            else if (v1[i] < v2[j])
            {
                result.Add(v1[i]);
                i++;
            }
            else
            {
                result.Add(v2[j]);
                j++;
            }
        }

        while (i < v1.Length)
        {
            result.Add(v1[i]);
            i++;
        }

        while (j < v2.Length)
        {
            result.Add(v2[j]);
            j++;
        }

        Console.WriteLine(string.Join(", ", result));
    }

    static void Difference(int[] v1, int[] v2)
    {
        Console.Write("Diferenta: ");
        List<int> result = new List<int>();

        int i = 0, j = 0;
        while (i < v1.Length && j < v2.Length)
        {
            if (v1[i] == v2[j])
            {
                i++;
                j++;
            }
            else if (v1[i] < v2[j])
            {
                result.Add(v1[i]);
                i++;
            }
            else
            {
                j++;
            }
        }

        while (i < v1.Length)
        {
            result.Add(v1[i]);
            i++;
        }

        Console.WriteLine(string.Join(", ", result));
    }
}
