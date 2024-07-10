class Habit : Goal
{
    private int duration;
    private int frequency;

    private int completedpoints;
    public Habit(int goalcount, string goalname, string description, int pointValue,int timescompleted,int completedpoints, int duration, int frequency)
        : base(goalcount, goalname, description, pointValue, timescompleted)
    {
        this.duration = duration;
        this.frequency = frequency;
        this.completedpoints = completedpoints;
    }

    public override void Markcomplete()
    {
        Console.WriteLine($"Well done! You continued you work on your habit: {goalname}");
        totalpoints += pointValue;
        timescompleted++;

        if (timescompleted >= duration)
        {
            Console.WriteLine($"Congratualtions! you have completed your Habit goal {goalname}!");
            completed = true;
            totalpoints += completedpoints;
        }
    }

      public override string ToString()
    {
        string frequencyString = frequency == 1 ? "Daily" : frequency == 2 ? "Weekly" : frequency == 3 ? "Monthly" : "Yearly";
        return $"[{CheckBox()}]| Goal: {goalname} |Description: {description}|Points: {pointValue}| Completed: {timescompleted}|Completedpoints {completedpoints}| Duration: {duration}| Frequency:  {frequencyString}";
    }

    public override char CheckBox()
    {
        return completed ? 'X' : ' ';
    }

    public override string FileFormating()
    {
        return $"Habit||{goalcount}|{goalname}|{description}|{pointValue}|{timescompleted}|{completedpoints}|{duration}|{frequency}";
    }
}
