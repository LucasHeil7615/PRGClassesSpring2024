
public class Cycling : Activity
{
   
    private double _speed;

    public Cycling(DateTime date, int durationInMinutes, double speed) 
        : base(date, durationInMinutes)
    {
        _speed = speed;
    }

    //gets the distance based on speed
    public override double GetDistance()
    {
        return (_speed / 60) * DurationInMinutes;
    }

    //gets the speed
    public override double GetSpeed()
    {
        return _speed;
    }

    //gets the pace in min / mile
    public override double GetPace()
    {
        return 60 / _speed;
    }
}
