using System;
using System.Runtime.CompilerServices;

class Entry
{
    
    public DateTime Date {get;set;}
    public string Prompt {get;set;} //Forgive the lack of whitespace here XD It looked abysmal in the proper syntax
    public string Response {get;set;}

    public Entry(DateTime date, string prompt, string response)
    {
        Prompt = prompt;
        Response = response;
        Date = date;
    }

    public void Display()
    {
        Console.WriteLine();
        Console.WriteLine($"Date: {Date}");
        Console.WriteLine($"Prompt: {Prompt}");
        Console.WriteLine($"Response: {Response}");
        Console.WriteLine();
    }
}
