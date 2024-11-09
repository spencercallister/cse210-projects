using System;
using System.Net.NetworkInformation;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("""
        Menu Options:
            1. Start breathing activity
            2. Start reflecting activity
            3. Start listing activity
            4. Quit
        """);

        Console.Write("Select a choice from the menu: ");

        string choice = Console.ReadLine();

        switch(choice)
        {
            case "1":
                new Breathing(
                    "Breathing", 
                    "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing."
                );
                break;
            case "2":
                new Reflection(
                    "Reflection", 
                    "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.",
                    [
                        "Think of a time when you stood up for someone else.",
                        "Think of a time when you did something really difficult.",
                        "Think of a time when you helped someone in need.",
                        "Think of a time when you did something truly selfless."
                    ]
                );
                break;
            case "3":
                new Listing(
                    "Listing", 
                    "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.",
                    [
                        "Who are people that you appreciate?",
                        "What are personal strengths of yours?",
                        "Who are people that you have helped this week?",
                        "When have you felt the Holy Ghost this month?",
                        "Who are some of your personal heroes?"
                    ]
                );
                break;
            case "4":
                return;
        }
    }
}