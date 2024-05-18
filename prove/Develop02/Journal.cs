using System;
using System.IO;
using System.Dynamic;
using System.IO.Enumeration;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

class Journal 
{
    public List<Entry> entries = new List<Entry>();
    Fillings fillings = new Fillings();


    public void NewEntry()
    {
        //Show the user a random prompt (from a list that you create), and save their response, the prompt, and the date as an Entry.
        Console.WriteLine("Please respond to the following prompt: ");
        string prompt = fillings.Prompt(); 
        Console.WriteLine($"{prompt}");

        string response = Console.ReadLine();

        string dateTimeText = fillings.GetDateTime();

        Entry entry = new Entry(dateTimeText, prompt, response );

        entries.Add(entry);

    }

    public void DisplayEntries()
    {
        //Iterate through all entries in the journal and display them to the screen.
        Console.WriteLine("Journal Entries");
        Console.WriteLine("---------------");

        foreach (Entry entry in entries)
        {
            entry.Display();
        }

    }

    public void Save()
    {
        //Prompt the user for a filename and then save the current journal (the complete list of entries) to that file location.
        Console.Write("Please enter the journal file you wish to save these entries into:");
        string filename = Console.ReadLine();

        using(StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine("Welcome to JounalAppLog. \n You can save all of your previous entries here. ");
         
            DisplayEntries();
        }

        Console.WriteLine($"Your entries have been saved in {filename}. ");
        
    }

    public void Load()
    {
        //Prompt the user for a filename and then load the journal (a complete list of entries) from that file. This should replace any entries currently stored the journal.
    }

    public void Inspiration()
    {
        string quote = fillings.Inspiration();
        Console.WriteLine($"{quote}"); 
    }
}