class Program {
    private string _exerciseName;
    private string _exerciseDescription;
    private int _exerciseDuration;
    private int _durationMinimum;
    public string GetExerciseName() => _exerciseName;
    public void SetExerciseName(string newExerciseName) {
        _exerciseName = newExerciseName;
    }
    public string GetExerciseDescription() => _exerciseDescription;
    public void SetExerciseDescription(string newExerciseDescription) {
        _exerciseDescription = newExerciseDescription;
    }
    public int GetExerciseDuration() => _exerciseDuration;
    public void SetExerciseDuration(int newExerciseDuration) {
        _exerciseDuration = newExerciseDuration;
    }
    public int GetDurationMinimum() => _durationMinimum;
    public void SetDurationMinimum(int newDurationMinimum) {
        _durationMinimum = newDurationMinimum;
    }
    static void Main(string[] args) {
        // Have a menu system to allow the user to choose an activity.
        // Each activity should start with a common starting message that provides the name of the activity, a description, and asks for and sets the duration of the activity in seconds. Then, it should tell the user to prepare to begin and pause for several seconds.
        // Each activity should end with a common ending message that tells the user they have done a good job, and pause and then tell them the activity they have completed and the length of time and pauses for several seconds before finishing.
        // Whenever the application pauses it should show some kind of animation to the user, such as a spinner, a countdown timer, or periods being displayed to the screen.
        // The interface for the program should remain generally true to the one shown in the video demo.
        // Provide activities for reflection, breathing, and enumeration, as described below:

        // Design Requirements
        // In addition your program must:
        // 
        // Use inheritance by having a separate class for each kind of activity with a base class to contain any shared attributes or behaviors.
        // Avoid duplicating code in classes where it could instead be placed in a base class.
        // Follow the principles of encapsulation and abstraction by having private member variables and putting related items in the same class.
        Program program = new Program();
        program.Logo();
        program.Loading(1);
        Console.Write("[Done!]");
        program.Buffer(800);
        Console.Clear();
        int exit = 1;
        while (exit != 0) {
            program.Menu();
            try {
                string _userInput = Console.ReadLine();
                string[] _brCorrectNames = ["1", "br", "breathe", "breathing", "1. breathing exercise", "breathing exercise"];
                string[] _reCorrectNames = ["2", "re", "reflection", "reflecting", "2. reflection exercise", "reflection exercise"];
                string[] _liCorrectNames = ["3", "li", "list", "listing", "3. listing exercise", "listing exercise"];
                string[] _quitCorrectNames = ["4", "q", "quit"];
                foreach (string name in _brCorrectNames) {
                    if (name == _userInput.ToLower()) {
                        Breathe breathe = new Breathe();
                        breathe.RunBreathe();
                    }
                }
                foreach (string name in _reCorrectNames) {
                    if (name == _userInput.ToLower()) { 
                        Reflection reflection = new Reflection();
                        reflection.RunReflection();
                    }
                }
                foreach (string name in _liCorrectNames) {
                    if (name == _userInput.ToLower()) { 
                        Listing listing = new Listing();
                        listing.RunListing();
                    }
                }
                foreach (string name in _quitCorrectNames) {
                    if (name == _userInput.ToLower()) { 
                        exit = 0;
                        break;
                    }
                }
            }
            catch (Exception) {
                Console.WriteLine("Error processing your input. Please enter your selection as a number or name of desired exercise.");
            }
        }
    }
    private void Logo() {
        Console.WriteLine("╔════════════════════════════════════════════════╗");
        Console.WriteLine("║                                                ║");
        Console.WriteLine("║             ████ MINDFULLNESS ████             ║");
        Console.WriteLine("║                                                ║");
        Console.WriteLine("║           Expand your fetching mind.           ║");
        Console.WriteLine("║                                                ║");
        Console.WriteLine("╚════════════════════════════════════════════════╝");
        Thread.Sleep(1000);
        Console.Clear();
    }
    private void Menu() {
        DateTime date = DateTime.Now;
        if (date.Hour < 12) { Console.Write("Good morning! "); } // This code detects the time of day and gives the user the proper greeting. Forgive the lack of whitespace here XD It looked abysmal in the proper syntax.
        else if (date.Hour < 18) { Console.WriteLine("Good afternoon! "); }
        else { Console.WriteLine("Good evening! "); }
        Console.WriteLine("Choose your activity today:");
        Console.WriteLine("1. Breathing Exercise");
        Console.WriteLine("2. Reflection Exercise");
        Console.WriteLine("3. Listing Exercise");
        Console.WriteLine("4. Quit");
        Console.WriteLine("");
    }
    private void Buffer(int wait) {
        Thread.Sleep(wait);
        Console.Write("\b \b");
    }

    public void Loading(double seconds) {
        while (seconds != 0) {
            Console.Write("∕");
            Buffer(100);
            Console.Write("—");
            Buffer(100);
            Console.Write("\\");
            Buffer(100);
            Console.Write("|");
            Buffer(100);
            Console.Write("∕");
            Buffer(100);
            seconds -= 0.5;
        }
    }
    public void LoadingBar(string instruction, double seconds) {
        double interim = 15 / seconds; // How many squares off each side to delete every third of a second.
        double progress = 15;
        while (progress > 0) {
            Console.WriteLine(instruction);
            Console.WriteLine("╔════════════════════════════════╗");
            Console.WriteLine("║ " + new string(' ', 15 - (int)progress) + new string('█', (int)progress * 2) + new string(' ', 15 - (int)progress) + " ║");
            Console.WriteLine("╚════════════════════════════════╝");
            Thread.Sleep(333);
            progress = progress - interim / 3;
            Console.Clear();
        }
    }
    public void BeginExercise(string _exercise, string _description, int _minimum) {
        Console.Clear();
        Console.WriteLine($"Welcome to this {_exercise} exercise; {_exercise} is easy and relaxing!");
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.WriteLine($"How many seconds do you want this activity to last?: (Minimum {_minimum} seconds)");
        SetExerciseDuration(int.Parse(Console.ReadLine()));
        Console.WriteLine();
        Console.WriteLine("Get Ready!");
        Loading(3);
    }
    public void EndExercise(int _seconds, string _exercise) {
        Console.WriteLine("Great Job!");
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_seconds} seconds of the {_exercise} exercise.");
        Loading(5);
    }
}