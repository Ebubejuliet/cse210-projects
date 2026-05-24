using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

// I used Json to load and save file.
public class Journal
{
    private List<JournalEntry> entries = new List<JournalEntry>();

    public void AddEntry(string prompt, string response)
    {
        string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        JournalEntry entry = new JournalEntry(prompt, response, date);
        entries.Add(entry);
    }

    public void DisplayEntries()
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("\nNo entries yet.");
        }
        else
        {
            int i = 1;
            foreach (JournalEntry entry in entries)
            {
                Console.WriteLine($"\nEntry {i}");
                Console.WriteLine($"Date: {entry.Date}");
                Console.WriteLine($"Prompt: {entry.Prompt}");
                Console.WriteLine($"Response: {entry.Response}");
                i++;
            }
        }
    }

    public void SaveToFile(string filename)
    {
        string json = JsonSerializer.Serialize(entries, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(filename, json);
        Console.WriteLine($"\nJournal saved to {filename}");
    }

    public void LoadFromFile(string filename)
    {
        if (File.Exists(filename))
        {
            string json = File.ReadAllText(filename);
            entries = JsonSerializer.Deserialize<List<JournalEntry>>(json);
            Console.WriteLine($"\nJournal loaded from {filename}");
        }
        else
        {
            Console.WriteLine("\nFile not found.");
        }
    }
}