using System;

class Program
{
    static void Main()
    {

        int numar1 = 23222;
        int numar2 = 9009000;
        int numar3 = 593;
        int numar4 = 4022;

        Console.WriteLine(AreDoarDouaCifre(numar1));  
        Console.WriteLine(AreDoarDouaCifre(numar2));  
        Console.WriteLine(AreDoarDouaCifre(numar3));  
        Console.WriteLine(AreDoarDouaCifre(numar4));  
    }

    static bool AreDoarDouaCifre(int numar)
    {
        int primaCifra = numar % 10;
        int aDouaCifra = numar / 10 % 10;

     
        int cifreSetate = 0;

     
        while (numar != 0)
        {
            int cifra = numar % 10;

            if (cifra != primaCifra && cifreSetate == 0)
            {
                aDouaCifra = cifra;
                cifreSetate++;
            }
           
            else if (cifra != primaCifra && cifra != aDouaCifra)
            {
                return false;
            }

            numar /= 10;
        }


        return true;
    }
}