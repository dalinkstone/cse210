using System;

public class ReflectingActivity : Activity
{
    private Random _randomGenerator = new Random();
    private int _pastNumber;
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless.",
    };
    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?",
    };

    public ReflectingActivity(string name, string description)
        : base(name, description) { }

    private string GetRandomPrompt()
    {
        int number = _randomGenerator.Next(0, _prompts.Count);
        return _prompts[number];
    }

    private void SetRandomNumber(int randomNum) 
    {
	_pastNumber = randomNum;
    }

    private string GetRandomQuestion()
    {
        
	int number = _randomGenerator.Next(0, _questions.Count);
	
	// finally a real application of recursion that makes sense in my brain
	// despite this code not being super robust, i wanted an excuse to actually
	// use recursion
	if (number == _pastNumber)
	{
		return GetRandomQuestion();	
	}

        SetRandomNumber(number);

	return _questions[number];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine("Consider the following prompt:");

        Console.WriteLine($"--- {GetRandomPrompt()} ---");
	Console.WriteLine("\n");

        Console.WriteLine("When you have something in mind, press enter to continue.");
    }

    public void DisplayQuestions() 
    {
	Console.Write(GetRandomQuestion());
    }

    public void Run()
    {
        DisplayStartingMessage();
        int duration = GetDuration();
        Console.Clear();
        Console.WriteLine("Get Ready...");
        ShowSpinner(5);

        DisplayPrompt();
        while (true)
        {
            ConsoleKeyInfo enterKey = Console.ReadKey(true);

            if (enterKey.Key == ConsoleKey.Enter)
            {
                break;
            }
        }

	Console.WriteLine("\n");
	Console.WriteLine("Now Ponder on each of the following questions as they related to this experience.");
	Console.Write("You may begin in: ");
	ShowCountDown(5);
	Console.Clear();

	int cycles = duration / 15;
	
	for (int i = 0; i < cycles; i++)
	{
		DisplayQuestions();
		ShowSpinner(15);
	}

	Console.WriteLine();

        DisplayCongrats();
        ShowSpinner(5);
        DisplayEndingMessage();
        ShowSpinner(5);
    }
}
