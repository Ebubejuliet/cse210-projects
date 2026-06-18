using System;
using System.Diagnostics;
public class RunningActivity : Activity
{
    private double _distanceKm;
    public RunningActivity(string date, int lengthMinutes, double distanceKm) : base (date, lengthMinutes)
    {
        _distanceKm = distanceKm;
    }
    public override double GetDistance()
    {
        return _distanceKm;
    }
    public override double GetSpeed()
    {
        return (_distanceKm / GetLengthMinutes()) * 60;
    }
    public override double GetPace()
    {
        return GetLengthMinutes() / _distanceKm;
    }
}