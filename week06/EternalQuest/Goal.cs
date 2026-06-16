using System;

public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected string _points;
    public Goal(string name, string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }
    public int GetPoints()
    {
        return int.Parse(_points);
    }

    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public virtual string GetDetailsString()
    {
        string status = IsComplete()? "[X]" : "[]";
        return $"{status}, {_shortName}, {_description}, {_points}";
    }
    public abstract string GetStringRepresentation();
    
}