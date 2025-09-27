// SHOWING CREATIVITY AND EXCEEDING REQUIREMENTS:
// - Added ability for users to record the 'Time of Day' when writing a journal entry (eg: morning, afternoon, evening).
// - Included a 'Mood Rating' on a scale of 1 to 10 to help users reflect on their emotional state during the entry.
// - Updated Entry class, Journal saving/loading, and user prompts to support these new fields.
// These features encourage deeper reflection and provide richer context for journal entries.


using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");

        Journal journal = new Journal();
        PromptGenerator promptGen = new PromptGenerator();
        string choice;

        do
        {
            Console.WriteLine("Welcome to the Journal Menu:");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    string prompt = promptGen.GetRandomPrompt();
                    Console.WriteLine(prompt);
                    string response = Console.ReadLine();
                    string date = DateTime.Now.ToShortDateString();

                    Console.Write("Enter the time of day (eg. morning, afternoon, evening): ");
                    string timeOfDay = Console.ReadLine();

                    Console.Write("Rate your mood today on a scale of 1 to 10: ");
                    int moodRating;
                    while (!int.TryParse(Console.ReadLine(), out moodRating) || moodRating < 1 || moodRating > 10)
                    {
                        Console.WriteLine("Please enter a valid number between 1 and 10.");
                    }

                    journal.AddEntry(new Entry(prompt, response, date, timeOfDay, moodRating));
                    break;
                case "2":
                    journal.DisplayEntries();
                    break;
                case "3":
                    Console.Write("Filename to load: ");
                    string loadFile = Console.ReadLine();
                    journal.LoadFromFile(loadFile);
                    break;
                case "4":
                    Console.Write("Filename to save: ");
                    string saveFile = Console.ReadLine();
                    journal.SaveToFile(saveFile);
                    break;
            }
        } while (choice != "5");
    }
}