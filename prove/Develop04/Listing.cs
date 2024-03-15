using System;
using System.Runtime.CompilerServices;

// Listing Activity
// The activity should begin with the standard starting message and prompt for the duration that is used by all activities.
// The description of this activity should be something like: "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area."
// After the starting message, select a random prompt to show the user such as:
// 
// Who are people that you appreciate?
// What are personal strengths of yours?
// Who are people that you have helped this week?
// When have you felt the Holy Ghost this month?
// Who are some of your personal heroes?
// After displaying the prompt, the program should give them a countdown of several seconds to begin thinking about the prompt. Then, it should prompt them to keep listing items.
// The user lists as many items as they can until they they reach the duration specified by the user at the beginning.
// The activity them displays back the number of items that were entered.
// The activity should conclude with the standard finishing message for all activities.

// Design Requirements
// In addition your program must:
// 
// Use inheritance by having a separate class for each kind of activity with a base class to contain any shared attributes or behaviors.
// Avoid duplicating code in classes where it could instead be placed in a base class.
// Follow the principles of encapsulation and abstraction by having private member variables and putting related items in the same class.
class Listing : Program {
    public void RunListing() {
        DateTime startTime = DateTime.Now;
        TimeSpan elapsedTime = DateTime.Now - startTime;
        SetExerciseName("listing");
        SetExerciseDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        SetExerciseDuration(10);
        BeginExercise(GetExerciseName(),GetExerciseDescription(),GetExerciseDuration());
        int responses = 0;
        int _userInput = GetExerciseDuration();

        List<string> _prompts = new List<string> {"---Who are people that you appreciate?---","---What are personal strengths of yours?---","---Who are people that you have helped this week?---","---When have you felt the Holy Ghost this month?---","---Who are some of your personal heroes?---"};
        Random _rnd = new Random();
        string _prompt = "Consider the following prompt for a few seconds, then enter as many responses as you can.\n" + _prompts[_rnd.Next(_prompts.Count)];
        LoadingBar(_prompt,_userInput / 2);

        Console.WriteLine(_prompt);
        Console.WriteLine("");
        Console.WriteLine("Now list your responses, hitting enter after each one: ");
        while (elapsedTime.TotalSeconds / 2 < _userInput / 2) {
            elapsedTime = DateTime.Now - startTime;
            Console.ReadLine();
            responses++;
        }
        Console.WriteLine($"You entered {responses} responses!");
        EndExercise(_userInput,"listing");
    }
}