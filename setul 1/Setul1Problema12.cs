using System;
namespace Fundamentele_Programarii_Homework.Setul_1
{
    class Problema12
    {
        public static void Main()
        {
            int a, b, cnt = 0, n;
            Console.WriteLine("Dati n: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dati primul capat al intervalului, a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dati sfarsitul intervalului, b: ");
            b = Convert.ToInt32(Console.ReadLine());
            for (int i = a; i <= b; i++)
                if (i % n == 0)
                    cnt++;
            Console.WriteLine("Numarul numerelor divizibile cu n din intervalul a-b este " + cnt);
        }
    }
}