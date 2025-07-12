using System;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;
    private List<string> _animation = new List<string>({"|", "/", "-", "\\", "|", "/", "-", "\\"});
    private DateTime startTime;
    private DateTime endTime;
    private string s;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public string GetName()
    {
	    return _name;
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
	Console.WriteLine();
	Console.Write("How long, in seconds, would you like for your session? ");
	SetDuration(int.Parse(Console.ReadLine()));
    }

    public void DisplayEndingMessage()
    {
	    Console.WriteLine($"You have completed {GetDuration()} seconds of {GetName()}");
    }

    public void ShowSpinner(int seconds)
    {
	startTime = DateTime.Now;
	endTime = startTime.AddSeconds(seconds);
	i = 0;

	while (DateTime.Now < endTime)
	{
		string s = _animation[i];
		Console.Write(s);
		Thread.Sleep(750);
		Console.Write("\b \b");
		i++;
		
		if (i >= _animation.Count)
		{
			i = 0;
		}
	}

    }

    public void ShowCountDown(int seconds)
    {
	startTime = DateTime.Now;
	endTime = startTime.AddSeconds(seconds);
	i = 0;
	
	while (DateTime.Now < endTime)
	{

	}
    }
}
