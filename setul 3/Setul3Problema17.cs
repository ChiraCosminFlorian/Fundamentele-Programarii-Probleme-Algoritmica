using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduceti numarul in baza 10: ");
        int numarDecimal = int.Parse(Console.ReadLine());

        Console.Write("Introduceti baza de destinatie (intre 2 si 16): ");
        int bazaDestinatie = int.Parse(Console.ReadLine());

        if (!(1 < bazaDestinatie && bazaDestinatie < 17))
        {
            Console.WriteLine("Baza invalida. Trebuie sa fie intre 2 si 16.");
            return;
        }

        int[] rezultat = ConvertesteInBaza(numarDecimal, bazaDestinatie);
        AfiseazaRezultatul(rezultat);
    }

    static int[] ConvertesteInBaza(int n, int b)
    {
        int lungimeMaxima = 32; // Presupunem ca lucrăm cu numere de 32 de biți
        int[] rezultat = new int[lungimeMaxima];
        int index = 0;

        while (n > 0)
        {
            int rest = n % b;
            rezultat[index++] = rest;
            n = n / b;
        }

        return rezultat;
    }

    static void AfiseazaRezultatul(int[] rezultat)
    {
        Console.Write("Rezultatul conversiei este: ");

        for (int i = rezultat.Length - 1; i >= 0; i--)
        {
            if (rezultat[i] != 0)
            {
                Console.Write(rezultat[i]);
            }
        }

        Console.WriteLine();
    }
}
