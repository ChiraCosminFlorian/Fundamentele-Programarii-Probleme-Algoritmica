using System;
namespace Fundamentele_Programarii_Homework.Setul_1
{
    class Problema11
    {
        public static void Main()
        {
            int n, oglindit = 0;
            Console.WriteLine("Dati n: ");
            n = Convert.ToInt32(Console.ReadLine());
            while (n > 0)
            {
                oglindit = oglindit * 10 + n % 10;
                n = n / 10;
            }
            Console.WriteLine("Numarul dat scris in ordine inversa este " + oglindit);
        }
    }
}