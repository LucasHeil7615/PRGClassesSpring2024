using System;
using System.ComponentModel.DataAnnotations;

class Checklist : Goal
{
    private int timesneeded; //number of times checklist goal must be recorded before completion
    public Checklist(int goalcount, string goalname, string description, int pointValue,int timescompleted, int completionpoints,int timesneeded): base(goalcount, goalname, description, pointValue, timescompleted)
    {
        this.timesneeded = timesneeded;
        this.completionpoints = completionpoints;
    }
    
    public override string FileFormating()
    {
        return$"Checklist||{goalcount}|{goalname}|{description}|{pointValue}|{timescompleted}|{completionpoints}|{timesneeded}";
    }
    public override void Markcomplete()
    {
       if (timescompleted == timesneeded)
       {
        Console.WriteLine($"Congrats on completing {goalname}! Here are your extra points!");
            totalpoints += pointValue + completionpoints;
            timescompleted++;
            completed = true;
       }
       else 
       {
            if(completed == false)
            {
            Console.WriteLine($"Nice job! keep it up to finish {goalname}.");
            totalpoints += pointValue;
            timescompleted++;
            }
            else
            {
                Console.WriteLine("This goal has already been completed.");
            }
       }
    }
    public override char CheckBox()
    {
        if (completed)
        {
            return 'X';
        }
        else 
        {
            return ' ';
        }
    }
}