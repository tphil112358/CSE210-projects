using System;

// Reflection Activity
// The activity should begin with the standard starting message and prompt for the duration that is used by all activities.
// The description of this activity should be something like: "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life."
// After the starting message, select a random prompt to show the user such as:
// 
// Think of a time when you stood up for someone else.
// Think of a time when you did something really difficult.
// Think of a time when you helped someone in need.
// Think of a time when you did something truly selfless.
// After displaying the prompt, the program should ask the to reflect on questions that relate to this experience. These questions should be pulled from a list such as the following:
// 
// Why was this experience meaningful to you?
// Have you ever done anything like this before?
// How did you get started?
// How did you feel when it was complete?
// What made this time different than other times when you were not as successful?
// What is your favorite thing about this experience?
// What could you learn from this experience that applies to other situations?
// What did you learn about yourself through this experience?
// How can you keep this experience in mind in the future?
// After each question the program should pause for several seconds before continuing to the next one. While the program is paused it should display a kind of spinner.
// It should continue showing random questions until it has reached the number of seconds the user specified for the duration.
// The activity should conclude with the standard finishing message for all activities.

// Design Requirements
// In addition your program must:
// 
// Use inheritance by having a separate class for each kind of activity with a base class to contain any shared attributes or behaviors.
// Avoid duplicating code in classes where it could instead be placed in a base class.
// Follow the principles of encapsulation and abstraction by having private member variables and putting related items in the same class.
class Reflection : Program {
    public void RunReflection() {
        SetExerciseName("reflecting");
        SetExerciseDescription("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life. Consider the following prompt, and press enter when ready to proceed.");
        SetExerciseDuration(30);
        BeginExercise(GetExerciseName(),GetExerciseDescription(),GetExerciseDuration());
        int _userInput = GetExerciseDuration();
        int _finisher = _userInput;
        List<string> _prompts = new List<string> { "---When was the last time you did something difficult, and what helped you overcome it?---", "---Think of a time when you did something truly selfless.---","---Think of a time when you did something really difficult.---"};
        while (_userInput > 0) {
            Random _rnd = new Random();
            Console.WriteLine(_prompts[_rnd.Next(_prompts.Count)]);
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Reflect on the following questions in regards to the previous question: ");
            Console.WriteLine("");
            PonderQuestion(_userInput);
            PonderQuestion(_userInput);
            _userInput -= 30;
        }
        EndExercise(_finisher,"reflecting");
    }
    private void PonderTime(int _userInput) {
        if (_userInput >= 30) {
                Loading(15);
            }
            else {
                Loading(_userInput / 2);
            }
    }
    private void PonderQuestion(int _userInput) {
        List<string> _ponder = new List<string> {"If you heard a stranger give your answer, what would be your impression of them?","How can you keep this experience in mind in the future?","What is your favorite thing about this experience?","What made this time different than other times when you were not as successful?"};
        Random _rnd = new Random();
        Console.WriteLine(_ponder[_rnd.Next(_ponder.Count)]);
        Console.WriteLine("");
        PonderTime(_userInput);
    }
}