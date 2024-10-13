using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Choose the number of one of the following options:\n 1. Write a new entry\n 2. Display the journal\n 3. Save the journal to a file\n 4. Load the journal from a file\n Type 'c' to quit.");
        string choice = Console.ReadLine();
        
        Entry currentEntry = new();
        Journal currentJournal = new();

        do
        {
            switch (choice)
            {
                default:
                    currentEntry.WriteEntry(currentJournal);
                    break;

                case "2":
                    currentJournal.ReadJournal();
                    break;

                case "3":
                    currentJournal.SaveEntries();
                    break;

                case "4":
                    if (currentJournal._entries.Count > 0)
                    {
                        Console.Write("Would you like to save your current entries? ");
                        string saveCurrentEntries = Console.ReadLine().ToLower();
                        if (saveCurrentEntries == "yes") currentJournal.SaveEntries();
                        break;
                    }
                    currentJournal = currentJournal.LoadJournal();
                    break;

                case "c":
                    break;
            }
        }
        while (choice != "c");
    }
}