public class PromptGenerator
{
    public List<string> _prompts;

    public PromptGenerator()
    {
        // Start the list of questions
        _prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "If you helped someone today, how was your experience?",
            "What are you grateful for today?",
            "What did you learn today about Jesus Christ?",
            "What significant moment did you have with a person today?",
            "If you could change something you did today so that you could do it better in the future, what would it be?",
            "What did you do today that you would like to remember in the future?",
            "At what point today were you brave?",
            "How did you follow the promptings of the Holy Ghost today?"
            // Add your own prompts here.
        };
    }

    // Method to get a random question from the list.
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(0, _prompts.Count);
        return _prompts[index];
    }
}