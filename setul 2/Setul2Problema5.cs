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
            int cnt = 0;
            Console.WriteLine($"Dati cele {n} numere: ");
            for(int i = 0; i < n; i++)
            {
                int x=int.Parse(Console.ReadLine());
                if (x == i)
                    cnt++;
            }
            Console.WriteLine($"Numarul elementelor egale cu pozitia lor din secventa este {cnt} ");
        }
    }
}