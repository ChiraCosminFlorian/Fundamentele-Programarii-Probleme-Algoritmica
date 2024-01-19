using System;
namespace Fundamentele_Programarii_Homework.Setul1
{
    class Problema8
    {
        public static void Main()
        {
            int a, b;
            Console.WriteLine("Dati primul numar: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dati al doilea numar: ");
            b = Convert.ToInt32(Console.ReadLine());
            a = a * b;
            b = a / b;
            a = a / b;
            Console.WriteLine("Valorile interschimbate sunt: ");
            Console.WriteLine(a);
            Console.WriteLine(b);
        }

    }
}