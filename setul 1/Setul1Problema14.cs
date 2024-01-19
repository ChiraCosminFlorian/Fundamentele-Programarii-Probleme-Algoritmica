using System;
namespace Fundamentele_Programarii_Homework.Setul_1
{
    class Problema14
    {
        public static void Main()
        {
            int inv, nr, copie_nr;
            inv = 0;
            Console.WriteLine("Dati numarul: ");
            nr=Convert.ToInt32(Console.ReadLine());
            copie_nr = nr;
            while(copie_nr > 0)
            {
                inv = inv * 10 + copie_nr % 10;
                copie_nr /= 10;
            }
            if (nr == inv)
                Console.WriteLine("Numarul este palindrom ");
            else
                Console.WriteLine("Numarul nu este palindrom ");
        }
    }
}