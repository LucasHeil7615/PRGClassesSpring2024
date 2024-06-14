using System;
using System.Linq;

class Scripture
{
    private List<Word> listwords = new List<Word>();

    
    private List<int> openwords;

    private string reference;

    private bool quit =false;


    public void Run()
    {
        while(!quit)
        {
            Console.Clear();
            display();
            hidewords();
            Console.WriteLine("Press enter to continue hiding words. Press quit to retrun to menu. ");
            if (Console.ReadLine() == "quit")
            {
                quit = true;
            } 
        }
    }
    public Scripture(string fulltext, string reference)
    {
        this.reference = reference;
        this.Splitter(fulltext);
        this.openwords = Enumerable.Range(0, listwords.Count).ToList();
    }

    private void Splitter(string fulltext)
    {
        string[] splittext = fulltext.Split(" "); 
        foreach (string word in splittext)
        {
        Word bloop = new Word(word);
        listwords.Add(bloop);   
        }
    }

        public void hidewords()
    {
        if (openwords.Count != 0)
        {
            Random random = new Random();
            int randIndex = random.Next(openwords.Count);
            int wordIndex = openwords[randIndex];
            listwords[wordIndex].Hide();
            openwords.RemoveAt(randIndex);
        }
    }

    private void display()
    {
       string fulltext = string.Join(' ', listwords.Select(word => word.GetWord()));
       Console.WriteLine($"{reference}: {fulltext}");

    }
}