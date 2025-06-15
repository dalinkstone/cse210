using System;

class Program
{
    static void Main(string[] args)
    {
	    Random randomGenerator = new Random();
	    int number = randomGenerator.Next(1, 100);
		
	    string response = "0";

	    Console.WriteLine("A magic number has been selected. Guess the magic number to win the game!");

	    while (int.Parse(response) != number)
	    {
		Console.Write("What is your guess? ");
		response = Console.ReadLine();

		if (int.Parse(response) > number)
		{
			Console.WriteLine("Lower");
		}
		else if (int.Parse(response) < number)
		{
			Console.WriteLine("Higher");
		}
		else 
		{
			Console.WriteLine("You guessed it!");
		}
	    }
    }	
}
