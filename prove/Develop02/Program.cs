using System;
using System.ComponentModel.Design;
using System.Data;
using System.Net.Quic;
using System.Xml.Serialization;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Welcome to the Journal app. ");

        Console.WriteLine("In this app you can write new entries about your day or what ever you feel like. \nYou can write an entry save it to a txt file, display the txt file you've written on, load a diffrent txt file,\nor if your feeling the need for it ask for a random inpiring qoute to help you gain new perspective. ");

        Journal journal = new Journal();

        int choice = 10;
        while (choice != 0 )
        {
            Console.WriteLine("Please select an option. ");
            Console.WriteLine("1 Write");
            Console.WriteLine("2 Save");
            Console.WriteLine("3 Display");
            Console.WriteLine("4 Load");
            Console.WriteLine("5 Encouragment");
            Console.WriteLine("0 Quit");
            Console.Write("Please enter your choice: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                journal.NewEntry();
                break;

                case 2:
                journal.Save();
                break;

                case 3:
                journal.DisplayEntries();
                break;

                case 4:
                journal.Load();
                break;

                case 5:
                journal.Inspiration();
                break;

                case 0:
                Console.WriteLine("Quiting Program. Take care of your self. ");
                break;

                default:
                Console.WriteLine("Invalid option");
                break;

            }
        }
    }
}