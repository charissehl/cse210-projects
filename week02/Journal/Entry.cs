public class Entry
{
    public string Prompt { get; set; }
    public string Response { get; set; }
    public string Date { get; set; }
    public string TimeOfDay { get; set; }
    public int MoodRating { get; set; }

    public Entry(string prompt, string response, string date, string timeOfDay, int moodRating)
    {
        Prompt = prompt;
        Response = response;
        Date = date;
        TimeOfDay = timeOfDay;
        MoodRating = moodRating;
    }

    public override string ToString()
    {
        return $"{Date}|{TimeOfDay}|{MoodRating}|{Prompt}|{Response}";
    }
}