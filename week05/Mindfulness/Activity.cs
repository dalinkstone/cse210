public class Activity
{
	protected string _name;
	protected string _description;
	protected int _duration;

	public Activity(string name, string description)
	{
		_name = name;
		_description = description;
		_duration = duration;
	}

	public int GetDuration()
	{
		return _duration;
	}

	public void SetDuration(int duration)
	{
		_duration = duration;
	}

  public void DisplayStartingMessage()
  {
    Console.WriteLine($"Welcome to the {_name}");
    Console.WriteLine();
    Console.WriteLine(_description);
  }
}
