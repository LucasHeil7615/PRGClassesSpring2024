using System;
using System.Reflection.Metadata;
using System.IO;
class LoadScripture
{

    private string fulltext;
    private string refrence;

    
    public void Run()
    {
        Load();
        GetRefrence();
        Getfulltext();
    }
    private void Load()
    {
        //Prompt the user for a filename and then load the refrence with it's accompaning scripture from that file. This should replace any entries currently stored the memorizer.
        bool fileloaded = false;

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
        
        //Clearing existing entries 
        //memorizer.Clear();
        Console.Write("Please enter the refrence of the scripture that you want to load: ");
        string inputRefrence = Console.ReadLine();
        // read all lines from the file 
        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines )
        { 
            string [] parts = line.Split("|");
            if(parts.Length >=2 && parts[0].Equals(inputRefrence, StringComparison.OrdinalIgnoreCase))
            {
            refrence = parts[0];
            fulltext = parts[1];
            Console.WriteLine($"{refrence} has loaded from {filename}");
            fileloaded = true;
            break;
            }
        }
           if (!fileloaded)
               {
                    Console.WriteLine("There doesn't seem to be a refrence here that matches your's\nPlease try again.");
                    continue;
               }
        }
    }

    public string GetRefrence()
    {
        Console.Write($"{refrence}  ");
        return refrence;
    }

    public string Getfulltext()
    {
        Console.WriteLine($"{fulltext}\n");
        return fulltext;
    }   

} 