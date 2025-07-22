public class Cycling : Activity
{
  private double _speed;

  public Cycling(DateTime date, int duration, double speed) : base(date, duration)
  {
    _speed = speed;
  }

  public override double GetDistance()
  {
    return (GetDuration() / 60) * GetPace();
  }

  public override double GetSpeed()
  {
    return _speed;
  }

  public override double GetPace()
  {
    return 60 / GetSpeed();
  }
}
