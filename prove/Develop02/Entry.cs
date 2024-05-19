using System;
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;

class Entry
{

    public string Date {get; private set; }
    public string Prompt {get; private set;}
    public string Content {get; private set;}
    public Entry(string date, string prompt, string content)
    {
        Date = date;
        Prompt = prompt;
        Content = content;
    }
    
    public string Display() {
        string display = $"{Prompt} [{Date}]\n {Content}\n ";
        Console.WriteLine(display);
        return display;
    }
}