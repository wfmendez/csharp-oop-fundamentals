class JournalSummary
{
    public List<Entry> _entries;

    public JournalSummary(List<Entry> entries)
    {
        _entries = entries;
    }

    // Method to get the total number of journal entries.
    public int GetTotalEntries()
    {
        return _entries.Count;
    }

    // Method to get the number of journal entries on a specific date.
    public int GetEntriesOnDate(string date)
    {
        return _entries.Count(entry => entry.Date == date);
    }

    // Method to get the day with the most journal entries.
    public int GetMostActiveDay()
    {
        var groupedEntries = _entries.GroupBy(entry => entry.Date);
        var maxEntries = groupedEntries.Max(group => group.Count());
        return maxEntries;
    }
}