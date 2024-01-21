using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        // Ask the user for a series of numbers, and append each one to a list. Stop when they enter 0.
        // Once you have a list, have your program do the following:

        // Core Requirements
        // Work through these core requirements step-by-step to complete the program. Please don't skip ahead and do the whole thing at once, because others on your team may benefit from building the program up slowly.

        // Compute the sum, or total, of the numbers in the list.

        // Compute the average of the numbers in the list.

        // Find the maximum, or largest, number in the list.
        List<int> Numbers = new List<int>();
        int x = 0;
        double NumberSum = 0;
        int BiggestNumber = -999999999;
        while (x == 0)
        {
            Console.WriteLine("Input a number, or input a blank when finished: ");
            string UserInput = Console.ReadLine();
            if (UserInput == "")
            {
                x++;
            }
            else
            {
                int Number = int.Parse(UserInput);
                Numbers.Add(Number);
                NumberSum += Number;
                if (Number > BiggestNumber)
                {
                    BiggestNumber = Number;
                }
            }
        }
        Console.WriteLine($"The sum is {NumberSum}.");
        double Average = NumberSum / Numbers.Count;
        Console.WriteLine($"The average is {Average}.");
        Console.WriteLine($"The biggest number is {BiggestNumber}.");
    }
}