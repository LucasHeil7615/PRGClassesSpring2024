using System;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        int choice = 10;
        Fillings fillings = new Fillings();
        GetScripture getScripture = new GetScripture(); 
        Scripture scripture = new Scripture();
        LoadScripture loadScripture = new LoadScripture();

        Console.WriteLine("Welcome to the Scripture memorizer.\n");
           
        
        while (choice != 0)
        {
            Console.WriteLine("Please enter your choice: ");
            Console.WriteLine("1 :Get scripture");
            Console.WriteLine("2 :Load Scripture");
            Console.WriteLine("3 :Run Memorizer");
            Console.WriteLine("4 :Description");
            Console.WriteLine("0 :Quit Program");
            Console.Write("Choice:");
            
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1 :
                getScripture.Run();
                break; 

                case 2 :
                loadScripture.Run();
                break;

                case 3 :
                //memorizer.Run();
                break;

                case 4 :
                Console.WriteLine(fillings.GetDescription());
                break;

                case 0 :
                Console.WriteLine("\nThanks for using the program.");
                break;

                default :
                Console.WriteLine("It appears that you have chosen an invalid option.\nPlease press 1 to open the description of this program if you need help.");
                continue;
            }
        }
    }   

}