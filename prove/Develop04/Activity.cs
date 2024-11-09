public class Activity
{
    private string _name;
    private string _description;

    private List<string> _prompts;
    private int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public Activity(string name, string description, List<string> prompts)
    {
        _name = name;
        _description = description;
        _prompts = prompts;
    }

    public void StartMessage()
    {
        Console.Clear();
        Console.Write($"""
        Welcome to the {_name} Activity.

        {_description}

        For how long in seconds would you like the session to last: 
        """);

        string duration = Console.ReadLine();
        _duration = Int32.Parse(duration);
        Console.Clear();
        Console.WriteLine("Get Ready...");
        Pause();
        Console.WriteLine("");
    }

    public static void Pause()
    {
        for(int i = 0; i < 10; i++)
        {
            Spinner("|");
            Spinner("/");
            Spinner("-");
            Spinner("\\");
        }
    }

    public static void Spinner(string position)
    {
        Console.Write(position);
        Thread.Sleep(125);
        Console.Write("\b \b");
    }
    public static void Counter(int countLimit)
    {        
        for (int i = countLimit; i > 0; i--)
        {
            Console.Write($"{i}\b");
            Thread.Sleep(1000);
        }
    }

    public static int SelectRandomIndex(List<string> prompts)
    {
        Random random = new();
        int randomIndex = random.Next(0, prompts.Count);

        return randomIndex;
    }

    public void Execute(Action func)
    {
        DateTime baseTime = DateTime.Now;
        DateTime endTime = baseTime.AddSeconds(_duration);
        DateTime currentTime = baseTime;
        do {
            func.Invoke();
            currentTime = DateTime.Now;
        }
        while(currentTime < endTime);
    }

    public void EndMessage()
    {
        // Console.Clear();
        // Console.WriteLine("");
        Console.WriteLine("Well done!!");
        Pause();
        Console.WriteLine($"\nYou have completed another {_duration} seconds of the {_name} activity.");
        Pause();
        Console.Clear();
    }

}