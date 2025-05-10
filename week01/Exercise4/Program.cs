using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        Console.WriteLine("Enter a list of numbers. 0 to quit");
        List<int> numbers = new List<int>();
        int number = -1; ;
        // Add a while loop   
        while (number != 0)
        {
            Console.Write("Please enter a number: ");
            number = int.Parse(Console.ReadLine());
            if (number != 0)
            {
                numbers.Add(number);
            }
        }

        int runningTotal = 0;
        foreach (int num in numbers)
        {
            runningTotal += num;
        }
        Console.WriteLine($"The sum of the numbers is: {runningTotal}");

        int count = numbers.Count;
        double average = (double)runningTotal / count;
        Console.WriteLine($"The average is: {average}");

        int currentHighest = -1;
        foreach (int num in numbers)
        {
            if (num > currentHighest)
            {
                currentHighest = num;
            }
        }
        Console.WriteLine($"The highest number is: {currentHighest}");

        int currentSmallest = int.MaxValue;
        foreach (int num in numbers)
        {
            if (num > 0 && num < currentSmallest)
            {
                currentSmallest = num;
            }
        }
        Console.WriteLine($"The smallest number is: {currentSmallest}");

        numbers.Sort();
        Console.WriteLine("The sorted list is: ");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }


    }
}