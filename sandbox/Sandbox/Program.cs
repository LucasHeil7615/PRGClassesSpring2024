using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // // Sample list of integers
        // List<int> numbers = new List<int> { 10, 5, 20, 8, 15 };

        // // Initialize variables to hold the maximum and minimum values
        // int max = int.MinValue;  // Initialize to the smallest possible integer value
        // int min = int.MaxValue;  // Initialize to the largest possible integer value

        // // Iterate through the list of integers
        // foreach (int num in numbers)
        // {
        //     // Check if the current number is greater than the current maximum
        //     if (num > max)
        //     {
        //         max = num;  // Update the maximum value
        //     }

        //     // Check if the current number is smaller than the current minimum
        //     if (num < min)
        //     {
        //         min = num;  // Update the minimum value
        //     }
        // }

        // // Print the maximum and minimum values
        // Console.WriteLine("Maximum number: " + max);
        // Console.WriteLine("Minimum number: " + min);

        DateTime theCurrentTime = DateTime.Now;

        // To get the short date string
        string dateText = theCurrentTime.ToShortDateString();

        // To get the short time string
        string timeText = theCurrentTime.ToShortTimeString();

        // If you want both the short date and short time in one string
        string dateTimeText = theCurrentTime.ToString("g");

        // Or using custom format for more control (e.g., "MM/dd/yyyy hh:mm tt")
        string customDateTimeText = theCurrentTime.ToString("MM/dd/yyyy hh:mm tt");

        // Printing the results
        Console.WriteLine("Short Date: " + dateText);
        Console.WriteLine("Short Time: " + timeText);
        Console.WriteLine("Short Date and Time: " + dateTimeText);
        Console.WriteLine("Custom Date and Time: " + customDateTimeText);

    }
}