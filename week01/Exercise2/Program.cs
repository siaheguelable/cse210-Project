using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.WriteLine("This project is designed to help you get started with C#.");
        Console.WriteLine("This project is about the grading system.");
        
        // prompt the user for their name
        Console.WriteLine("What is your First name?");
        string firstName = Console.ReadLine();
        Console.WriteLine("What is your Last name?");
        string lastName = Console.ReadLine();   

        // Prompt the user for their score
        Console.WriteLine("Please enter your score (0-100):");
        string input = Console.ReadLine();
        int score = int.Parse(input);

        // Determine the grade
        char grade;
        if (score >= 90)
        {
            grade = 'A';
        }
        else if (score >= 80)
        {
            grade = 'B';
        }
        else if (score >= 70)
        {
            grade = 'C';
        }
        else if (score >= 60)
        {
            grade = 'D';
        }
        else
        {
            grade = 'F';
        }

        // Display the result
        Console.WriteLine(firstName + " " + lastName + ", your grade is: " + grade);
    }
}