using System;

class Program
{
    static void Main(string[] args)
    {
        Journal currentJournal = new();
        string choice;
        do
        {
            Console.Write("""
            Please select one of the following options:
                1. Write
                2. Display
                3. Load
                4. Save
                5. Quit

            What would you like to do? 
            """);
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    currentJournal.WriteEntry();
                    break;

                case "2":
                    currentJournal.DisplayJournal();
                    break;

                case "3":
                    currentJournal.LoadJournal();
                    break;

                case "4":
                    currentJournal.SaveJournal();
                    break;
                default:
                    break;
            }
        }
        while (choice != "5");
    }
}