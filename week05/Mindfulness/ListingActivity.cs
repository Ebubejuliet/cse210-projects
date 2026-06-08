using System;
using System.ComponentModel.DataAnnotations;
public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;
    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _prompts = new List<string>()
        {
            
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }
    public void Run()
    {
        DisplayStartingMessage();
        GetRandomPrompt();
        Console.WriteLine("List as many responses as you can to the following prompt:");
        showCountDown(5);
        
        List<string> userList = GetListFromUser();
        _count = userList.Count;
        DisplayEndingMessage();
    }
    public void GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        string prompt = _prompts[index];
        Console.WriteLine(prompt);
    }
    public List<string> GetListFromUser()
    {
        List<string> responses = new List<string>();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            string response = Console.ReadLine();
            responses.Add(response);
        }
        return responses;
    }
}