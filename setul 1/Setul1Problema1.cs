using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentele_Programarii_Homework.Setul_1
{
    class Problema1
    {
        static void Main(string[] args)
        {
            float a, b, x;
            Console.Write("Dati a = ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Dati b = ");
            b = Convert.ToInt32(Console.ReadLine());
            x = -b / a;
            Console.WriteLine("- " + b + " / " + a + " = " + x);
        }
    }
}
