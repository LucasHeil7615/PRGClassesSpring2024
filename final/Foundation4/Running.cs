
public class Running : Activity
{
    private double _distance;

    public Running(DateTime date, int durationInMinutes, double distance) 
        : base(date, durationInMinutes)
    {
        _distance = distance;
    }

    //gets the distance
    public override double GetDistance()
    {
        return _distance;
    }

    //gets the speed in mph
    public override double GetSpeed()
    {
        return (_distance / DurationInMinutes) * 60;
    }

    //gets the pace in minutes/mile
    public override double GetPace()
    {
        return DurationInMinutes / _distance;
    }
}
