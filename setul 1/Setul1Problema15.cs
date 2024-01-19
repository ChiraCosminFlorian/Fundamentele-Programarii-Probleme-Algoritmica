using System;
namespace Fundamentele_Programarii_Homework.Setul_1
{
    class Problema15
    {
        static void Main()
        {
            int a, b, c;
            Console.WriteLine("Dati primul numar: ");
            a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dati al doilea numar: ");
            b=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dati al treilea numar: ");
            c=Convert.ToInt32(Console.ReadLine());
            if (a <= b && b <= c)
                Console.WriteLine(a + " " + b + " " + c);
            else if (a <= c && c <= b)
                Console.WriteLine(a + " " + c + " " + b);
            else if (b <= a && a <= c)
                Console.WriteLine(b + " " + a + " " + c);
            else if (b <= c && c <= a)
                Console.WriteLine(b + " " + c + " " + a);
            else if (c <= a && a <= b)
                Console.WriteLine(c + " " + a + " " + b);
            else if (c <= b && b <= a)
                Console.WriteLine(c + " " + b + " " + a);


        }
    }
}
