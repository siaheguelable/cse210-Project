using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        Console.WriteLine("This project is about the basics of C# programming using loops.");
        Console.WriteLine("We will explore variables, data types, and basic operations.");
        Console.WriteLine("Let's play a guessing game!");

        // guess game 
        Random random = new Random();
        int secretNumber = random.Next(1, 21); // Generates a random number between 1 and 20
        Console.WriteLine($"A secret number has been generated between 1 and 20. Can you guess it?");
        string userAnswer = Console.ReadLine();
        userAnswer = userAnswer.ToLower();
        if (userAnswer == "yes")
        {
            Console.WriteLine("Please enter your guess:");
            string userGuess = Console.ReadLine();
            int guess = int.Parse(userGuess);

            if (guess < secretNumber)
            {
                Console.WriteLine("Your guess is too low.");
                    }
                    else if (guess > secretNumber)
                    {
                        Console.WriteLine("Your guess is too high.");
                    }
                    else
                    {
                        Console.WriteLine("Congratulations! You guessed the secret number!");
                    }
                } while (userAnswer.ToLower() == "yes");
            Console.WriteLine("Thank you for playing! Goodbye!");
        }
    }
