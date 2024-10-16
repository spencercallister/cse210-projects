using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Fraction frac1 = new();
        Fraction frac2 = new(6);
        Fraction frac3 = new(6,7);

        Console.WriteLine(frac1.GetFractionString());
        Console.WriteLine(frac1.GetDecimalValue());

        frac2.SetTop(5);
        Console.WriteLine(frac2.GetFractionString());
        Console.WriteLine(frac2.GetDecimalValue());

        frac3.SetTop(3);
        frac3.SetBottom(4);
        Console.WriteLine(frac3.GetFractionString());
        Console.WriteLine(frac3.GetDecimalValue());

        Fraction frac4 = new();
        frac4.SetBottom(3);
        Console.WriteLine(frac4.GetFractionString());
        Console.WriteLine(frac4.GetDecimalValue());
    }
}