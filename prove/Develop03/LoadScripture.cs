using System;
class LoadScripture
{

    private string fulltext;
    private string refrence;

    public void Run()
    {
        Load();
        Getfulltext();
        GetRefrence();
    }
    private void Load()
    {
        //Prompt the user for a filename and then load the refrence with it's accompaning scripture from that file. This should replace any entries currently stored the memorizer.
        Console.Write("Please enter the filename you would like to enter: ");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
        {
            Console.WriteLine("File not Found.");
            return;
        }

        //Clearing existing entries 
        //memorizer.Clear();

        Console.Write("Please enter the refrence of the scripture that you want to load: ");
        string refrence = Console.ReadLine();
        // read all lines from the file 
        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines )
        { 
               if(line.Substring(0,refrence.Count()) == refrence)
               {
                 string [] parts = line.Split("|");
                refrence = parts[0];
                fulltext = parts[1];
               }

               else
               {
                    Console.WriteLine("There doesn't seem to be a refrence here that matches your's\nPlease try again.");
                    break;
               }
        }
        Console.WriteLine($"{refrence} has loaded from {filename}");

    }

    public string GetRefrence()
    {
        Console.Write($"{refrence}");
        return refrence;
    }

    public string Getfulltext()
    {
        Console.WriteLine($"{fulltext}\n");
        return fulltext;
    }   

} 