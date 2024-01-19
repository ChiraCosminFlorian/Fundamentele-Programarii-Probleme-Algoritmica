using System;

class Problema16
{
    static int CalculateGCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    static int CalculateGCDOfArray(int[] array)
    {
        int result = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            result = CalculateGCD(result, array[i]);
        }

        return result;
    }

    static void Main()
    {
        int[] vector = { 24, 36, 48, 60 };
        int result = CalculateGCDOfArray(vector);

        Console.WriteLine($"Cel mai mare divizor comun al elementelor vectorului {string.Join(", ", vector)} este {result}");
    }
}
