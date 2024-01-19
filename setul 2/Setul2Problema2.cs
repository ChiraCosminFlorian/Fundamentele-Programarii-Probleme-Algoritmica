using System;

namespace Fundamentele_Programarii_Homework.Setul_2
{
    class Problema2
    {
        static void Main()
        {
            int n;
            int nrneg = 0, nrpos = 0, cntzero = 0;
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (x < 0)
                    nrneg++;
                else if (x > 0) nrpos++;
                else cntzero++;
            }
            Console.WriteLine($"In secventa sunt {nrneg} numere negative, {nrpos} numere pozitive, {cntzero} elemente nule ");
        }
    }
}