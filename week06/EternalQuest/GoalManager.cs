using System;
using System.IO;
public class GoalManager
{
    private List<Goal> _goals;
    private int _score;
    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }
    public void Start()
    {
        int choice = 0;
        while (choice != 6)
        {
            DisplayPLayerInfo();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1: Create New Goal");
            Console.WriteLine("2: List Goals");
            Console.WriteLine("3: Save Goals");
            Console.WriteLine("4: Load Goals");
            Console.WriteLine("5: Record Event");
            Console.WriteLine("6: Quit");
            Console.WriteLine("Choose from the Menu Options");
            choice = int.Parse(Console.ReadLine());
        
            if (choice == 1) CreateGoal();
            else if (choice == 2) ListGoalDetails();
            
            else if (choice == 3) SaveGoals();
            
            else if (choice == 4) LoadGoals();
            
            else if (choice == 5) RecordEvent();
            else if (choice == 6) Console.WriteLine("Goodbye!");
        
        }
        

        
    }
    public void DisplayPLayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
        
    }
    public void ListGoalNames()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i+1}. {_goals[i].GetDetailsString()}");
        }
        
    }
    public void ListGoalDetails()
    {
        ListGoalNames();
        
    }
    public void CreateGoal()
    {
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.WriteLine("Which type of goal would you like to create?");
        int choice = int.Parse(Console.ReadLine());
        Console.WriteLine("What is the name of your goal?");
        string name = Console.ReadLine();
        Console.WriteLine("What is a short description of it?");
        string description = Console.ReadLine();
        Console.WriteLine("How many points is it worth?");
        int points = int.Parse(Console.ReadLine());
        if (choice == 1)
        {
            _goals.Add(new SimpleGoal(name, description, points));
        }
        else if (choice == 2)
        {
            _goals.Add(new EternalGoal(name, description, points));
        }
        else if (choice == 3)
        {
            Console.WriteLine("How many times does this goal need to be accomplished for a bonus?");
            int target = int.Parse(Console.ReadLine());
            Console.WriteLine("What is the bonus for accomplishing it that many times?");
            int bonus = int.Parse(Console.ReadLine());
            _goals.Add(new CheckListGoal(name, description, points, target, bonus, 0));
        }
        
    }
    public void RecordEvent()
    {
        ListGoalNames();
        Console.WriteLine("Which goal did you accomplish?");
        int choice = int.Parse(Console.ReadLine());
        if (choice >= 0 && choice < _goals.Count)
        {
            Goal goal = _goals[choice - 1];
            bool wasIsComplete = goal.IsComplete();
            goal.RecordEvent();
            if (!wasIsComplete)
            {
                _score += goal.GetPoints();
                Console.WriteLine($"Congratulations! You have earned {goal.GetPoints} points!");
            }
        }
        
    }
    public void SaveGoals()
    {
        Console.WriteLine("What is the filename for the goal file?");
        string filename = Console.ReadLine();
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
        
    }
    public void LoadGoals()
    {
        Console.WriteLine("What is the filename for the goal file?");
        string filename = Console.ReadLine();
        string[] lines = File.ReadAllLines(filename);
        _score = int.Parse(lines[0]);
        _goals.Clear();
        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(":");
            string type = parts[0];
            string[] attributes = parts[1].Split(",");
            for (int j = 0; j< attributes.Length; j++)
            {
                attributes[j] = attributes[j].Trim();
            }
            if (type == "SimpleGoal")
            {
                string name = attributes[0];
                string description = attributes[1];
                int points = int.Parse(attributes[2]);
                _goals.Add(new SimpleGoal(name, description, points));
                Console.WriteLine($"Loaded SimpleGoal: {name}, {description}, {points}");
            }
            else if (type == "EternalGoal")
            {
                string name = attributes[0];
                string description = attributes[1];
                int points = int.Parse(attributes[2]);
                _goals.Add(new EternalGoal(name, description, points));
                Console.WriteLine($"Loaded EternalGoal: {name}, {description}, {points}");

            }
            else if (type == "CheckListGoal")
            {
                string name = attributes[0];
                string description = attributes[1];
                int points = int.Parse(attributes[2]);
                int bonus = int.Parse(attributes[3]);
                int target = int.Parse(attributes[4]);
                int amountCompleted = int.Parse(attributes[5]);
                _goals.Add(new CheckListGoal(name, description, points, target, bonus, amountCompleted));

                Console.WriteLine($"Loaded checklist goal '{name}' with {amountCompleted}/{target} completed.");
      
            }
        }
        
    }
}