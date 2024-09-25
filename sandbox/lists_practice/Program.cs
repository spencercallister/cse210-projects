// See https://aka.ms/new-console-template for more information
// List<double> x;
List<double> x = new();
// x = [24.0533,25.4245,26.85754];
// x = [];

// x.Add(46.84);
Console.WriteLine("Hello, World!");

// gather data to fill a list

double input = -1;
while(input != 0)
{
    Console.Write("Enter something: ");
    string inputString = Console.ReadLine();
    input = double.Parse(inputString);
    x.Add(input);
}

foreach (double number in x)
{
    Console.WriteLine(number);
}