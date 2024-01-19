using System; 

namespace Fundamentele_Programarii_Homework.Setul_1
{
    class Problema16
    {
        static void Main(string[] args)
        {
         
            int[] v =new int[5];
            for(int i = 0; i < 5; i++)
                v[i] = int.Parse(Console.ReadLine());
            for(int i =0; i < 4; i++)
            {
                for(int j=i+1; j < 5; j++)
                    if (v[i] > v[j])
                    {
                        int aux = v[i];
                        v[i] = v[j];
                        v[j] = aux;
                    }
            }
            Console.WriteLine("Elementele din vector sunt: ");
            for(int i = 0;i < 5;i++)
                Console.Write(v[i]+" ");
           
             
            
        }
    }
}