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
        using(StreamWriter outputFile = new StreamWriter(filename, true))
        {        
            foreach (Entry entry in entries)
            {   
                outputFile.WriteLine($"{entry.Date}|{entry.Prompt}|{entry.Content}");
            }

        }
        Console.WriteLine($"Your entries have been saved in {filename}. ");
    }

    public void Load()
    {
        //Prompt the user for a filename and then load the journal (a complete list of entries) from that file. This should replace any entries currently stored the journal.
        Console.WriteLine("Please enter the filename you would like to enter: ");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
        {
            Console.WriteLine("File not Found.");
            return;
        }

        //Clearing existing entries 
        entries.Clear();

        // read all lines from the file 
        string[] lines = File.ReadAllLines(filename);

        foreach(string line in lines)
        {   
            //split each line by the seperator
            string [] parts = line.Split("|");

            if (parts.Length == 3)
            {   
                string date = parts[0];
                string prompt = parts[1];
                string content = parts[2];
                //create a new Entry object and add it to the entries list
                Entry entry = new Entry(date, prompt, content);
                entries.Add(entry);
            }
            else
            {
                Console.WriteLine("Invalid entry format in file");
            }

        }

        Console.WriteLine($"Journal entries have been loaded from {filename}");

    }

    public void Inspiration()
    {
        string quote = fillings.Inspiration();
        Console.WriteLine($"{quote}"); 
    }
}