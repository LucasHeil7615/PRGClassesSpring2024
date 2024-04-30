
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Welcome to the list builder!. ");

        List<int> numbers = new List<int>();

        Console.WriteLine("We have created a list that uses ints for you. please begin entering ints. When you would like to stop enter 0. ");

        int entry = int.Parse(Console.ReadLine());
        
        while (entry != 0)
        {
            numbers.Add(entry);
        }

        Console.WriteLine("list of ints: ");
        foreach (int number in numbers)
        {
            Console.WriteLine($"{number}");
        }
    }
}