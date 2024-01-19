using System;

class Program
{
    static void Main()
    {
        int[] numar1 = { 9, 7, 3, 8, 4, 2 };
        int[] numar2 = { 2, 1, 5, 6, 7 };

        AfiseazaOperatie("Suma", numar1, numar2, AdunaNumereMari);
        AfiseazaOperatie("Diferenta", numar1, numar2, ScadeNumereMari);
        AfiseazaOperatie("Produsul", numar1, numar2, InmultesteNumereMari);
    }

    static int[] AdunaNumereMari(int[] numar1, int[] numar2)
    {
        int m = numar1.Length;
        int n = numar2.Length;
        int[] rezultat = new int[Math.Max(m, n) + 1];
        int transport = 0;
        int i = m - 1, j = n - 1, k = rezultat.Length - 1;

        while (i >= 0 || j >= 0 || transport > 0)
        {
            int cifra1 = i >= 0 ? numar1[i--] : 0;
            int cifra2 = j >= 0 ? numar2[j--] : 0;

            int suma = cifra1 + cifra2 + transport;
            rezultat[k--] = suma % 10;
            transport = suma / 10;
        }

        return rezultat;
    }

    static int[] ScadeNumereMari(int[] numar1, int[] numar2)
    {
        int m = numar1.Length;
        int n = numar2.Length;
        int[] rezultat = new int[Math.Max(m, n)];
        int imprumut = 0;
        int i = m - 1, j = n - 1, k = rezultat.Length - 1;

        while (i >= 0)
        {
            int cifra1 = numar1[i--];
            int cifra2 = j >= 0 ? numar2[j--] : 0;

            int diferenta = cifra1 - cifra2 - imprumut;

            if (diferenta < 0)
            {
                diferenta += 10;
                imprumut = 1;
            }
            else
            {
                imprumut = 0;
            }

            rezultat[k--] = diferenta;
        }

        EliminaZerouriNefolosite(ref rezultat);
        return rezultat;
    }

    static int[] InmultesteNumereMari(int[] numar1, int[] numar2)
    {
        int m = numar1.Length;
        int n = numar2.Length;
        int[] rezultat = new int[m + n];

        for (int i = m - 1; i >= 0; i--)
        {
            int transport = 0;

            for (int j = n - 1; j >= 0; j--)
            {
                int produs = numar1[i] * numar2[j] + transport + rezultat[i + j + 1];
                rezultat[i + j + 1] = produs % 10;
                transport = produs / 10;
            }

            rezultat[i] += transport;
        }

        EliminaZerouriNefolosite(ref rezultat);
        return rezultat;
    }

    static void EliminaZerouriNefolosite(ref int[] numar)
    {
        int indexStart = 0;
        while (indexStart < numar.Length && numar[indexStart] == 0)
        {
            indexStart++;
        }

        if (indexStart > 0)
        {
            int[] rezultat = new int[numar.Length - indexStart];
            Array.Copy(numar, indexStart, rezultat, 0, rezultat.Length);
            numar = rezultat;
        }
    }

    static void AfiseazaOperatie(string operatie, int[] numar1, int[] numar2, Func<int[], int[], int[]> operatieNumereMari)
    {
        Console.Write($"{operatie} numerelor mari: ");
        AfiseazaNumar(operatieNumereMari(numar1, numar2));
    }

    static void AfiseazaNumar(int[] numar)
    {
        foreach (int cifra in numar)
        {
            Console.Write(cifra);
        }
        Console.WriteLine
