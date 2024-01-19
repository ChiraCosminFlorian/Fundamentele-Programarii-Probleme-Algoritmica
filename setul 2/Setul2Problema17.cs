using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Exemplu de utilizare
        int[] secventa = { 0, 1, 0, 0, 1, 0, 1, 1 };

        // Verificăm dacă secvența este corectă și calculăm nivelul maxim de încuibare
        bool corecta = EsteSecventaCorecta(secventa, out int nivelMaxim);

        // Afișăm rezultatul
        if (corecta)
        {
            Console.WriteLine($"Secvența este corectă. Nivelul maxim de încuibare este: {nivelMaxim}");
        }
        else
        {
            Console.WriteLine("Secvența nu este corectă.");
        }
    }

    // Funcția pentru verificarea dacă o secvență este corectă și calcularea nivelului maxim de încuibare
    static bool EsteSecventaCorecta(int[] secventa, out int nivelMaxim)
    {
        nivelMaxim = 0;
        Stack<int> stiva = new Stack<int>();

        for (int i = 0; i < secventa.Length; i++)
        {
            if (secventa[i] == 0)
            {
                // Paranteza deschisă: adăugăm nivelul curent la stivă
                stiva.Push(nivelMaxim);
                nivelMaxim = 0; // Resetăm nivelul curent
            }
            else if (secventa[i] == 1)
            {
                // Paranteza închisă: verificăm stiva și actualizăm nivelul maxim
                if (stiva.Count == 0)
                {
                    return false; // Parantezele sunt incorect încuibate
                }
                nivelMaxim = Math.Max(nivelMaxim, stiva.Pop() + 1);
            }
        }

        // Verificăm dacă există paranteze deschise neînchise
        return stiva.Count == 0;
    }
}
