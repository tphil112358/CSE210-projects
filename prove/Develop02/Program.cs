using System;

class Program
{
    static void Main(string[] args)
    {
        bool auth = false;
        string password = "ilovebyui";
        Console.WriteLine("This is the private journal of █████ ████████.");

        while (auth == false)
        {
            Console.WriteLine("Enter password: ");
            string passwordAttempt = Console.ReadLine();
            if (passwordAttempt == password) 
            {
                Console.WriteLine("Access Granted.");
                Console.WriteLine();
                break;
            }
            else if (passwordAttempt == "ilovebyu")
            {
                Console.WriteLine("VERY Incorrect.");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Incorrect.");
                Console.WriteLine();
            }
        }
        
        Journal journal = new Journal();
        DateTime date = DateTime.Now;
        bool continuity = true;

        while (continuity == true)
        {
            Console.WriteLine();
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load a journal from a file");
            Console.WriteLine("5. Exit");
            Console.WriteLine();

            if (date.Hour < 12) {Console.WriteLine("Good morning! Please enter the number corresponding with your choice:  ");} //Forgive the lack of whitespace here XD It looked abysmal in the proper syntax
            else if (date.Hour < 18) {Console.WriteLine("Good afternoon! Please enter the number corresponding with your choice:  ");}
            else {Console.WriteLine("Good evening! Please enter the number corresponding with your choice:  ");}

            try
            {
                int choice = int.Parse(Console.ReadLine());

                if (choice == 1) // Write a new entry
                {
                    string[] prompts = {"Who was the most interesting person I interacted with today?","What was the best part of my day?","How did I see the hand of the Lord in my life today?","What was the strongest emotion I felt today?","If I had one thing I could do over today, what would it be?","If I would remanence about one thing today 5 years from now, what would it be?",};
                    Random rng = new Random();
                    string randomPrompt = prompts[rng.Next(prompts.Length)];
                    Console.WriteLine($"Your prompt: {randomPrompt}");
                    Console.WriteLine("Your response: ");
                    string journalEntry = Console.ReadLine();

                    journal.AddEntry(randomPrompt, journalEntry, DateTime.Now);
                }
                else if (choice == 2) // Display the journal
                {
                    journal.DisplayEntries();
                }
                else if (choice == 3) // Save the journal to a file
                {
                    Console.WriteLine("Name the file: ");
                    string Filename = Console.ReadLine();
                    journal.SaveToFile(Filename);
                }
                else if (choice == 4) // Load a journal from a file
                {
                    Console.WriteLine("Enter the name of the file to load: ");
                    string loadFilename = Console.ReadLine();
                    journal.LoadFromFile(loadFilename);
                }
                else if (choice == 5) // Exit
                {
                    continuity = false;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                }
            }
            catch (Exception ex)
            {
            Console.WriteLine($"Error executing request: {ex.Message}");
            }
            
        }
    }
}