using System;
using System.Runtime.Serialization;

namespace Fundamentele_Programarii_Homework.Setul_3
{
    class Problema10
    {
        static void Main(string[] args)
        {
            int n, k;
            Console.WriteLine("Dati cate elemente are vectorul: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Dati elementul pe care il cautam: ");
            k = int.Parse(Console.ReadLine());
            int[] v = new int[n];

            for (int i = 0; i < n; i++)
                v[i] = int.Parse(Console.ReadLine());


            Console.WriteLine(CautareBinara(v, n, k));
        }

        static int CautareBinara(int[]v,int n, int k)
        {
            int stanga, dreapta, pozitia;
            stanga = 0;
            dreapta = n - 1;
            pozitia = -1;
            while (stanga <= dreapta)
            {
                int mijloc = (stanga + dreapta) / 2;
                if (v[mijloc] == k)
                {
                    pozitia = mijloc;
                    break;
                }
                if (v[mijloc] > k)
                    dreapta = mijloc - 1;
                if (v[mijloc] < k)
                    stanga = mijloc + 1;
            }
            return pozitia;
        }
    }
}