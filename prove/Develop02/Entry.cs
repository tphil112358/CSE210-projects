class Entry
{
    
    private DateTime date;
    private string prompt; //Forgive the lack of whitespace here XD It looked abysmal in the proper syntax
    private string response;

    public Entry(DateTime date, string prompt, string response)
    {
        this.prompt = prompt;
        this.response = response;
        this.date = date;
    }
    public DateTime Date() => date;
    public string Prompt() => prompt;
    public string Response() => response;

    public void Display()
    {
        Console.WriteLine();
        Console.WriteLine($"Date: {date}");
        Console.WriteLine($"Prompt: {prompt}");
        Console.WriteLine($"Response: {response}");
        Console.WriteLine();
    }
}
