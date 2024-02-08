class Journal
{
    public List<Entry> entries;
    public Journal()
    {
        entries = new List<Entry>();
    }
    public void AddEntry(string prompt, string response, DateTime date)
    {
        entries.Add(new Entry(date, prompt, response));
    }

    public void DisplayEntries()
    {
        foreach (var entry in entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string filename)
    {
        System.IO.StreamWriter writer = new StreamWriter(filename);
        foreach (var entry in entries)
        {
            writer.WriteLine($"{entry.Date()}~{entry.Prompt()}~{entry.Response()}");
        }
        writer.Dispose();
    }
    public void LoadFromFile(string filename)
    {
        try
        {
            entries.Clear();
            System.IO.StreamReader reader = new StreamReader(filename);
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split('~');
                DateTime date = DateTime.Parse(parts[0]);
                string prompt = parts[1];
                string response = parts[2];
                entries.Add(new Entry(date, prompt, response));
            }
            reader.Dispose();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading journal: {ex.Message}");
        }
    }
}