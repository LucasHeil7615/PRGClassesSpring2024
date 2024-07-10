using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;

class Manager 
{
    private int goalcount = 0;
    private int totalpoints;
    private List<Goal> goals = new List<Goal>();

    public void Load()
    {
        LoadTool();
    }

    public void Create()
    {
        CreateGoal();
    }

    public void Display()
    {
        DisplayAll();
    }

    public void RecordEvent()
    {
        Record();
    }
    public void GetScore()
    {
        totalpoints = goals.Sum(goal => goal.GetPoints());
        Console.WriteLine($"Score: {totalpoints}");
    }

    private void Save()
    {
        Console.Write("Please enter the filename you wish to save these goals to: ");
        string filename = Console.ReadLine() + ".txt";

        File.WriteAllText(filename, string.Empty);

        using (StreamWriter outputFile = new StreamWriter(filename, true))
        {
            foreach (Goal goal in goals)
            {
                outputFile.WriteLine(goal.FileFormating());
            }
        }

        Console.WriteLine($"Your goals have been saved in {filename}");
    }

     private void LoadTool()
    {
        Console.WriteLine("Please enter the filename you would like to load: ");
        string filename = Console.ReadLine() + ".txt";

        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        goals.Clear();

        try
        {
            string[] lines = File.ReadAllLines(filename);

            foreach (string line in lines)
            {
                string[] parts = line.Split("||");


                string type = parts[0];
                string[] goaldata = parts[1].Split("|");

                switch (type)
                {
                    case "Simple":
                        if (goaldata.Length < 5)
                        {
                            Console.WriteLine($"Incomplete data in {filename}. Skipping...");
                            continue;
                        }
                        int simpleGoalCount = int.Parse(goaldata[0]);
                        string simpleGoalName = goaldata[1];
                        string simpleDescription = goaldata[2];
                        int simplePointValue = int.Parse(goaldata[3]);
                        int simpleTimesCompleted = int.Parse(goaldata[4]);
                        Simple simpleGoal = new Simple(simpleGoalCount, simpleGoalName, simpleDescription, simplePointValue, simpleTimesCompleted);
                        goals.Add(simpleGoal);
                        break;

                    case "Eternal":
                        if (goaldata.Length < 5)
                        {
                            Console.WriteLine($"Incomplete data in {filename}.");
                            Console.WriteLine($"Please ensure data in {filename} is correct.");
                            break;
                        }
                        int eternalGoalCount = int.Parse(goaldata[0]);
                        string eternalGoalName = goaldata[1];
                        string eternalDescription = goaldata[2];
                        int eternalPointValue = int.Parse(goaldata[3]);
                        int eternalTimesCompleted = int.Parse(goaldata[4]);
                        Eternal eternalGoal = new Eternal(eternalGoalCount, eternalGoalName, eternalDescription, eternalPointValue, eternalTimesCompleted);
                        goals.Add(eternalGoal);
                        break;

                    case "Checklist":
                        if (goaldata.Length < 7)
                        {
                            Console.WriteLine($"Incomplete data in {filename}.");
                            Console.WriteLine($"Please ensure data in {filename} is correct.");
                            break;
                        }
                        int checklistGoalCount = int.Parse(goaldata[0]);
                        string checklistGoalName = goaldata[1];
                        string checklistDescription = goaldata[2];
                        int checklistPointValue = int.Parse(goaldata[3]);
                        int checklistTimesCompleted = int.Parse(goaldata[4]);
                        int checklistCompletionPoints = int.Parse(goaldata[5]);
                        int checklistTimesNeeded = int.Parse(goaldata[6]);
                        Checklist checklistGoal = new Checklist(checklistGoalCount, checklistGoalName, checklistDescription, checklistPointValue,   checklistTimesCompleted, checklistCompletionPoints, checklistTimesNeeded);
                        goals.Add(checklistGoal);
                        break;

                    case "Habit":
                        if (goaldata.Length < 8)
                        {
                            Console.WriteLine($"Incomplete data in {filename}.");
                            Console.WriteLine($"Please ensure data in {filename} is correct.");
                            break;
                        }
                        int habitGoalCount = int.Parse(goaldata[0]);
                        string habitGoalName = goaldata[1];
                        string habitDescription = goaldata[2];
                        int habitPointValue = int.Parse(goaldata[3]);
                        int habitTimesCompleted = int.Parse(goaldata[4]);
                        int habitCompletedPoints = int.Parse(goaldata[5]);
                        int habitDuration = int.Parse(goaldata[6]);
                        int habitFrequency = int.Parse(goaldata[7]);
                        Habit habitGoal = new Habit(habitGoalCount, habitGoalName, habitDescription, habitPointValue, habitTimesCompleted,  habitCompletedPoints, habitDuration, habitFrequency);
                        goals.Add(habitGoal);
                        break;

                    default:
                        Console.WriteLine($"Unknown goal type '{type}' in {filename}.");
                        Console.WriteLine($"Please ensure data in {filename} is correct.");
                        break;
                }
            }

            goalcount = goals.Count;
            Console.WriteLine($"Goals have been loaded from {filename}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading goals from {filename}: {ex.Message}");
        }
    }

