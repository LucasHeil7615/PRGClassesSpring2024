using System;

class Program
{
    static void Main(string[] args)
    {
        int choice = 7;
        Console.WriteLine("Welcome to the Mindfullness app! :)\n");

        while(choice != 0)
        {
        Console.WriteLine("Please selcet an activty to do: ");
        Console.WriteLine("1 Breathing");
        Console.WriteLine("2 Relfection");
        Console.WriteLine("3 Listing");
        Console.WriteLine("0 Quit");
        Console.Write("Choice: ");
        choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
            Breathe breathe = new Breathe();
            breathe.Run();
            break;

            case 2:
            Reflect reflect = new Reflect();
            reflect.Run();
            break;

            case 3:
            List list = new List();
            list.Run();
            break;

            case 0:
            Console.WriteLine("Thanks for useing mindfulness app. ");
            break; 
        }
        }
    }   
}