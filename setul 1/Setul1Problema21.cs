using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Alegeți un număr între 1 și 1024 inclusiv.");
        GhicesteNumarul(1, 1024);
    }

    static void GhicesteNumarul(int limitaInferioara, int limitaSuperioara)
    {
        while (true)
        {
            int ghicit = (limitaInferioara + limitaSuperioara) / 2;

            Console.WriteLine($"Este numărul mai mare sau egal cu {ghicit}? (1 pentru da, 0 pentru nu)");
            int raspuns;

            while (!int.TryParse(Console.ReadLine(), out raspuns) || (raspuns != 0 && raspuns != 1))
            {
                Console.WriteLine("Te rog să introduci 0 pentru 'nu' sau 1 pentru 'da'.");
            }

            if (raspuns == 1)
            {
                // Numărul este mai mare sau egal cu ghicit
                limitaInferioara = ghicit;

            }
            else
            {
                // Numărul este mai mic decât ghicit
                limitaSuperioara = ghicit - 1;
            }

            // Verificăm dacă am ghicit numărul
            if (limitaInferioara == limitaSuperioara)
            {
                Console.WriteLine($"Numărul este {limitaInferioara}!");
                break;
            }
        }
    }
}
