using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 11);
        int x = 0;
        while (x == 0)
        {
            Console.WriteLine("Try and guess the number: ");
            string userInput = Console.ReadLine();
            int guess = int.Parse(userInput);
            if (guess == number)
            {
                Console.WriteLine("Correct! Nice guessing skills.");
                x++;
            }
            else if (guess > number)
            {
                Console.WriteLine("Lower.");
            }
            else
            {
                Console.WriteLine("Higher.");
            }
        }
    }
}
