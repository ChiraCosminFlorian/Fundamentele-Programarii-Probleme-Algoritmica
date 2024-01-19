using System;
namespace Fundamentele_Programarii_Homework.Setul_1
{
    class Problema5
    {
        public static void Main()
        {
            int n, k, cifra_afisata=0;
            Console.WriteLine("Dati n: ");
            n=Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine("Dati k: ");
            k= Convert.ToInt32 (Console.ReadLine());
            while (k > 0)
            {
                k--;
                cifra_afisata = n % 10;
                n = n / 10;
             
            }
            Console.WriteLine("A k-a cifra din numarul n este {0}\n", cifra_afisata);
        }
    }
}
