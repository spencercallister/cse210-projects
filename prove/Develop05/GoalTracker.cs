using System.Diagnostics;

public class GoalTracker
{
    private List<Goal> _goals = [];

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public int SumPoints()
    {
        return _goals.Sum(goal => goal.GetPointsTotal());
    }

    public void RecordEvent()
    {
        NumberGoals(goal => goal.GetName());
        Console.Write("Which goal did you accomplish? ");
        int goalIndex = Int32.Parse(Console.ReadLine()) - 1;
        Goal goal = _goals[goalIndex];
        goal.CheckPoints();
        Console.WriteLine($"""
        Congratulations! You have earned {goal.GetAllPoints()} points!
        You now have {SumPoints()} points.
        """);
    }

    public void ListGoals()
    {
        NumberGoals(goal => goal.GetDetails());
        // Console.WriteLine($"You have {SumPoints()} points.");
    }

    public void NumberGoals(Func<Goal, string> selector)
    {
        Console.WriteLine("The goals are:");
        foreach(Goal goal in _goals)
        {
            Console.WriteLine($"{_goals.IndexOf(goal)+1}. {selector(goal)}");
        }
    }

    public List<Goal> ReadFile(string filePath)
    {
        List<Goal> loadedGoals = [];
        string[] lines = File.ReadAllLines(filePath);
        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(',');
            string type = parts[0].Split(':')[0];
            string name = parts[0].Split(":")[1];
            string description = parts[1];
            int points = Int32.Parse(parts[2]);
            int pointsEarned = Int32.Parse(parts[3]);

            Goal loadedGoal = null;
            if(type == "Simple")
            {
                loadedGoal = new Simple(name, description, points, pointsEarned);
            }
            else if (type == "Eternal")
            {
                loadedGoal = new Eternal(name, description, points, pointsEarned);
            }
            else if (type == "Checklist")
            {
                int bonusPoints = Int32.Parse(parts[4]);
                int completionLimit = Int32.Parse(parts[5]);
                int timesCompleted = Int32.Parse(parts[6]);
                loadedGoal = new Checklist(name, description, points, bonusPoints, completionLimit, timesCompleted, pointsEarned);
            }

            loadedGoals.Add(loadedGoal);

        }
        return loadedGoals;
    }

    public void WriteFile(string filePath)
    {
        File.WriteAllText(filePath, SumPoints() + "\n");
        File.AppendAllText(filePath, String.Join("\n", _goals.Select(goal => goal.GetAllDetails())));
    }

    public void Append(string filePath)
    {
        List<Goal> goals = ReadFile(filePath);
        _goals.AddRange(goals);

        WriteFile(filePath);
    }

    public void SaveGoals()
    {
        Console.Write("What would you like to name the file? ");
        string filePath = $"{Console.ReadLine()}.txt";
        if(File.Exists(filePath))
        {
            Console.WriteLine("""
            Select a save method:
                1. Overwrite
                2. Append
            """);
            Console.Write("Enter your choice: ");
            int choice = Int32.Parse(Console.ReadLine());
            if(choice == 1) WriteFile(filePath); else Append(filePath);
            // _goals = [];
        }
        else
        {
            WriteFile(filePath);
        }
    }

    public void LoadGoals()
    {
        Console.Write("Which file would you like to load? ");
        string filePath = $"{Console.ReadLine()}.txt";
        List<Goal> goals = ReadFile(filePath);
        _goals = goals;
    }
}