using System;

namespace Fundamentele_Programarii_Homework.Setul_1
{
    class Problema11
    {
      
       
        static void Main(string[] args)
        {
            int n;
            n = int.Parse(Console.ReadLine());
           int[] v= new int[n];
            v[0] = v[1] = 1; //0 si 1 nu sunt considerate nr prime

            for(int i=4; i < n; i += 2)
                v[i] = 1; //nr pare mai mari ca 4 nu au cum sa fie prime, singurul nr par prim este 2
            for (int i = 3; i < n; i += 2) //verificam nr impare din 2 in 2
                if (v[i] == 0) //se verifica mereu
                    for (int j = 2 * i; j < n; j += i) //mergem pe multiplii numarului impar care nu mai sunt nr prime
                        v[j] = 1;
            for(int i = 0; i < n; i++)
            {
                if (v[i] == 0)
                    Console.WriteLine(i + " ");
            }




        }

      
    }

}
