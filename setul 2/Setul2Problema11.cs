using System;
using System.Runtime.CompilerServices;

namespace Fundamentele_Programarii_Homework.Setul_2
{
    class Problema11
    {
        static void Main()
        {
            int n;
            Console.WriteLine("Dati n: ");
            n=int.Parse(Console.ReadLine());
            double suma = 0;

            for(int i = 0; i < n; i++)
            {
                double x = double.Parse(Console.ReadLine());
                if(x != 0)
                    suma = suma + 1/x;
            }
            Console.WriteLine($"Suma inverselor elementelor este {suma}");
        }
          
     }

       
}