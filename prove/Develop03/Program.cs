using System;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        Fillings fillings = new Fillings();
        Console.WriteLine("Welcome to the Scripture memorizer. ");
           
        int choice = 10;
        while (choice != 0)
        {
            Console.WriteLine("Please enter your choice: ");
            Console.WriteLine("1 :Description");
            Console.WriteLine("2 :Get scripture");
            Console.WriteLine("3 :Load Scripture");
            Console.WriteLine("4 :Run Memorizer");
            Console.WriteLine("0 :Quit Program");
            
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1 :
                Console.WriteLine(fillings.GetDescription());
                break;  
                case 2 :
                break;
                case 3 :
                break;
                case 4 :
                break;
                case 0 :
                break;
                default :
                Console.WriteLine("It appears that you have chosen an invalid option.\nPlease press 1 to open the description of this program if you need help.");
                continue;
            }
        }
    }   

}