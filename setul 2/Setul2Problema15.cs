using System;

class Program
{
    static void Main()
    {
        // Exemplu de utilizare
        int[] secventa = { 1, 2, 2, 3, 5, 4, 4, 3 };

        // Verificăm dacă secvența este bitonică
        bool rezultat = EsteBitonica(secventa);

        // Afișăm rezultatul
        if (rezultat)
        {
            Console.WriteLine("Secvența este bitonică.");
        }
        else
        {
            Console.WriteLine("Secvența nu este bitonică.");
        }
    }

    // Funcția pentru verificarea dacă o secvență este bitonică
    static bool EsteBitonica(int[] secventa)
    {
        int n = secventa.Length;

        // Caz special: secvența cu mai puțin de 3 elemente nu poate fi bitonică
        if (n < 3)
        {
            return false;
        }

        // Găsim punctul de culme în secvență
        int punctCulme = GasestePunctCulme(secventa);

        // Dacă nu găsim un punct de culme, secvența nu este bitonică
        if (punctCulme == -1 || punctCulme == n - 1)
        {
            return false;
        }

        // Verificăm dacă secvența este bitonică
        return EsteCrescatoare(secventa, 0, punctCulme) && EsteDescrescatoare(secventa, punctCulme, n - 1);
    }

    // Funcția pentru găsirea punctului de culme în secvență
    static int GasestePunctCulme(int[] secventa)
    {
        int n = secventa.Length;

        for (int i = 1; i < n - 1; i++)
        {
            if (secventa[i] > secventa[i - 1] && secventa[i] > secventa[i + 1])
            {
                return i; // Am găsit punctul de culme
            }
        }

        return -1; // Nu există punct de culme
    }

    // Funcția pentru verificarea dacă secvența este monoton crescătoare într-un interval dat
    static bool EsteCrescatoare(int[] secventa, int start, int end)
    {
        for (int i = start; i < end; i++)
        {
            if (secventa[i] >= secventa[i + 1])
            {
                return false;
            }
        }

        return true;
    }

    // Funcția pentru verificarea dacă secvența este monoton descrescătoare într-un interval dat
    static bool EsteDescrescatoare(int[] secventa, int start, int end)
    {
        for (int i = start; i < end; i++)
        {
            if (secventa[i] <= secventa[i + 1])
            {
                return false;
            }
        }

        return true;
    }
}
