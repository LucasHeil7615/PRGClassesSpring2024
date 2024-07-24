
public class Swimming : Activity
{
    private int _laps;

    public Swimming(DateTime date, int durationInMinutes, int laps) 
        : base(date, durationInMinutes)
    {
        _laps = laps;
    }

    //gets the distance in miles
    public override double GetDistance()
    {
        return _laps * 50 / 1000 * 0.62; // Convert meters to miles
    }

    //gets the speed in mph
    public override double GetSpeed()
    {
        return (GetDistance() / DurationInMinutes) * 60;
    }

    //gets the pace in min per mile
    public override double GetPace()
    {
        return DurationInMinutes / GetDistance();
    }
}
