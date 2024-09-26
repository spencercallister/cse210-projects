using System;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string favoriteNumberString = Console.ReadLine();
        int favoriteNumber = Int32.Parse(favoriteNumberString);

        return favoriteNumber;
    }

    static int SquareNumber(int favoriteNumber) 
    {
        int squareNumber = favoriteNumber * favoriteNumber;

        return squareNumber;
    }

    static void DisplayResult(string name, int squareNumber) {
        Console.WriteLine($"{name}, the square of your number is {squareNumber}.");
    }

    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squareNumber = SquareNumber(userNumber);
        DisplayResult(userName, squareNumber);

    }
}