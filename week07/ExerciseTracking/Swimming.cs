public class Swimming : Activity
{
  private double _numberOfLaps;

  public Swimming(DateTime date, int duration, double numberOfLaps) : base(date, duration)
  {
    _numberOfLaps = numberOfLaps;
  }

  private double GetLaps()
  {
    return _numberOfLaps;
  }

  public override double GetDistance()
  {
    return GetLaps() * ((50.0 / 1000.0) * 0.62);
  }

  public override double GetSpeed()
  {
    return (GetDistance() / GetDuration()) * 60;
  }

  public override double GetPace()
  {
    return GetDuration() / GetDistance();
  }

}
