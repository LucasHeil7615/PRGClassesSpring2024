using System;
using System.ComponentModel.Design;
using System.Data;
using System.Net.Quic;
using System.Xml.Serialization;

class Journal
{
    public void Menu()
    {
        Console.WriteLine("Welcome to the Journal app. ");

        int choice = 8;
        while (choice != 0 )
        {
            Console.WriteLine("Please select an option. ");
            Console.WriteLine("1 Write");
            Console.WriteLine("2 Save");
            Console.WriteLine("3 Display");
            Console.WriteLine("4 Load");
            Console.WriteLine("5 Inpiration");
            Console.WriteLine("0 Quit");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                break;

                case 2:
                break;

                case 3:
                break;

                case 4:
                break;

                case 5:
                break;

                case 0:
                break;
            }
        }
    }
}