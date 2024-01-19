using System;

namespace Fundamentele_Programarii_Homework.Setul_2
{
    class Problema9
    {
        static void Main()
        {
            int n;
            bool ok_crescatoare = true;
            bool ok_descrescatoare = true;

            Console.WriteLine("Dati n: ");
            
            n=int.Parse(Console.ReadLine());

            int x = int.Parse(Console.ReadLine());
            for(int i = 1; i < n; i++)
            {
                int y = int.Parse(Console.ReadLine());
                if (y > x)
                {
                    ok_descrescatoare = false;
                }
                if (y < x)
                {
                    ok_crescatoare = false;
                }
                x = y;
            }
            if (ok_crescatoare == true)
            {
                Console.WriteLine("Sirul este crescator");
            }
            else if (ok_descrescatoare == true)
            {
                Console.WriteLine("Sirul este descrescator");
            }
            else { Console.WriteLine("Sirul nu e monoton");
            
            }

        }
    }
}