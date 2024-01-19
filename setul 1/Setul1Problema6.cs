using System;

namespace Fundamentele_Programarii_Homework.Setul_1
{
    class Problema6
    {
        public static void Main()
        {
            int a, b, c;
            Console.WriteLine("Dati latura BC a triunghiului: ");
            a=int.Parse(Console.ReadLine());
            Console.WriteLine("Dati latura AC a triunghiului: ");
            b=int.Parse(Console.ReadLine());
            Console.WriteLine("Dati latura AB a triunghiului: ");
            c=int.Parse(Console.ReadLine());
            if (a + b > c && a + c > b && b + c > a)
                Console.WriteLine("Cele 3 laturi pot forma un triunghi");
            else
                Console.WriteLine("Cele 3 laturi NU pot forma un triunghi");
        }
    }
}