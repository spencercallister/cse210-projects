namespace functions_practice;

class Program
{
    static void AwesomeFunction(int x)
    {
        Console.WriteLine($"The argument received by the awesome function is {x}.");
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        AwesomeFunction(188999);
    }
}
