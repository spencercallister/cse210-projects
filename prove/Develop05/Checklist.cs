using System.ComponentModel.DataAnnotations.Schema;

public class Checklist : Goal
{
    private int _bonusPoints;
    private int _completionLimit; 
    private int _timesCompleted;

    public Checklist(string name, string description, int points, int bonusPoints, int completionLimit, int timesCompleted = 0, int pointsEarned = 0) : base(name, description, points, pointsEarned)
    {
        _bonusPoints = bonusPoints;
        _completionLimit = completionLimit;
        _timesCompleted = timesCompleted;
    }

    public override void CheckPoints()
    {
        if (_timesCompleted > _completionLimit) return;
        _timesCompleted++;
        AddPoints();
    }

    public override void AddPoints()
    {
       if (_timesCompleted == _completionLimit) SetPointsTotal(GetAllPoints() + _bonusPoints); else SetPointsTotal(GetAllPoints());
    }

    public override string CheckBox()
    {
        return _timesCompleted == _completionLimit ? "[X]" : "[ ]";
    }

    public override string GetDetails()
    {
        return $"{CheckBox()} {GetNameDescription(" (")}) -- Currently completed: {_timesCompleted}/{_completionLimit}";
    }

    public override string GetAllDetails()
    {
        return $"{GetType()}:{GetNameDescription(",")},{GetPoints()},{GetPointsTotal()},{_bonusPoints},{_completionLimit},{_timesCompleted}";
    }
}