using System;
namespace Fundamentele_Programarii_Homework.Setul_1
{
    class Problema3
    {
        public static void Main()
        {
            int n, k;
            Console.WriteLine("Dati n: ");
            n=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dati k: ");
            k=Convert.ToInt32(Console.ReadLine());
            if (k % n == 0)
                Console.WriteLine("Numarul n se divide cu k ");
            else
                Console.WriteLine("Numarul n nu se divide cu k");
        }
    }
}