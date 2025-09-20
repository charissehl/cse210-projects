using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.WriteLine("");

        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int percent = int.Parse(userInput);

        string letter = "";

        if (percent >= 90)
        {
            letter = "A";
        }

        else if (percent >= 80)
        {
            letter = "B";
        }

        else if (percent >= 70)
        {
            letter = "C";
        }

        else if (percent >= 60)
        {
            letter = "D";
        }

        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}. ");

        if (percent >= 70)
        {
            Console.WriteLine("Congratulations, you have passed the course!");
        }

        else
        {
            Console.WriteLine("You have not passed the course this time, but you are able to retake the course and try again next time.");
        }

    }
}