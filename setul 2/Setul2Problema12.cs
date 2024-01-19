using System;
using System.Runtime.Intrinsics.X86;

namespace Fundamentele_Programarii_Homework.Setul_2
{
    class Problema12
    {
        static void Main()
        {
            int n;
            Console.WriteLine("Dati n: ");
            n=int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            int cnt = 0;
            for(int i = 1; i < n; i++)
            {
                int y=int.Parse(Console.ReadLine());
                if (x != 0 && y == 0)
                    cnt++;
                x = y;
            }
            Console.WriteLine($"Numarul grupurilor consecutive diferite de zero este {cnt}");

        }
    }
}