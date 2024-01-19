using System;

namespace Fundamentele_Programarii_Homework.Setul_1
{
    class Problema2
    {
        static void Main(string[] args)
        {
            int a, b, c;
            double delta, x1, x2;
            Console.WriteLine("Dati a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dati b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dati c: ");
            c = Convert.ToInt32(Console.ReadLine());
            delta = b * b - 4 * a * c;
            if (delta > 0)
            {
                x1 = (-b + 2 * Math.Sqrt(delta)) / (2 * a);
                x2 = (-b - 2 * Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("Prima radacina este = {0}\n", x1);
                Console.WriteLine("A doua radacina este = {0}\n", x2);
            }
            else if (delta == 0)
            {
                x1 = -b / (2.0 * a);
                x2 = x1;
                Console.WriteLine("Ambele radacini sunt egale cu {0}\n", x1);

            }
            else
            {
                Console.WriteLine("Radacinile nu sunt numere reale ");
            }



        }
    }


}