using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Sample list of integers
        List<int> numbers = new List<int> { 10, 5, 20, 8, 15 };

        // Initialize variables to hold the maximum and minimum values
        int max = int.MinValue;  // Initialize to the smallest possible integer value
        int min = int.MaxValue;  // Initialize to the largest possible integer value

        // Iterate through the list of integers
        foreach (int num in numbers)
        {
            // Check if the current number is greater than the current maximum
            if (num > max)
            {
                max = num;  // Update the maximum value
            }

            // Check if the current number is smaller than the current minimum
            if (num < min)
            {
                min = num;  // Update the minimum value
            }
        }

        // Print the maximum and minimum values
        Console.WriteLine("Maximum number: " + max);
        Console.WriteLine("Minimum number: " + min);
    }
}