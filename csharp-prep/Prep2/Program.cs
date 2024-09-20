using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string gradeString = Console.ReadLine();
        int gradeInt = int.Parse(gradeString);

        string letter;

        if (gradeInt >= 90) {
            letter = "A";
        }
        else if (gradeInt >= 80) {
            letter = "B";
        }
        else if (gradeInt >= 70) {
            letter = "C";
        }
        else if (gradeInt >= 60) {
            letter = "D";
        }
        else {
            letter = "F";
        }

        string sign;
        int lastDigit = gradeInt % 10;

        if (lastDigit >= 7 && gradeInt < 90 && gradeInt >= 60) {
            sign = "+";
        }
        else if (lastDigit < 3 && gradeInt < 93 && gradeInt >= 60) {
            sign = "-";
        }
        else {
            sign = "";
        }

        Console.WriteLine($"Your grade is: {letter}{sign}");

        if (gradeInt >= 70) {
            Console.WriteLine("Congratulations! You have passed the class!");
        }
        else {
            Console.WriteLine("Unfortunately you did not pass the class. Better luck next time!");
        }

    }
}