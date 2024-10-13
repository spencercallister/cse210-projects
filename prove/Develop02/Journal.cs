
class Journal
{
    public List<Entry> _entries = [];
    public string _file;


    public void SaveEntries()
    {
        Console.Write("What would you like to name the file? ");
        _file = Console.ReadLine();

        using StreamWriter journalFile = new($"prove/Develop02/journals/{_file}");
        foreach (Entry entry in _entries)
        {
            journalFile.WriteLine($"{entry._date}|{entry._prompt}|{entry._entry}");
        }

    }

    public Journal LoadJournal()
    {
        Journal loadedJournal = new();

        Console.Write("Which file would you like to load? ");
        _file = Console.ReadLine();
        string[] entries = System.IO.File.ReadAllLines($"prove/Develop02/journals/{_file}");

        foreach(string entry in entries)
        {
            Entry loadedEntry = new();

            string[] entryParts = entry.Split("|");
            loadedEntry._date = entryParts[0];
            loadedEntry._prompt = entryParts[1];
            loadedEntry._entry = entryParts[2];

            loadedJournal._entries.Add(loadedEntry);

        }
        return loadedJournal;
    }

    public void ReadJournal()
    {
        foreach(Entry entry in _entries)
        {
            Console.WriteLine($"{entry._date} | {entry._prompt} | {entry._entry}");
        }

    }
}