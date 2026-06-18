using System;
public class CheckListGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    public CheckListGoal(string name, string description, int points, int target, int bonus, int amountCompleted) : base (name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = amountCompleted;
        
    }
    public override void RecordEvent()
    {
        _amountCompleted++;
    }
    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }
    public override string GetDetailsString()
    {
        string status = IsComplete()? "[X]" : "[]";
        return $"{_shortName}, {_description}, {_points} -- Currently Completed: {_amountCompleted}/{_target}";
    }
    public override string GetStringRepresentation()
    {
        return $"CheckListGoal: {_shortName}, {_description}, {_points}, {_bonus}, {_target}, {_amountCompleted}";
    }
}