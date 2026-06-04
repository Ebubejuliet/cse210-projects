using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("John", 3, 16);
        Scripture scripture = new Scripture(reference, "For God so loved the world that He gave His only begotten son that whosoever believeth in Him should not perish but have everlasting life.");
        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide more words, or type 'quit' to exit:");

            string input = Console.ReadLine();

            // Case-insensitive check without LINQ
            if (!string.IsNullOrEmpty(input) && 
                input.Equals("quit", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Exiting program. Goodbye!");
                return; // end the program
            }

            // Hide a fixed number of words each round
            scripture.HideRandomWords(2);
        }

        Console.Clear();
        Console.WriteLine("All words are hidden. Well done!");
    

        
    }
}