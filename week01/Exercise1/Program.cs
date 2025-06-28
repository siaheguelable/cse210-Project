using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise1 Project.");
        Console.WriteLine("This project is designed to help you get started with C#.");
        Console.WriteLine("What is your First name?");
        string FirstName = Console.ReadLine();
        Console.WriteLine("What is your Last name?");
        string LastName = Console.ReadLine();
        Console.WriteLine("Your name is  {0} {1}", FirstName, LastName);

    }
}