using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.Write("What is the magic number? ");
        // string magicNumberString = Console.ReadLine();
        // int magicNumber = Int32.Parse(magicNumberString);

        string playAgain;

        do {

            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1,100);

            string guessString;
            int guess;
            int guessCount = 0;

            do {
                Console.Write("What is your guess? ");
                guessString = Console.ReadLine();
                guess = Int32.Parse(guessString);

                guessCount++;

                if (guess < magicNumber) 
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber) 
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine($"You successfully guessed it on try {guessCount}.");
                }

            } while (guess != magicNumber);

            Console.Write("Would you like to play again? ");
            playAgain = Console.ReadLine().ToLower();

        } while (playAgain == "yes");

    }
}