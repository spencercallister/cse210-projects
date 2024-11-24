public class Simple : Goal
{
    public Simple(string name, string description, int points, int pointsEarned = 0) : base(name, description, points, pointsEarned)
    {}

    public override string CheckBox()
    {
        return GetCompleted() ? "[X]" : "[ ]";
    }

    public override void CheckPoints()
    {
        if(GetCompleted()) return;
        AddPoints();
    }
    public override string GetAllDetails()
    {
        return $"{GetType()}:{GetNameDescription(",")},{GetPoints()},{GetPointsTotal()},{GetCompleted()}";
    }
}