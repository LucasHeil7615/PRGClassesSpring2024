
public abstract class Activity
{
    // Date of the activity
    public DateTime Date { get; set; }
    
    // Length of the activity in minutes
    public int DurationInMinutes { get; set; }

    protected Activity(DateTime date, int durationInMinutes)
    {
        Date = date;
        DurationInMinutes = durationInMinutes;
    }

    // methods to be used in each activty 
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    //generates a string that will print in program will be changed based on the acvtivty
    public virtual string GetSummary()
    {
        return $"{Date:dd MMM yyyy} {GetType().Name} ({DurationInMinutes} min): Distance {GetDistance()} units, Speed: {GetSpeed()} units per hour, Pace: {GetPace()} min per unit";
    }
}
