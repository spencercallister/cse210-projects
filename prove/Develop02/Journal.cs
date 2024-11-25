class Journal
{
    public List<Entry> _entries = [];
    public string _file;

    public void WriteEntry()
    {

        Entry currentEntry = new();
        
        currentEntry.SelectPrompt(_entries);

        Console.Write($"""
        {currentEntry._prompt}
        > 
        """);
        currentEntry._entry = Console.ReadLine();

        DateTime currentDateTime = DateTime.Now;
        currentEntry._date = currentDateTime.ToShortDateString();

        _entries.Add(currentEntry);
    }

    public void DisplayJournal()
    {
        foreach(Entry entry in _entries)
        {
            Console.WriteLine($"""
            Date: {entry._date} - Prompt: {entry._prompt}
            {entry._entry}

            """);
        }
    }

    public void SaveJournal()
    {
        Console.Write("What would you like to name the file? ");
        _file = Console.ReadLine();

        if (File.Exists(_file))
        {
            Console.Write("""
            File already exists. Select one of the following options:
                1. Overwrite
                2. Append
            Enter your choice: 
            """);

            string choice = Console.ReadLine();

            if (choice == "1") File.WriteAllText(_file, String.Join("\n", _entries.Select(entry => $"{entry._date}|{entry._prompt}|{entry._entry}")));
            else if (choice == "2") {
                File.AppendAllText(_file, "\n");
                File.AppendAllText(_file, String.Join("\n", _entries.Select(entry => $"{entry._date}|{entry._prompt}|{entry._entry}")));
            }
        }
        else
        {
            File.WriteAllText(_file, String.Join("\n", _entries.Select(entry => $"{entry._date}|{entry._prompt}|{entry._entry}")));
        }
    }

    public void LoadJournal()
    {
        if (_entries.Count > 0)
        {
            Console.Write("Would you like to save your current entries first? (y/n): ");
            string response = Console.ReadLine();
            if (response == "y") SaveJournal();
        }
        _entries = [];
        Console.Write("Which file would you like to load? ");
        _file = Console.ReadLine();
        string[] entries = System.IO.File.ReadAllLines(_file);

        foreach(string entry in entries)
        {
            Entry loadedEntry = new();

            string[] entryParts = entry.Split("|");
            loadedEntry._date = entryParts[0];
            loadedEntry._prompt = entryParts[1];
            loadedEntry._entry = entryParts[2];

            _entries.Add(loadedEntry);
        }
    }
}