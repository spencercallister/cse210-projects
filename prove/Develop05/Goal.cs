public abstract class Goal
{
    private string _name;
    private string _description;
    private int _points;
    private int _pointsEarned;

    public Goal(string name, string description, int points, int pointsEarned)
    {
        _name = name;
        _description = description;
        _points = points;
        _pointsEarned = pointsEarned;
    }

    public virtual void AddPoints()
    {
        _pointsEarned += _points;
    }

    public abstract void CheckPoints();

    public abstract string CheckBox();

    public string GetName()
    {
        return _name;
    }

    public void SetPointsTotal(int toAdd)
    {
        _pointsEarned += toAdd;
    }

    public int GetPointsTotal()
    {
        return _pointsEarned;
    }

    // public void SetPointsTotal(int pointsEarned)
    // {
    //     _pointsEarned = pointsEarned;
    // }

    public bool GetCompleted()
    {
        return _pointsEarned == _points;
    }

    public string GetNameDescription(string delimiter)
    {
        return $"{_name}{delimiter}{_description}";
    }

    public virtual int GetPoints()
    {
        return _points;
    }

    public virtual int GetAllPoints()
    {
        return GetPoints();
    }

    public virtual string GetDetails()
    {
        return $"{CheckBox()} {GetNameDescription(" (")})";
    }

    public abstract string GetAllDetails();
}