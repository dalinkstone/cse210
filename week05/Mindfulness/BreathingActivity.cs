public class BreathingActivity : Activity
{
	public BreathingActivity(string name, string description) : base(name, description)
	{
	
	}

	public void Run()
	{
		DisplayStartingMessage();
		int duration = GetDuration();
		Console.Clear();
		Console.WriteLine("Get Ready...")
		ShowSpinner();
		Console.WriteLine();

	}
}
