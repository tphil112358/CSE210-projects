//Functional requirements
// 
// Provide for simple goals that can be marked complete and the user gains some value.
// For example, if you run a marathon you get 1000 points.
// Provide for eternal goals that are never complete, but each time the user records them, they gain some value.
// For example, every time you read your scriptures you get 100 points.
// Provide for a checklist goal that must be accomplished a certain number of times to be complete. Each time the user records this goal they gain some value, but when they achieve the desired amount, they get an extra bonus.
// For example, if you set a goal to attend the temple 10 times, you might get 50 points each time you go, and then a bonus of 500 points on the 10th time.
// Display the user's score.
// Allow the user to create new goals of any type.
// Allow the user to record an event (meaning they have accomplished a goal and should receive points).
// Show a list of the goals. This list should show indicate whether the goal has been completed or not (for example [ ] compared to [X]), and for checklist goals it should show how many times the goal has been completed (for example Completed 2/5 times).
// Allow the user's goals and their current score to be saved and loaded.

// Design Requirements
// 
// Use inheritance by having a separate class for each kind of activity with a base class to contain any shared attributes or behaviors.
// Use polymorphism by having derived classes override base class methods where appropriate.
// Follow the principles of encapsulation and abstraction by having private member variables and putting related items in the same class.

class Program {
    private static List<Goal> goals = new List<Goal>();

    static void Main(string[] args)
    {
        bool quit = false;

        while (quit != true)
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("");
            Console.WriteLine("1. Create a new goal");
            Console.WriteLine("2. Display goals");
            Console.WriteLine("3. Save goals");
            Console.WriteLine("4. Load goals");
            Console.WriteLine("5. Update goal completion");
            Console.WriteLine("6. Quit");

            string choice = Console.ReadLine();

            if (choice == "1") {
                CreateNewGoal();
            }
            else if (choice == "2") {
                DisplayGoals();
            }
            else if (choice == "3") {
                SaveGoals();
            }
            else if (choice == "4") {
                LoadGoals();
            }
            else if (choice == "5") {
                UpdateGoalCompletion();
            }
            else if (choice == "6") {
                quit = true;
            }
            else {
                Console.WriteLine("Invalid option. Please enter a number between 1 and 6.");
            }

        Console.WriteLine();
    }

    static void CreateNewGoal()
    {
        Console.WriteLine("Enter the name of the goal:");
        string name = Console.ReadLine();
        Console.WriteLine("Enter the description of the goal:");
        string description = Console.ReadLine();
        Goal goal = new Goal(name, description);
        goals.Add(goal);
        Console.WriteLine("Goal created successfully!");
    }

    static void DisplayGoals()
    {
        Console.WriteLine("Goals:");
        foreach (var goal in goals)
        {
            Console.WriteLine($"[ ] Name: {goal.GetGoalName()}, Description: {goal.GetGoalDescription()}, Completed: {goal.Completed}");
        }
    }

    static void SaveGoals()
    {
    }

    static void LoadGoals()
    {
    }

    static void UpdateGoalCompletion() {
        Console.WriteLine("Enter the index of the goal to update completion (starting from 0):");
        if (int.TryParse(Console.ReadLine(), out int index) && index >= 0 && index < goals.Count) {
            Console.WriteLine("Has the goal been completed? (true/false):");
            if (bool.TryParse(Console.ReadLine(), out bool completed)) {
                goals[index].Completed = completed;
                Console.WriteLine("Goal completion updated successfully.");
            }
            else {
                Console.WriteLine("Invalid input. Please enter true or false.");
            }
        }
        else {
            Console.WriteLine("Invalid index.");
        }
    }
}
}