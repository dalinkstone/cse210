public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description)
        : base(name, description) { }

    public void Run()
    {
        DisplayStartingMessage();
        int duration = GetDuration();
        Console.Clear();
        Console.WriteLine("Get Ready...");
        ShowSpinner(5);

        int cycles = duration / 15;

        for (int i = 0; i < cycles; i++)
        {
            Console.Write("Breathe in...");
            ShowCountDown(1);
            Console.WriteLine();

            Console.Write("Now breathe out...");
            ShowCountDown(4);
            Console.WriteLine();
            Console.WriteLine("\n");

            Console.Write("Breathe in...");
            ShowCountDown(4);
            Console.WriteLine();

            Console.Write("Now breathe out...");
            ShowCountDown(6);
            Console.WriteLine("\n");
        }

        DisplayCongrats();
        ShowSpinner(5);
        DisplayEndingMessage();
        ShowSpinner(5);
    }
}
