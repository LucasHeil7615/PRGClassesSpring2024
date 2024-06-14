using System;
using System.IO;
class LoadScripture
{

    private string fulltext;
    private string reference;

    public bool isLoaded {get; private set;}
    public void Run()
    {
        Load();
        GetReference();
        Console.Write($"{reference}: ");
        Getfulltext();
        Console.WriteLine($"{fulltext}\n");
    }
    private void Load()
    {
        //Prompt the user for a filename and then load the reference with it's accompaning scripture from that file. This should replace any entries currently stored the memorizer.
        bool fileloaded = false;
        //Clearing existing entries 
        Console.Clear();
        while(!fileloaded)
        {
        Console.Write("Please enter the filename you would like to enter: ");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
        {
            Console.WriteLine("File not Found. If you have not set any local txt files please restart program and select Get scripture. Otherwise, please retry and check spelling.");
            continue;
        }
        Console.WriteLine($"{filename} found");
        
        Console.Write("Please enter the reference of the scripture that you want to load: ");
        string inputreference = Console.ReadLine();
        // read all lines from the file 
        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines )
        { 
            string [] parts = line.Split("|");
            if(parts.Length >=2 && parts[0].Equals(inputreference, StringComparison.OrdinalIgnoreCase))
            {
            reference = parts[0];
            fulltext = parts[1];
            Console.WriteLine($"{reference} has loaded from {filename}");
            fileloaded = true;
            isLoaded = true;
            break;
            }
        }
           if (!fileloaded)
               {
                    Console.WriteLine("There doesn't seem to be a reference here that matches your's\nPlease try again.");
                    continue;
               }
        }   
    }

    public string GetReference()
    {
        return reference;
    }

    public string Getfulltext()
    {
        return fulltext;
    }   

} 