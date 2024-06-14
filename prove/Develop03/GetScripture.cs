using System;
class GetScripture
{

    private string Reference;
    private string fulltext;

    public void Run()
    {   
        GetReference();
        
        Getfulltext();
        Save();
    }

    private string GetReference()
    {
        Console.Write("\nEnter the reference for your scripture: ");
        this.Reference = Console.ReadLine();

        return Reference;
    }

    private string Getfulltext()
    {
        Console.Write("Please write the fulltext for your scripture including wanted punctuation and numbers.\nEntry:");
        fulltext = Console.ReadLine();
        return fulltext;
    }   

    private void Save()
    {
        //Prompt the user for a fulltext and then save the current fulltext and reference (the complete set scriptures) to the file location.
        Console.Write("Please enter the  file you wish to save this scripture into:");
        string filename = Console.ReadLine();
        using(StreamWriter outputFile = new StreamWriter(filename, true))
        {       
             outputFile.WriteLine($"{Reference}|{fulltext}");
        }
        Console.WriteLine($"{Reference} has been saved in {filename}. \n");
    }

}