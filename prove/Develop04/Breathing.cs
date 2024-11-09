public class Breathing : Activity
{

    public Breathing(string name, string description) : base(name, description)
    {
        StartMessage();
        Execute(BreatheMessage);
        EndMessage();
    }

    private static void BreatheMessage()
    {
        Console.Write("Breathe in...");
        Counter(4);
        Console.Write("\nBreathe out...");
        Counter(6);
        Console.WriteLine("\n");
    }

}