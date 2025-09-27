using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "Share my favourite Bible verse and explain what I like about it:",
        "An idea I've had for an upcoming FHE lesson:",
        "What are the top three things I am thankful for today?",
        "What is something I have done today to keep the Lord close to my heart?",
        "What did I struggle with the most today, and how could I deal with it better in the future?",
        "What has my family taught me today?",
    };

    private Random random = new Random();

    public string GetRandomPrompt()
    {
        int index = random.Next(prompts.Count);
        return prompts[index];
    }



}