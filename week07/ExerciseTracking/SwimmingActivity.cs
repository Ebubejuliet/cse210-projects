using System;
public class SwimmingActivity : Activity
{
    private int _laps;
    public SwimmingActivity(string date, int lengthMinutes, int laps) : base (date, lengthMinutes)
    {
        _laps = laps;
    }
    public override double GetDistance()
    {
        return (_laps * 50) / 1000.0;
    }
    public override double GetSpeed()
    {
        return (GetDistance() / GetLengthMinutes()) * 60;
    }
    public override double GetPace()
    {
        return GetLengthMinutes() / GetDistance();
    }
}