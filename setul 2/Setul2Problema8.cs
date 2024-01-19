using System;

namespace Fundamentele_Programarii_Homework.Setul_2
{
    class Problema8
    {
        static void Main()
        {
            int k;
            Console.WriteLine("Dati k: ");
            k=int.Parse(Console.ReadLine());
            int x=0, y=1;
            for (int i = 2; i < k; i++)
            {
                int fibonacci = x + y;
                x = y;
                y=fibonacci;
            }
            int rezultat = y;
            Console.WriteLine($"Al n-lea element din fibonacci este: {rezultat}");
        }
    }
}