using System;
using System.Security.Cryptography.X509Certificates;

class Eternal : Goal

{
    public Eternal(int goalcount, string goalname,  string description, int pointValue, int timescompleted): base(goalcount,goalname, description, pointValue, timescompleted)
    {

    }
    public override string FileFormating()
    {
        return$"Eternal||{goalcount}|{goalname}|{description}|{pointValue}|{timescompleted}";
    }

    public override void Markcomplete()
    {
        Console.WriteLine($"Congrats on completing {goalname} again. ");
        totalpoints += pointValue;
        timescompleted++;
        Console.WriteLine($"You have completed this goal {timescompleted} times.");
    }
    public override char CheckBox()
    {
        return '∞';
    }

}   