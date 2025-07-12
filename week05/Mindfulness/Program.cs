using System;

class Program
{
    static void Main(string[] args)
    {
        bool programRunning = true;

        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Start Breathing Activity");
        Console.WriteLine("2. Start Reflecting Activity");
        Console.WriteLine("3. Start Listing Activity");
        Console.WriteLine("4. Quit");
        Console.Write("Select a Choice from the menu: ");
        string input = Console.ReadLine();

        while (programRunning)
        {
            switch (input)
            {
                case "1":
                    BreathingActivity breathingActivity = new BreathingActivity(
                        "Breathing Activity",
                        "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing."
                    );
                    breathingActivity.Run();
                    break;
                //case "2":
                //    ReflectingActivity reflectingActivity = new ReflectingActivity("Reflecting Activity", "his activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                //    reflectingActivity.Run();
                //    break;
                //case "3":
                //    ListingActivity listingActivity = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                //    listingActivity.Run();
                //    break;
                case "4":
                    programRunning = false;
                    break;
            }
        }
    }
}
