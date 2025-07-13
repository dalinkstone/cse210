public class ListingActivity : Activity
{
    private int _count;
    private Random _randomGenerator = new Random();
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?",
    };

    public ListingActivity(string name, string description)
        : base(name, description) { }

    private string GetRandomPrompt()
    {
        int number = _randomGenerator.Next(0, _prompts.Count);
        return _prompts[number];
    }

    private void DisplayPrompt()
    {
        Console.WriteLine("List as many response you can to the following prompt:");

        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        Console.WriteLine();
    }

    private void GetListFromUser(int duration)
    {
        List<string> userList = new List<string>();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(duration);

        while (DateTime.Now < futureTime)
        {
            string userInput = Console.ReadLine();
            userList.Add(userInput);
        }
	
	_count = userList.Count;

    }

    public void Run()
    {
        DisplayStartingMessage();
        int duration = GetDuration();
        Console.Clear();
        Console.WriteLine("Get Ready...");
        ShowSpinner(5);

        DisplayPrompt();
        Console.Write("You May begin in: ");

        ShowCountDown(5);
	Console.WriteLine();

        GetListFromUser(duration);

        Console.WriteLine();

	Console.WriteLine($"You listed {_count} items!");

	Console.WriteLine();

        DisplayCongrats();
        ShowSpinner(5);
        DisplayEndingMessage();
        ShowSpinner(5);
    }
}
