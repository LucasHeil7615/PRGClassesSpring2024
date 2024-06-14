using System;

class Program
{
    static void Main(string[] args)
    {
        int choice = 10;
        Fillings fillings = new Fillings();
        GetScripture getScripture = new GetScripture(); 
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
                
                if (loadScripture.isLoaded)
                {
                string reference = loadScripture.GetReference();
                string fulltext = loadScripture.Getfulltext();
                loadScripture.GetReference();
                Scripture scripture = new Scripture(fulltext, reference);
                scripture.Run();
                }
                else
                {
                    Console.WriteLine("You have either not saved a scripture aka option1 or have not loaded a spricture aka option2 please refer to the description option 4.\n");

                }
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