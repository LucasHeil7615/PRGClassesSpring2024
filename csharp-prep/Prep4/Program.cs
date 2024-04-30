
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Common;
using System.Globalization;
using System.Numerics;
class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Welcome to the list builder!. ");
        //creating new list of numbers
        List<int> numbers = new List<int>();

        Console.WriteLine("We have created a list that uses ints for you. please begin entering ints. When you would like to stop enter 0. ");
        //starting our total, entry, Min and Max values 
        int total = 0;
        int entry = 1;
        int max = int.MaxValue;
        int min = int.MinValue;
        int count = 0;
        //while loop to ask user for an int until they press 0
        while (entry != 0){
        Console.Write("Enter an int: ");
        entry = int.Parse(Console.ReadLine());
        if (entry != 0)
        {      //adding entry to the list of numbers
            numbers.Add(entry);
        }
        // adding up numbers entered
            total += entry;
            count++;
        }
        //printing total
        Console.WriteLine($"Sum of ints: {total}\n");

        foreach (int num in numbers){
            if (num > max)
            {
                max = num; //Updating the maximum number
            }

            if (num < min)
            {
                min = num;
            }
        }
        float average = total / count; //getting the average of the list.
        Console.WriteLine($"Greatest number: {max} Smallest number: {min} Average: {average} ");

    }
}