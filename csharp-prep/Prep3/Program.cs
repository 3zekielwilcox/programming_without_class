using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the GUESS THE NUMBER game!");
        Console.WriteLine("In this game, you try to guess a random number in the least attempts.");
        Console.WriteLine();
        Console.WriteLine("Now, pleaase choose the maximum amount of positive numbers to choose from:");

        int response = int.Parse(Console.ReadLine());

        Random randomGenerator = new Random();
        int randomNumber = randomGenerator.Next(1, response);

        Console.WriteLine();
        Console.WriteLine("A random number has been chosen.");

        int guess = -1;
        int count = 0;
        while (guess != randomNumber)
        {
            Console.WriteLine("What is your guess?");
            guess = int.Parse(Console.ReadLine());

            if (guess > randomNumber)
            {
                Console.WriteLine();
                Console.WriteLine("Lower.");
                count ++;
            }

            else if (guess < randomNumber)
            {
                Console.WriteLine();
                Console.WriteLine("Higher.");
                count ++;
            }

            else if (guess == randomNumber)
            {
                Console.WriteLine();
                Console.WriteLine("Congratulations! You guessed the number!");
                count ++;
            }

            else
            {
                Console.WriteLine("Something went wrong. Please guess again.");
            }
        }

        Console.WriteLine();
        Console.WriteLine($"The number was {randomNumber}.");
        Console.WriteLine($"It took you {count} guess(es).");
    }
}