using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        entries.Add(entry);
    }

    public void DisplayEntries()
    {
        foreach (var entry in entries)
        {
            Console.WriteLine($"Date: {entry.Date}");
            Console.WriteLine($"Time of Day: {entry.TimeOfDay}");
            Console.WriteLine($"Mood Rating: {entry.MoodRating}");
            Console.WriteLine($"Prompt: {entry.Prompt}");
            Console.WriteLine($"Response: {entry.Response}\n");
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in entries)
            {
                writer.WriteLine(entry.ToString());
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        entries.Clear();
        foreach (var line in File.ReadAllLines(filename))
        {
            var parts = line.Split('|');
            if (parts.Length == 5)
            {
                string date = parts[0];
                string timeOfDay = parts[1];
                int moodRating = int.Parse(parts[2]);
                string prompt = parts[3];
                string response = parts[4];
                entries.Add(new Entry(prompt, response, date, timeOfDay, moodRating));
            }
        }
    }




}