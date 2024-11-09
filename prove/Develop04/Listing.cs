public class Listing : Activity
{
    List<string> _entries = [];
    public Listing(string name, string description, List<string> prompts) : base(name, description, prompts)
    {
        StartMessage();
        int promptIndex = SelectRandomIndex(prompts);

        Console.Write($"""
        List as many responses as you can to the following prompt:
        --- {prompts[promptIndex]} ---
        You may begin in: 
        """);
        Counter(5);
        Console.WriteLine("");
        Execute(ReceiveEntries);
        // prompts.RemoveAt(promptIndex);
        Console.WriteLine($"You listed {_entries.Count} items!\n");
        EndMessage();
    }

    public void ReceiveEntries()
    {
        Console.Write("> ");
        string entry = Console.ReadLine();
        _entries.Add(entry);
    }
}