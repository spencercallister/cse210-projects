class Entry
{
    public string _date;
    public string _prompt;
    public string _entry;

    List<string> _prompts = [
        "Who was the most interesting person I interacted with today?", 
        "What was the best part of my day?", 
        "How did I see the hand of the Lord in my life today?", 
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    ];

    public void SelectPrompt(List<Entry> entries)
    {
        Random random = new();

        int promptIndex;
        if (entries.Count > 4) {
            promptIndex = random.Next(_prompts.Count);
        }
        else
        {
            do  promptIndex = random.Next(_prompts.Count); while (entries.Any(entry => entry._prompt == _prompts[promptIndex]));
        }
        _prompt = _prompts[promptIndex];
    }
}