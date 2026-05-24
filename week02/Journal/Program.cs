using System;

// I used Json to load and read file.
class Program
{
    public Journal journal = new Journal();
    public PromptGenerator promptGenerator = new PromptGenerator();
    public void Menu()

    {

        Console.WriteLine("\n--- Journal Menu ---");

        Console.WriteLine("1. Write a new entry");

        Console.WriteLine("2. Display the journal");

        Console.WriteLine("3. Save the journal to a file");

        Console.WriteLine("4. Load the journal from a file");

        Console.WriteLine("5. Quit");

    }



    public void Run()

    {

        while (true)

        {

            Menu();

            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();



            if (choice == "1")

            {

                string prompt = promptGenerator.GetRandomprompt();

                Console.WriteLine($"\nPrompt: {prompt}");

                Console.Write("Your response: ");

                string response = Console.ReadLine();

                journal.AddEntry(prompt, response);

            }

            else if (choice == "2")



            {

                journal.DisplayEntries();

                

            }

                

            else if (choice == "3")

            {

                

                Console.Write("Enter filename to save: ");

                string saveFile = Console.ReadLine();

                journal.SaveToFile(saveFile);

            }

            else if (choice == "4")

            {

                Console.Write("Enter filename to load: ");

                string loadFile = Console.ReadLine();

                journal.LoadFromFile(loadFile);

            }

            else if (choice == "5")

            {

                Console.WriteLine("Goodbye");
                break;

            }

        }  

    }
    public static void Main(string[] args)
    {
        Program program = new Program();
        program.Run();
    } 

    
}