using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, one at a time. Type 0 when finished.");

        List<int> numbers = new();

        string userNumberString;
        
        do {
            Console.Write("Enter a number: ");
            userNumberString = Console.ReadLine();
            int userNumber = Int32.Parse(userNumberString);

            numbers.Add(userNumber);

        } while (userNumberString != "0");

        int sum = numbers.Sum();
        double mean = numbers.Average();
        int max = numbers.Max();

        numbers.Sort();

        List<int> positives = new();

        foreach(int x in numbers) {
            if (x > 0) {
                positives.Add(x);
            }
        }

        int minPositive = positives.Min();

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {mean}");
        Console.WriteLine($"The largest number is: {max}");
        Console.WriteLine($"The smallest positive number is: {minPositive}");
        Console.WriteLine("The sorted list is:");
        foreach(int x in numbers) {
            Console.WriteLine(x);
        }
    }
}