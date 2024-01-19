using System;

class Program
{
    static void Main()
    {
        // Exemplu de utilizare
        int[] vector = { 2, 2, 3, 2, 4, 2, 5, 2, 2 };

        // Apelăm funcția pentru a găsi elementul majoritate
        int rezultat = GasesteElementMajoritate(vector);

        // Afișăm rezultatul
        if (rezultat != -1)
        {
            Console.WriteLine($"Elementul majoritate este: {rezultat}");
        }
        else
        {
            Console.WriteLine("Nu există element majoritate în vector.");
        }
    }

    // Funcția pentru găsirea elementului majoritate
    static int GasesteElementMajoritate(int[] vector)
    {
        int candidat = -1;
        int frecventa = 0;

        // Etapa 1: Găsirea candidatului potențial pentru elementul majoritate
        foreach (var numar in vector)
        {
            if (frecventa == 0)
            {
                candidat = numar;
                frecventa = 1;
            }
            else if (candidat == numar)
            {
                frecventa++;
            }
            else
            {
                frecventa--;
            }
        }

        // Etapa 2: Verificare dacă candidatul este cu adevărat element majoritate
        frecventa = 0;
        foreach (var numar in vector)
        {
            if (numar == candidat)
            {
                frecventa++;
            }
        }

        // Verificare dacă candidatul este cu adevărat element majoritate
        if (frecventa > vector.Length / 2)
        {
            return candidat;
        }
        else
        {
            return -1; // Nu există element majoritate
        }
    }
}
