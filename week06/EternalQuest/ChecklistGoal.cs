using System;
public class CheckListGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    public CheckListGoal(string name, string description, string points, int target, int bonus) : base (name, description, points)
    {
        target = _target;
        bonus = _bonus;
        _amountCompleted = 0;
        
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