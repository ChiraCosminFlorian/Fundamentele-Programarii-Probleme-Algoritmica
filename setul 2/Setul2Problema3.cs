using System;

namespace Fundamentele_Programarii_Homework.Setul_2
{
    class Problema3
    {
        static void Main()
        {
            int n;
            int suma = 0, produs = 1;
            Console.WriteLine("Introduceti un numar n: ");
            n = int.Parse(Console.ReadLine());


            for(int i = 0; i < n; i++)
            {
                int y=int.Parse(Console.ReadLine());
                suma += y;
                produs *= y;
            }
            Console.WriteLine($"Suma elementelor din sir este {suma}, produsul este {produs} ");
        }
    }
}