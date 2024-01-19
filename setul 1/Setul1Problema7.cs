using System;
namespace Fundamentele_Programarii_Homework.Setul_1
{
    class Problema7
    {
       public static void Main()
        {
            int a, b, c;
            Console.WriteLine("Dati numarul a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dati numarul b: ");
            b = Convert.ToInt32(Console.ReadLine());
            c = a;
            a = b;
            b = c;
            Console.WriteLine("Valorile interschimbate sunt : ");
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
