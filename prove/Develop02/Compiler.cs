using System;
using System.Dynamic;

class Compiler 
{
    private static void Load()
    {

    }

    private static void save()
    {
        
    }
    private static void Display()
    {

    }

    public void GetInspiration(string Quote)
    {
        Fillings fillings = new Fillings();

        string inspired = fillings.Inspiration();

        Console.WriteLine($"{Quote}");

    } 
}