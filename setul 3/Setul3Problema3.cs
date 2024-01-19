using System;

namespace Fundamentele_Programarii_Homework.Setul_3
{
    class Problema3
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Dati n: ");
            n=int.Parse(Console.ReadLine());
            int []v = new int[n];
            for(int i = 0; i < n; i++)
            {
                v[i]=int.Parse(Console.ReadLine());
            }
            int minim = v[0];
            int maxim = v[0];
            int indiceMinim=0, indiceMaxim=0;
            for(int i = 0; i < n; i++)
            {
                if (v[i] > maxim)
                {
                    maxim = v[i];
                    indiceMaxim = i;
                }
                else if (v[i] < minim) { 
                indiceMinim = i;
                    minim = v[i];
                }
               
            }
            Console.WriteLine("Indicele pe care se afla cea mai mica valoare din vector este " + indiceMinim);
            Console.WriteLine("Indicele pe care se afla cea mai mare valoare din vector este " + indiceMaxim);

        }
    }
}