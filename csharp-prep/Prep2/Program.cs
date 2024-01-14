using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade? ");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);
        string letter;
        if (grade >= 90)
        {
            if (grade >= 93)
            {
                letter = "A";
            }
            else
            {
                letter = "A-";
            }
        }
        else if (grade >= 80)
        {
            if (grade >= 87)
            {
                letter = "B+";
            }
            else if (grade >= 83)
            {
                letter = "B";
            }
            else
            {
                letter = "B-";
            }
        }
        else if (grade >= 70)
        {
            if (grade >= 77)
            {
                letter = "C+";
            }
            else if (grade >= 73)
            {
                letter = "C";
            }
            else
            {
                letter = "C-";
            }
        }
        else if (grade >= 60)
        {
            if (grade >= 67)
            {
                letter = "D+";
            }
            else if (grade >= 63)
            {
                letter = "D";
            }
            else
            {
                letter = "D-";
            }
        }
        else
        {
            letter = "F";
        }
        Console.WriteLine($"Your grade is {grade}, which is a {letter}");
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations on passing the course!");
        }
        else
        {
            Console.WriteLine($"Unfortunately for you, a {letter} is a failing grade. Try harder next time.");
        }
    }
}