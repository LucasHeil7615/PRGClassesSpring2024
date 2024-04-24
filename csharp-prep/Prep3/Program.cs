using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {   
        // Prep assignment:

        Console.WriteLine("Welcome to the guess a number game! ");

        Random randomGenerator = new Random();
        int magicNum = randomGenerator.Next(1, 100);
        Console.WriteLine("Please guess a number from 1 - 100 ints only plz.");

        bool run = true;
        while (run){

        Console.Write("Guess: ");
        int guessNum = int.Parse(Console.ReadLine());

        if (guessNum > magicNum)
        {
            Console.WriteLine("Guess Lower");
        }
        else if (guessNum < magicNum)
        {
            Console.WriteLine("Guess Higher");
        }
        else if (guessNum == magicNum)
        {
            Console.WriteLine("Congrats you Guessed it! ");
            run = false;
        }
        }



        
        

        //------------------------------------------------------
        // The following info is just the prep material so I could mess around with it and understand what was going on

        //This prep assigment demonstrates loops in C#
        // string response = "yes";

        //WHILE LOOP
        // while (response == "yes")
        // {
        //     Console.WriteLine("Do you want to continue? ");
        //     response = Console.ReadLine();
        // }

        //DO WHILE LOOP
        // string response;
        // do 
        // {
        //     Console.WriteLine("Do you want to continue? ");
        //     response = Console.ReadLine();
        // } while (response == "yes");

        //FOR LOOP
        // The standard for loop in C# is more like a "for x in range" loop in Python. The condition has three parts, separated by semi-colons. The first initializes the value, the second is the condition to check, and the third is an increment step that is run at the end of each loop.

        // The following code shows the syntax of a for loop that counts from 0 to 9.

        // for (int i = 0; i < 10; i++)
        // {
        //     Console.WriteLine(i);
        // }

        // In that code, you will see the use of the ++ operator which increments the value in the variable by one.

        // The code above is the most common way to see one of these loops, but you could put other values or statements in these spots, such as counting from 2 to 20 by two's:


        // for (int i = 2; i <= 20; i = i + 2)
        // {
        //     Console.WriteLine(i);
        // }

        //RANDOM NUMBER GENERATOR
        // Random randomGenerator = new Random();
        //int number = randomGenerator.Next(1, 11);
                
    }
}