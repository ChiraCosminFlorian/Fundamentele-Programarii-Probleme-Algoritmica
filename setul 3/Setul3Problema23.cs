using System;

class ProblemaInterclasare
{
    static void Main()
    {
        int[] v1 = { 1, 3, 5, 7 };
        int[] v2 = { 2, 4, 6, 8, 10 };

        int[] merged = MergeSortedArrays(v1, v2);

        Console.Write("Vectorul interclasat: ");
        Console.WriteLine(string.Join(", ", merged));
    }

    static int[] MergeSortedArrays(int[] v1, int[] v2)
    {
        int n = v1.Length;
        int m = v2.Length;

        int[] result = new int[n + m];
        int i = 0, j = 0, k = 0;

        while (i < n && j < m)
        {
            if (v1[i] <= v2[j])
            {
                result[k] = v1[i];
                i++;
            }
            else
            {
                result[k] = v2[j];
                j++;
            }
            k++;
        }

        while (i < n)
        {
            result[k] = v1[i];
            i++;
            k++;
        }

        while (j < m)
        {
            result[k] = v2[j];
            j++;
            k++;
        }

        return result;
    }
}
