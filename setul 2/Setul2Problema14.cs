using System;

class Program
{
    static void Main()
    {
        // Exemplu de utilizare
        int[] secventa = { 4, 5, 6, 7, 1, 2, 3 };

        // Verificăm dacă secvența este o secvență montonă rotită
        bool rezultat = EsteSecventaMonotonaRotita(secventa);

        // Afișăm rezultatul
        if (rezultat)
        {
            Console.WriteLine("Secvența este o secvență montonă rotită.");
        }
        else
        {
            Console.WriteLine("Secvența nu este o secvență montonă rotită.");
        }
    }

    // Funcția pentru verificarea dacă o secvență este o secvență montonă rotită
    static bool EsteSecventaMonotonaRotita(int[] secventa)
    {
        int n = secventa.Length;

        // Caz special: secvența vidă sau cu un singur element este considerată montonă rotită
        if (n <= 1)
        {
            return true;
        }

        // Găsim punctul de ruptură în secvență
        int punctRuptura = GasestePunctRuptura(secventa);

        // Dacă nu există punct de ruptură, secvența este deja montonă rotită
        if (punctRuptura == -1)
        {
            return true;
        }

        // Verificăm dacă secvența poate fi transformată într-o secvență montonă prin rotiri succesive
        return EsteSecventaMonotona(secventa, punctRuptura);
    }

    // Funcția pentru găsirea punctului de ruptură în secvență
    static int GasestePunctRuptura(int[] secventa)
    {
        int n = secventa.Length;

        for (int i = 0; i < n - 1; i++)
        {
            if (secventa[i] > secventa[i + 1])
            {
                return i + 1; // Am găsit punctul de ruptură
            }
        }

        // Nu există punct de ruptură, secvența este deja montonă rotită
        return -1;
    }

    // Funcția pentru verificarea dacă secvența poate fi transformată într-o secvență montonă prin rotiri succesive
    static bool EsteSecventaMonotona(int[] secventa, int punctRuptura)
    {
        int n = secventa.Length;

        // Verificăm dacă secvența este strict crescătoare în partea dreaptă a punctului de ruptură
        for (int i = punctRuptura; i < n - 1; i++)
        {
            if (secventa[i] > secventa[i + 1])
            {
                return false;
            }
        }

        // Verificăm dacă secvența este strict crescătoare în partea stângă a punctului de ruptură
        for (int i = 0; i < punctRuptura - 1; i++)
        {
            if (secventa[i] > secventa[i + 1])
            {
                return false;
            }
        }

        return true; // Secvența poate fi transformată într-o secvență montonă prin rotiri succesive
    }
}
