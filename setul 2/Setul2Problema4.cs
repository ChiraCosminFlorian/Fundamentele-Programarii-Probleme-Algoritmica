using System;

namespace Fundamentele_Programarii_Homework.Setul_2
{
    class Problema4
    {
        static void Main()
        {
            int n;
            Console.WriteLine("Dati n: ");
            n=int.Parse(Console.ReadLine());
            Console.WriteLine("Dati numarul a pe care il cautam: ");
            int a=int.Parse(Console.ReadLine());
            int pozitia = -1;
            for(int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (x == a)
                    pozitia = i;
            }
            Console.WriteLine($"Pozitia pe care se afla a este {pozitia}");
        }
    }
}