public abstract class Activity
{

	protected DateTime _date;
	protected double _duration;

  public abstract double GetDistance();
  public abstract double GetSpeed();
  public abstract double GetPace();

  public Activity(DateTime date, int duration)
  {
    _date = date;
    _duration = duration;
  }

  public DateTime GetDate()
  {
    return _date;
  }

  public double GetDuration()
  {
    return _duration;
  }

  public string GetSummary()
  {
    string dateFormatted = GetDate().ToString("dd MMM yyyy");

    return $"{dateFormatted} {GetType().Name} ({GetDuration()} min): Distance {GetDistance():F2} miles, Speed {GetSpeed():F2} mph, Pace {GetPace():F2} min per mile";
  }

}
