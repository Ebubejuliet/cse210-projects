using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> _activities = new List<Activity>();
        _activities.Add(new RunningActivity("Jun 18", 3, 5));
        _activities.Add(new SwimmingActivity("Jun 18", 45, 20));
        _activities.Add(new CyclingActivity("Jun 18", 40, 40));
        foreach (Activity activity in _activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}