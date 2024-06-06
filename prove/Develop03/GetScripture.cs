using System;
using System.Xml.Linq;
class GetScripture
{

    private string Refrence;
    private string fulltext;

    public void Run()
    {   
        GetRefrence();
        Getfulltext();
        Save();
    }

    private string GetRefrence()
    {
        Console.Write("\nEnter the refrence for your scripture: ");
        this.Refrence = Console.ReadLine();

        return Refrence;
    }

    private string Getfulltext()
    {
        Console.Write("Please write the fulltext for your scripture including wanted punctuation and numbers.\nEntry:");
        fulltext = Console.ReadLine();
        return fulltext;
    }   

    private void Save()
    {
        //Prompt the user for a fulltext and then save the current fulltext and refrence (the complete set scriptures) to the file location.
        Console.Write("Please enter the  file you wish to save this scripture into:");
        string filename = Console.ReadLine();
        using(StreamWriter outputFile = new StreamWriter(filename, true))
        {       
             outputFile.WriteLine($"{Refrence}|{fulltext}");
        }
        Console.WriteLine($"{Refrence} has been saved in {filename}. \n");
    }

}