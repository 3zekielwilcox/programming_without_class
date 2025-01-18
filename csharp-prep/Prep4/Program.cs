using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers;
        numbers = new List<int>();

        int input = -1;
        while (input != 0)
        {
            Console.WriteLine("Enter a list of numbers, type 0 when finished.");
            Console.Write("Enter number: ");
            input = int.Parse(Console.ReadLine());
            numbers.Add(input);
        }
        
        int largest = 0;
        float total = 0;
        foreach (int number in numbers)
        {
            if (largest < number)
            {
                largest = number;
            }
            total = total + number;
        }
        int count = numbers.Count;
        float average = total / count;
        
        Console.WriteLine();
        Console.WriteLine($"The sum is {total}.");
        Console.WriteLine($"The average is {average}.");
        Console.WriteLine($"The largest number is {largest}.");
    }
}