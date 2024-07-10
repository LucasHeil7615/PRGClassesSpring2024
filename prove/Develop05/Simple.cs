using System;
using System.Dynamic;

class Simple : Goal
{
    public Simple(int goalcount, string goalname, string description, int pointValue, int timescompleted): base(goalcount,goalname, description, pointValue, timescompleted){}
    public override string FileFormating()
    {
        return$"Simple||{goalcount}|{goalname}|{description}|{pointValue}|{timescompleted}";
    }

    public override void Markcomplete()
    {
        if (completed == false)
        {
            Console.WriteLine($"Congrats on completing {goalname}");
            totalpoints += pointValue;
            timescompleted++;
            completed = true;
        }
        else
        {
            Console.WriteLine("This goals has already been marked complete. ");
        }
    }
}
