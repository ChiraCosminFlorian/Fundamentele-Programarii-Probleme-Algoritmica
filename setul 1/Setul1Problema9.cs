using System;
namespace Fundamentele_Programarii_Homework.Setul_1
{
    class Problema9
    {
        public static void Main()
        {
            int n;
            Console.WriteLine("Dati n ");
            n=Convert.ToInt32(Console.ReadLine());
            for(int d=1; d * d <= n; d++)
            {
                if (n % d == 0)
                {
                    Console.WriteLine(d + " ");
                    if(d*d<n)
                        Console.WriteLine(n/d + " ");
                }

            }
        }
    }
}