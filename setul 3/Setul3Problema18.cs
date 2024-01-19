using System;

class Program
{
    static void Main()
    {
        // Exemplu: coeficienții polinomului 2x^3 + 3x^2 - 5x + 7
        double[] coefficientVector = { 7, -5, 3, 2 };

        Console.Write("Introduceti valoarea lui x: ");
        double x = Convert.ToDouble(Console.ReadLine());

        double result = EvaluatePolynomial(coefficientVector, x);

        Console.WriteLine($"Valoarea polinomului în punctul {x} este: {result}");
    }

    static double EvaluatePolynomial(double[] coefficients, double x)
    {
        int n = coefficients.Length - 1; // Gradul polinomului

        double result = 0;

        for (int i = 0; i <= n; i++)
        {
            result += coefficients[i] * Math.Pow(x, i);
        }

        return result;
    }
}
