using System;

class Program
{
    static void Main(string[] args)
    {
        GoalTracker goalTracker = new();
        bool running = true;
        do {
            Console.WriteLine($"""
            You have {goalTracker.SumPoints()} points.

            Menu Options:
                1. Create new goal
                2. List goals
                3. Save goals
                4. Load goals
                5. Record event
                6. Quit
            """);
            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            switch(choice)
            {
                case "1":
                    NewGoalMenu();
                    break;
                case "2":
                    goalTracker.ListGoals();
                    break;
                case "3":
                    goalTracker.SaveGoals();
                    break;
                case "4":
                    goalTracker.LoadGoals();
                    break;
                case "5":
                    goalTracker.RecordEvent();
                    break;
                case "6":
                    running = false;
                    break;
                default:
                    break;
            }
        } while (running);

        Goal CreateGoal(string goalType, string name, string description, string points)
        {
            Goal goal = null;
            if (goalType == "1")
            {
                goal = new Simple(name, description, Int32.Parse(points));
            }
            else if (goalType == "2")
            {
                goal = new Eternal(name, description, Int32.Parse(points));
            }
            else if (goalType == "3")
            {
                Console.Write("What is the amount of bonus points associated with this goal? ");
                string bonusPoints = Console.ReadLine();

                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                string completionLimit = Console.ReadLine();
                goal = new Checklist(name, description, Int32.Parse(points), Int32.Parse(bonusPoints), Int32.Parse(completionLimit));
            }

            return goal;
        }

        void NewGoalMenu()
        {
            Console.Write("""
            The types of goals are:
                1. Simple Goal
                2. Eternal Goal
                3. Checklist

            Which type of goal would you like to create? 
            """);
            string goalType = Console.ReadLine();

            Console.Write("What is the name of the goal? ");
            string name = Console.ReadLine();

            Console.Write("What is a short description of the goal? ");
            string description = Console.ReadLine();

            Console.Write("What is the amount of points associated with this goal? ");
            string points = Console.ReadLine();

            Goal goal = CreateGoal(goalType, name, description, points);

            goalTracker.AddGoal(goal);
        }
    }
}