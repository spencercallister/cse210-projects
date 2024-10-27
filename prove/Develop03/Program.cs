using System;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

class Program
{
    
    static void Main(string[] args)
    {
        Query query = new();
        Reference reference = query.CreateReference();
        Scripture scripture = query.CreateScripture();

        string choice;
        int shownLeft;
        int totalWords;
        do
        {
            Console.Clear();

            List<int> wordCounts = scripture.RandomHide();
            shownLeft = wordCounts[0];
            totalWords = wordCounts[1];
            reference.DisplayRef();
            scripture.DisplayScripture();

            Console.Write("\n\nPress enter/return to hide more words or type 'quit' to end: ");
            choice = Console.ReadLine();
        } while(shownLeft - 3 >= 1 & !choice.Equals("quit", StringComparison.CurrentCultureIgnoreCase));
        
        if(choice == "quit") Console.WriteLine("You have ended the program."); else Console.WriteLine($"Congratulations, you have reached the end! You memorized {totalWords} words.");
    }

}