using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new("Samuel Bennett", "Multiplication");
        string summary = assignment.GetSummary();
        Console.WriteLine(summary);

        MathAssignment mathAssignment = new("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        string mathAssignmentSummary = mathAssignment.GetSummary();
        string homeworkList = mathAssignment.GetHomeworkList();
        Console.WriteLine(mathAssignmentSummary);
        Console.WriteLine(homeworkList);

        WritingAssignment writingAssignment = new("Mary Waters", "European History", "The Causes of World War II");
        string writingAssignmentSummary = writingAssignment.GetSummary();
        string title = writingAssignment.GetWritingInformation();
        Console.WriteLine(writingAssignmentSummary);
        Console.WriteLine(title);
    }
}