using System;

class Program
{
    static void Main()
    {
        // Exemplu de utilizare
        int[] secventa = { 4, 5, 6, 7, 1, 2, 3 };

        // Verificăm dacă secvența este o secvență bitonică rotită
        bool rezultat = EsteBitonicaRotita(secventa);

        // Afișăm rezultatul
        if (rezultat)
        {
            Console.WriteLine("Secvența este o secvență bitonică rotită.");
        }
        else
        {
            Console.WriteLine("Secvența nu este o secvență bitonică rotită.");
        }
    }

    // Funcția pentru verificarea dacă o secvență este o secvență bitonică rotită
    static bool EsteBitonicaRotita(int[] secventa)
    {
        int n = secventa.Length;

        // Caz special: secvența cu mai puțin de 3 elemente nu poate fi bitonică rotită
        if (n < 3)
        {
            return false;
        }

        // Găsim punctul de culme în secvență
        int punctCulme = GasestePunctCulme(secventa);

        // Dacă nu găsim un punct de culme, secvența nu este bitonică rotită
        if (punctCulme == -1 || punctCulme == n - 1)
        {
            return false;
        }

        // Verificăm dacă secvența este bitonică sau poate fi transformată într-o secvență bitonică prin rotiri succesive
        return EsteBitonica(secventa, punctCulme);
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

    // Funcția pentru verificarea dacă secvența este bitonică sau poate fi transformată într-o secvență bitonică prin rotiri succesive
    static bool EsteBitonica(int[] secventa, int punct
