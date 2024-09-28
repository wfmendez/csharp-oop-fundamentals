public class Entry
{
    // Entry properties, such as date, question, and  text.
    public string Date { get; set; }
    public string _promptText;
    public string _entryText;

    // Creation of a new entry with date, question and answer.
    public Entry(string date, string promptText, string entryText)
    {
        Date = date;
        _promptText = promptText;
        _entryText = entryText;
    }

    // Creation of Display
    public void Display()
    {
        Console.WriteLine($"Date: {Date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entryText}");
        Console.WriteLine();
    }
}