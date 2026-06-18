using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> _activities = new List<Activity>();
        _activities.Add(new RunningActivity("18 Jun 2026", 3, 5));
        _activities.Add(new SwimmingActivity("18 Jun 2026", 45, 20));
        _activities.Add(new CyclingActivity("18 Jun 2026", 40, 40));
        foreach (Activity activity in _activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}