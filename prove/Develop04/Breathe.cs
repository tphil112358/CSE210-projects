using System;
using System.Dynamic;
using System.Net.Http.Headers;
using System.Reflection.Metadata;
using System.Xml.Schema;

// Breathing Activity
// The activity should begin with the standard starting message and prompt for the duration that is used by all activities.
// The description of this activity should be something like: "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing."
// After the starting message, the user is shown a series of messages alternating between "Breathe in..." and "Breathe out..."
// After each message, the program should pause for several seconds and show a countdown.
// It should continue until it has reached the number of seconds the user specified for the duration.
// The activity should conclude with the standard finishing message for all activities.
class Breathe
{
    public void RunBreathe()
    {
        Console.Clear();
        Console.WriteLine("Welcome to this breathing exercise. Breathing is easy and relaxing!");
        Console.WriteLine("You will breathe in for 3 seconds, hold it for 3, breathe out for 3, hold it for 3 again, and repeat");
        Console.WriteLine();
        Console.WriteLine("How many seconds do you want this activity to last?: (Minimum 10 seconds)");
        int _userInput = int.Parse(Console.ReadLine());
        Program program = new Program();
        program.Loading(5);
        while (_userInput > 0)
        {
            LoadingBar("Breathe in",3);
            LoadingBar("Now hold your breath",2);
            LoadingBar("Now breathe out",3);
            LoadingBar("Now hold your breath.",2);
            _userInput -= 10;
        }
        Console.WriteLine("[Exercise Complete!]");
        Thread.Sleep(2000);
    }
    private void LoadingBar(string instruction, double seconds)
    {
        double interim = 15 / seconds; // How many squares off each side to delete every third of a second.
        double progress = 15;
        while (progress > 0)
        {
            Console.WriteLine($"{instruction}");
            Console.WriteLine("╔════════════════════════════════╗");
            Console.WriteLine("║ " + new string(' ', 15 - (int)progress) + new string('█', (int)progress * 2) + new string(' ', 15 - (int)progress) + " ║");
            Console.WriteLine("╚════════════════════════════════╝");
            Thread.Sleep(333);
            progress = progress - interim / 3;
            Console.Clear();
        }
    }
}