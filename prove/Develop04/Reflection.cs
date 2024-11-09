public class Reflection : Activity
{
    List<string> _questions = [
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    ];
    public Reflection(string name, string description, List<string> prompts) : base(name, description, prompts)
    {
        StartMessage();
        int promptIndex = SelectRandomIndex(prompts);
        Console.WriteLine($"""
        Consider the following prompt:

        --- {prompts[promptIndex]} ---

        When you have something in mind, press enter to continue.
        """);

        Console.ReadLine();

        Console.Write("""
        Now ponder on each of the following questions as they related to this experience.
        You may begin in: 
        """);

        Counter(5);
        Console.Clear();
        Execute(DisplayQuestions);
        // prompts.RemoveAt(promptIndex);
        Console.WriteLine("");
        EndMessage();
    }

    public void DisplayQuestions()
    {
        int promptIndex = SelectRandomIndex(_questions);
        Console.Write($"> {_questions[promptIndex]} ");
        _questions.RemoveAt(promptIndex);
        Pause();
        Console.Write("\n");
    }
}