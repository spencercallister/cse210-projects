public class Eternal : Goal
{
    public Eternal(string name, string description, int points, int pointsEarned = 0) : base(name, description, points, pointsEarned)
    {
    }

    public override void CheckPoints()
    {
        AddPoints();
    }

    public override string CheckBox()
    {
        return "[ ]";
    }
    
    public override string GetAllDetails()
    {
        return $"{GetType()}:{GetNameDescription(",")},{GetPoints()},{GetPointsTotal()}";
    }
    
}