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