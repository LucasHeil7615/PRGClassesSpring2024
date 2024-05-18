using System;
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;

class Entry
{

    Fillings fillings = new Fillings();

    string date;
    string prompt;
    string content;
    public Entry(string date, string prompt, string content)
    {
        this.date = date;
        this.prompt = prompt;
        this.content = content;
    }
    
    public string Display() {
        string display = $"{prompt} [{date}]\n{content}\n ";
        Console.WriteLine(display);
        return display;
    }
}