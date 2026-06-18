using System;
public class CyclingActivity : Activity
{
    private double _speedKph;
    public CyclingActivity(string date, int lengthMintes, double speedKph) : base (date, lengthMintes)
    {
        _speedKph = speedKph;
    }
    public override double GetDistance()
    {
        return (_speedKph * GetLengthMinutes()) / 60;
    }
    public override double GetSpeed()
    {
        return _speedKph;
    }
    public override double GetPace()
    {
        return GetLengthMinutes() / GetDistance();
    }
}