using System;

class Scripture
{
    public List<Word> newlistwords = new List<Word>();

   // public List<Word> hiddenlistword;
    
    public Scripture()
    {
        
    }
    public void Splitter()
    {
        string fulltext = "happy dance";
        string[] splittext = fulltext.Split(" "); 
        foreach (string word in splittext)
        {
        Word bloop = new Word(word);
        newlistwords.Append(bloop);   
        }
    }

}