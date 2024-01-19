using System;
namespace Fundamentele_Programarii_Homework.Setul_1
{
    class Problema13
    {
        public static void Main(string[] args)
        {
            int cnt = 0, y1, y2;
            Console.WriteLine("Dati y1: ");
            y1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dati y2: ");
            y2=Convert.ToInt32(Console.ReadLine());
            for(int i = y1; i <=  y2; i++)
            {
                if (i % 400 == 0 || (i % 4 == 0 && i % 100 != 0))
                    cnt++;
            }
            Console.WriteLine("Numarul anilor bisecti dintre y1 si y2 este " + cnt);
        }
    }
}