using System;

namespace Fundamentele_Programarii_Homework.Setul_2
{
    class Problema10
    {
        static void Main()
        {
            int n;
            Console.WriteLine("Dati n: ");
            n=int.Parse(Console.ReadLine());
            int lungime, lungime_maxima = 1;
            int x=int.Parse(Console.ReadLine());
            lungime = 1;
            for(int i = 1; i < n; i++)
            {  
                int y = int.Parse(Console.ReadLine());
                if (y == x)
                {
                    lungime++;
                    if(lungime>=lungime_maxima)
                        lungime_maxima= lungime;
                }
                else
                    lungime = 1;
                x = y;
            }
            Console.WriteLine($"Numarul maxim de elemente consecutive din secventa este {lungime_maxima} ");
        }
    }
}