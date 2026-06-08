using System;
public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }
    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("Breathe in...");
        showCountDown(5);
        Console.WriteLine("Breathe out...");
        showCountDown(5);
        DisplayEndingMessage();
    }
}