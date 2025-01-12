using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please state your grade percentage:");
        string percentAnswer = Console.ReadLine();
        int percent = int.Parse(percentAnswer);

        string grade = "";
        if (percent >= 90)
        {
            grade = "A";
        }
        else if (percent >= 80)
        {
            grade = "B";
        }
        else if (percent >= 70)
        {
            grade = "C";
        }
        else if (percent >= 60)
        {
            grade = "D";
        }
        else grade = "F";

        Console.WriteLine($"Your grade is {grade}");
        if (percent >= 70)
        {
            Console.WriteLine("Congrtulations! You passed!");
        }
        else Console.WriteLine("Sorry, you falied. Do better.");
    }
}