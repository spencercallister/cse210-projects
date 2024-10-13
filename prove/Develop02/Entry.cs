class Entry
{
    public string _date;
    public string _prompt;
    public string _entry;

    public string SelectPrompt()
    {
        Random random = new();
        List<string> prompts = ["prompt1", "prompt2", "prompt3", "prompt4"];

        int promptIndex = random.Next(prompts.Count);
        string prompt = prompts[promptIndex];
        return prompt;
    }

    public void WriteEntry(Journal currentJournal)
    {

        this._prompt = SelectPrompt();

        Console.WriteLine(this._prompt);
        this._entry = Console.ReadLine();

        DateTime currentDateTime = DateTime.Now;
        this._date = currentDateTime.ToShortDateString();

        currentJournal._entries.Add(this);

    }
}