    private void CreateGoal()
{
    bool notcreated = true;

    while (notcreated)
    {
        Console.WriteLine("What type of Goal would you like to create?");
        Console.WriteLine("1. Simple");
        Console.WriteLine("2. Eternal");
        Console.WriteLine("3. Checklist");
        Console.WriteLine("4. Habit");
        Console.Write("(Enter an int) Type: ");
        int goalType = int.Parse(Console.ReadLine());

        if (goalType < 1 || goalType > 4 || !(goalType is int))
        {
            Console.WriteLine("Invalid type. Please enter 1 for Simple, 2 for Eternal, 3 for Checklist, and 4 for Habit.");
            continue;
        }

        Console.WriteLine("What would you like to name your goal?");
        Console.Write("Goalname: ");
        string goalName = Console.ReadLine();

        Console.WriteLine("Describe your goal. Be specific.");
        Console.Write("Description: ");
        string description = Console.ReadLine();

        int timesCompleted = 0;
        int pointValue;

        switch (goalType)
        {
            case 1:
                goalcount++;
                Console.WriteLine("How many points would you like to assign to this Goal?");
                Console.Write("Points: ");
                pointValue = int.Parse(Console.ReadLine());
                Simple simple = new Simple(goalcount, goalName, description, pointValue, timesCompleted);
                goals.Add(simple);
                Save();
                notcreated = false;
                break;

            case 2:
                goalcount++;
                Console.WriteLine("How many points would you like to assign to this Goal?");
                Console.Write("Points: ");
                pointValue = int.Parse(Console.ReadLine());
                Eternal eternal = new Eternal(goalcount, goalName, description, pointValue, timesCompleted);
                goals.Add(eternal);
                Save();
                notcreated = false;
                break;

            case 3:
                goalcount++;
                Console.WriteLine("How many times would you like to do this goal? ");
                Console.Write("Number of times done until completion: ");
                int timesNeeded = int.Parse(Console.ReadLine());

                Console.WriteLine("How many points would you like to receive each time you accomplish this task?");
                Console.Write("Point Value: ");
                pointValue = int.Parse(Console.ReadLine());

                Console.WriteLine("How many points would you like to receive when you fully complete this task?");
                Console.Write("Completion Points: ");
                int completionPoints = int.Parse(Console.ReadLine());

                Checklist checklist = new Checklist(goalcount, goalName, description, pointValue, timesCompleted, completionPoints, timesNeeded);
                goals.Add(checklist);
                Save();
                notcreated = false;
                break;

            case 4:
                goalcount++;
                Console.WriteLine("How many points would you like to assign to this Goal?");
                Console.Write("Points: ");
                pointValue = int.Parse(Console.ReadLine());

                Console.WriteLine("How often do you want to complete this habit?");
                Console.WriteLine("1. Daily");
                Console.WriteLine("2. Weekly");
                Console.WriteLine("3. Monthly");
                Console.WriteLine("4. Yearly");
                Console.Write("(Enter an int) Frequency: ");
                int frequency = int.Parse(Console.ReadLine());

                if (frequency < 1 || frequency > 4)
                {
                    Console.WriteLine("Invalid frequency. Please enter 1 for Daily, 2 for Weekly, 3 for Monthly, and 4 for Yearly.");
                    continue;
                }

                Console.WriteLine("How many days/weeks/months/years do you want this habit to last?");
                Console.Write("Duration: ");
                int duration = int.Parse(Console.ReadLine());

                Console.WriteLine("How many points do you want when this habit reaches the duration?");
                Console.Write("Completion Points: ");
                int completedPoints = int.Parse(Console.ReadLine());

                Habit habit = new Habit(goalcount, goalName, description, pointValue, timesCompleted, completedPoints, duration, frequency);
                goals.Add(habit);
                Save();
                notcreated = false;
                break;

            default:
                Console.WriteLine("Invalid entry");
                continue;
        }
    }
}


    private void Record()
    {
        Console.WriteLine("Which goal would you like to record?");
        DisplayAll();
        Console.Write("Goal number: ");
        int selectedgoal = int.Parse(Console.ReadLine()) - 1;

        if (selectedgoal >= 0 && selectedgoal <= goals.Count)
        {
            goals[selectedgoal].Markcomplete();
        }
        else
        {
            Console.WriteLine("Invalid goal number.");
        }
    }

    private void DisplayAll()
    {
        if (goals.Count != 0)
        {
            int count = 1;
            foreach (Goal goal in goals)
            {
                Console.WriteLine($"Goal number: {count}");
                Console.WriteLine(goal);
                count++;
            }
        }
        else
        {
            Console.WriteLine("No goals loaded yet. Please select 'Load' from the menu.");
        }
    }
}
