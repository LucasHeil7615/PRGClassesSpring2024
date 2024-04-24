using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your first name? :");
        string firstName = Console.ReadLine();
        Console.WriteLine("What is your last name? :");
        string lastName = Console.ReadLine(); 

        string UpperFirstName = CapatalizeString(firstName);
        String UpperLastName = CapatalizeString(lastName);

        Console.WriteLine($"Your name is {UpperLastName}, {UpperFirstName} {UpperLastName}.");
    }

    static string CapatalizeString(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            return input; //if no value given give back without changes
        }

        //Capatalizing values
        return char.ToUpper(input[0]) + input.Substring(1).ToLower();

    }
}