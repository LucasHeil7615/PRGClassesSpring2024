using System;
using System.Runtime.CompilerServices;
abstract class Goal
{  
    protected string goalname;
    protected int pointValue;
    protected int totalpoints;
    protected string description;
    protected bool completed;
    protected int completionpoints;
    protected int goalcount;
    protected int timescompleted;

    private char check = ' ';
    
    protected Goal(int goalcount, string goalname, string description, int pointValue, int timescompleted)
    {
        this.goalname = goalname;
        this.description = description;
        this.goalcount = goalcount;
        this.pointValue = pointValue;
        this.timescompleted = timescompleted;
    }


    public abstract void Markcomplete();
    public abstract string FileFormating();

    public virtual char CheckBox()
    {
        check = completed ? 'X' : ' ';
        return check;
    }
    public int GetPoints()
    {
        return totalpoints;
    }
    public override string ToString()
    {
        return $"[{CheckBox()}]| Goal: {goalname}| Description: {description}| Points: {pointValue}  ";
    }
}