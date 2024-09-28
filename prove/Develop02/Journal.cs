public class Journal
{
    public List<Entry> _entries;

    // Start the list of journal entries
    public Journal()
    {
        _entries = new List<Entry>();
    }

    // Method to add a journal entry.
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    // Method to display all journal entries.
    public void DisplayAll()
    {
        foreach (var entry in _entries)
        {
            entry.Display();
        }
    }

    // Method to save the entries to a file.
    public void SaveToFile(string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (var entry in _entries)
            {
                writer.WriteLine($"{entry.Date} | {entry._promptText} | {entry._entryText}");
            }
        }
    }

    public void LoadFromFile(string fileName)
    {
        // Method to load entries from a file.
        _entries.Clear(); // Clear existing entries before loading.
        using (StreamReader reader = new StreamReader(fileName))
        {
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                string[] parts = line.Split('|');
                if (parts.Length == 3)
                {
                    _entries.Add(new Entry(parts[0].Trim(), parts[1].Trim(), parts[2].Trim()));
                }
            }
        }
    }

    public void DisplayJournalSummary()
    {
        if (_entries.Count > 0)
        {
            JournalSummary summary = new JournalSummary(_entries);

            int totalEntries = summary.GetTotalEntries();
            int mostActiveDay = summary.GetMostActiveDay();
            Console.WriteLine($"Total entries: {totalEntries}");
            Console.WriteLine($"Most active day: {mostActiveDay}");
            Console.WriteLine();
        }

        else
        {
            Console.WriteLine("Upps, you need to load your journal first or add some entries.");
        }
    }
}