using System;

class Program
{
    static void Main(string[] args)

    {
        
        Console.WriteLine("Please Enter your Grade: ");
        float Grade = float.Parse(Console.ReadLine());
        string letter = "";

        if (Grade >= 93.00)
        {
            letter = "A";
        }
        else if (Grade >= 90.00)
        {
            letter = "A-";
        }
          else if (Grade >= 87.00)
        {
            letter = "B+";
        }
          else if (Grade >= 83.00)
        {
            letter = "B";
        }
          else if (Grade >= 80.00)
        {
            letter = "B-";
        }
          else if (Grade >= 77.00)
        {
            letter = "C+";
        }
          else if (Grade >= 73.00)
        {
            letter = "C";
        }
          else if (Grade >= 70)
        {
            letter = "C-";
        }
           else if (Grade >= 67)
        {
            letter = "D+";
        }
           else if (Grade >= 63)
        {
            letter = "D";
        }
           else if (Grade >= 60)
        {
            letter = "D-";
        }
          else
        {
            letter = "F";
        }

        Console.WriteLine($"Grade: {letter}");
        
        if (Grade >= 70)
        {
            Console.WriteLine($"Congrats you passed!");
        }
        else
        {
            Console.WriteLine("You didn't pass this time but you only fail if you stop trying.");
        }


    }
}