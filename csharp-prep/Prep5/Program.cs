using System;

class Program
{
    static void Main(string[] args)
    {
        // DisplayWelcome - Displays the message, "Welcome to the Program!"
        // PromptUserName - Asks for and returns the user's name (as a string)
        // PromptUserNumber - Asks for and returns the user's favorite number (as an integer)
        // SquareNumber - Accepts an integer as a parameter and returns that number squared (as an integer)
        // DisplayResult - Accepts the user's name and the squared number and displays them.
        DisplayWelcome();
        string UserName = PromptUserName();
        int UserNumber = PromptUserNumber();
        int SquaredNumber = SquareNumber(UserNumber);
        DisplayResult(UserName, SquaredNumber);

    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName()
    {
        Console.Write("Enter your name: ");
        string UserName = Console.ReadLine();
        return UserName;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int UserNumber = int.Parse(Console.ReadLine());
        return UserNumber;
    }

    static int SquareNumber(int UserNumber)
    {
        int SquareNumber = UserNumber * UserNumber;
        return SquareNumber;
    }

    static void DisplayResult(string UserName, int SquareNumber)
    {
        Console.WriteLine($"{UserName}, the square of your number is {SquareNumber}");
    }
}