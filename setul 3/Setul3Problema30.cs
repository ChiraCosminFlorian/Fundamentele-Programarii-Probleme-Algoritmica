using System;

public class Element : IComparable<Element>
{
    public int Value { get; set; }
    public int Weight { get; set; }

    // Implementarea metodei CompareTo pentru sortarea bicriterială
    public int CompareTo(Element other)
    {
        // Comparăm valorile (E) în ordine crescătoare
        int valueComparison = this.Value.CompareTo(other.Value);

        if (valueComparison == 0)
        {
            // Dacă valorile sunt egale, comparăm ponderile (W) în ordine descrescătoare
            return other.Weight.CompareTo(this.Weight);
        }

        return valueComparison;
    }
}

class Program
{
    static void Main()
    {
        // Exemplu de utilizare

        // Vectorul E
        int[] E = { 5, 2, 8, 5, 1 };

        // Vectorul W
        int[] W = { 10, 5, 8, 12, 3 };

        // Creăm un vector de elemente
        Element[] elements = new Element[E.Length];

        // Populăm vectorul de elemente
        for (int i = 0; i < E.Length; i++)
        {
            elements[i] = new Element { Value = E[i], Weight = W[i] };
        }

        // Sortăm vectorul de elemente
        Array.Sort(elements);

        // Afișăm rezultatul
        Console.WriteLine("Vectorul sortat bicriterial:");
        foreach (var element in elements)
        {
            Console.WriteLine($"Value: {element.Value}, Weight: {element.Weight}");
        }
    }
}
