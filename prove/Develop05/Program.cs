using System;
using System.Runtime.CompilerServices;
class Program
{
    
    static void Main(string[] args)
    {
        Manager manager = new Manager();
        Console.WriteLine("\nWelcome to the Goals app! :)\n");
        int choice = 7;
        while(choice != 0)
        {
        Console.WriteLine("Menu:");
        Console.WriteLine("1 Create");
        Console.WriteLine("2 Load");
        Console.WriteLine("3 Display");
        Console.WriteLine("4 Record Event");
        Console.WriteLine("5 displayscore");
        Console.WriteLine("0 Quit");
        Console.Write("Please enter your choice: ");
        choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
            manager.Create();
            break;

            case 2:
            manager.Load();
            break;

            case 3:
            manager.Display();
            break;

            case 4:
            manager.RecordEvent();
            break;

            case 5:
            manager.GetScore();
            break;

            case 0:
            Console.WriteLine("Thanks for using the Goals app. ");
            break; 
        }
        }
    }   
}