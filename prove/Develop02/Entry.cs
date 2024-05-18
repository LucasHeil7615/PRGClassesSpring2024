using System;
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;

class Entry
{

    Fillings fillings = new Fillings();

    string date = "";
    string prompt = "";
    string content = "";
    public Entry(string date, string prompt, string content)
    {
        this.date = fillings.GetDateTime();
        this.prompt = fillings.Prompt();
        this.content = content;
    }
    
    public void Display() {
        Console.WriteLine($"{prompt} [{date}]\n{content}\n ");
    }
}