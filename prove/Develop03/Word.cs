using System;

class Word
{

    private bool hidden = false;
    private string word;

    public Word(string word)
    {
        this.word = word;
    }

    public string GetWord()
    {
        if (hidden)
        {
            return new string('_', count: word.Length);
        }
        else 
        {
            return word;
        }
    }
    
    public void Hide()
    {
        this.hidden = true;
    }

}