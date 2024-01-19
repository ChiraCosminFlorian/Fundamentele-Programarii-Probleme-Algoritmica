using System;

namespace Fundamentele_Programarii_Homework.Setul_2
{
    class Problema1 { 

        static void Main(string[] args)
        {
            int n;
            n = int.Parse(Console.ReadLine());
            int cnt = 0;
            for(int i = 0; i < n; i++)
            {
                int x=int.Parse(Console.ReadLine());
                if (x % 2 == 0)
                    cnt++;
            }
            Console.WriteLine($"In total sunt {cnt} nr pare ");
        }






    }
}