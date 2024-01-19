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
            int ok = 1;
            Console.WriteLine($"Dati cele {n} numere: ");
            int x = int.Parse(Console.ReadLine());  

            for(int i = 1; i < n; i++)
            {
                int y=int.Parse(Console.ReadLine());
                if (y < x)
                    ok = 0;
                x = y;
            }
            if (ok == 1)
            {
                Console.WriteLine("Numerele din secventa sunt in ordine crescatoare ");
            }
            else
                Console.WriteLine("Numerele din secventa nu sunt in ordine crescatoare ");

        }
    }
}