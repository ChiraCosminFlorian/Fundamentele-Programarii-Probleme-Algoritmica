using System;
namespace Fundamentele_Programarii_Homework.Setul_1
{
    class Problema4
    {
        public static void Main()
        {
            int an;
            Console.WriteLine("Introdu anul pe care vrei sa il verifici: ");
            an = Convert.ToInt32(Console.ReadLine());
            if (an % 400 == 0 || (an % 4 == 0 && an % 100 != 0))
                Console.WriteLine("Anul este bisect ");
            else
                Console.WriteLine("Anul nu este bisect ");
        }
    }
}