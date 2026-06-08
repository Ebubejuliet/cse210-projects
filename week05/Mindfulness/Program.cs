using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Menu Options");
        Console.WriteLine("1. Start breathing activity.");
        Console.WriteLine("2. Start listing activity.");
        Console.WriteLine("3. Start reflecting activity.");
        Console.WriteLine("4. quit.");
        Console.WriteLine("Choose from the menu: ");

        string choice = Console.ReadLine();
        if (choice == "1")
        {
            BreathingActivity breathing = new BreathingActivity();
            breathing.Run();
        }

        else if (choice == "2")
        {
            ListingActivity listing = new ListingActivity();
            listing.Run();
        }

        else if (choice == "3")
        {
            ReflectingActivity reflecting = new ReflectingActivity();
            reflecting.Run();
        }
        else
        {
            Console.WriteLine("Goodbye");
        }

    }
}