using System;

class Program
{
    static void Main(string[] args)
    {
        DislayWelcome();
        string name = PromptUserName();
        int userNumber = PromptUserNumber();
        int squared = SquareNumber(userNumber);
        DisplayResult(name, squared);
    }
    static void DislayWelcome()
    {
        Console.WriteLine("welcome to the program!");
    }
    
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int userNumber = int.Parse(Console.ReadLine());

        return userNumber;
    }

    static int SquareNumber(int userNumber)
    {
        int squared = userNumber * userNumber;

        return squared;
    }

    static void DisplayResult(string name, int squared)
    {
        Console. WriteLine($"{name}, the square of your favorite number is {squared}.");
    }
}