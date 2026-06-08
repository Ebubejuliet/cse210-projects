using System;

public class Activity
{
    public string _name;
    public string _description;
    public int _duration;
    
    public Activity()
    {

        
    }
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to {_name}");
        Console.WriteLine($"{_description}");
        Console.WriteLine("How long, in seconds, would you like for your session?");
        _duration = int.Parse(Console.ReadLine());

        Console.Clear();
        Console.WriteLine("Get ready...");
        showSpinner(5);
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!!");
        showSpinner(5);
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} activity.");
        
    }
    public void showSpinner(int sceconds)
    {
        List<string> spinner = new List<string>
        {
            "|", "-", "/", "\\"
        };
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(sceconds);
        int i = 0;
        while (DateTime.Now < endTime)
        {
            string s = spinner[i];
            Console.Write(s);
            
            Thread.Sleep(500);
            Console.Write("\b \b");
            i++;
            if (i >= spinner.Count)
            {
                i = 0;
            }
        }
        
    }
    public void showCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(500);
            Console.Write("\b \b");
        }
        
    }


}