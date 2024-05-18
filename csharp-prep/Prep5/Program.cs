using System;

class Program
{
    static void Main(string[] args)
    {
        string name = GetName();
        int favNum = GetInt(); 
        int squaredNum = SquareInt(favNum); 
        DisplayResult(name, squaredNum); 
    }
    
    static void DisplayMessage()
    {
        Console.WriteLine("Welcome to the Program! :)");
    }

    static string GetName()
    {
        DisplayMessage(); // Call the display message here
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int GetInt()
    {
        Console.Write("Please enter your favorite number: ");
        int favNum = int.Parse(Console.ReadLine());
        return favNum;
    }

    static int SquareInt(int favNum)
    {
        int squaredNum = favNum * favNum;
        return squaredNum;
    }

    static void DisplayResult(string name, int squaredNum)
    {
        Console.WriteLine($"Hello {name}, the square of your number is {squaredNum}");
    }
}
