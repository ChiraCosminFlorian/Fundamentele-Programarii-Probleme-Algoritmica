using System;
using System.Runtime.Intrinsics.X86;

namespace Fundamentele_Programarii_Homework.Setul_1
{
    class Problema17
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Dati a: ");
            a=int.Parse(Console.ReadLine());
            Console.WriteLine("Dati b: ");
            b=int.Parse(Console.ReadLine());
            int copie_a = a;
            int copie_b = b;
            while (b != 0)
            {
                int r = a % b;
                a = b;
                b = r;
            }
            Console.WriteLine("Cmmdc dintre a si b este: " + a);
            int cmmdc = a;
            int cmmmc = (copie_a * copie_b) / cmmdc;
            Console.WriteLine("Cmmmc dintre a si b este: " + cmmmc);
        }
    }
}