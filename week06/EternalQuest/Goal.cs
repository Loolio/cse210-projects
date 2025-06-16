using System.Diagnostics.Contracts;

public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent();
    public virtual string GetDetailsString()
    {
        return $"{_name}: {_description} (Points: {_points})";
    }
    public virtual bool IsComplete()
    {
        return false; // Default implementation, can be overridden
    }
    public int GetPoints() => _points;
    public abstract string GetStringRepresentation();
}
