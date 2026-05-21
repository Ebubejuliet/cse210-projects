using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade? ");
        string userInput = Console.ReadLine();
        int Number = int.Parse(userInput);

        string letter = "";

        if (Number >= 90)
        {
            letter = "A";
            
        }
        else if (Number >= 80)
        {
            letter = "B";
            
        }
        else if (Number >= 70)
        {
            letter = "C";
        }
        else
        {
            letter = "F";
        }
        Console.WriteLine($"Your score is {letter}");

        if (Number >= 70)
        {
            Console.Write("Congratulations you passed!");
        }
        else
        {
            Console.WriteLine("Work hard next time");
        }

    }
}