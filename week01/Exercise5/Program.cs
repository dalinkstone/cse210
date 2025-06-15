using System;

class Program
{
    static void Main(string[] args)
    {
	    static void DisplayWelcome ()
	    {
		    Console.WriteLine("Welcome to the program!");
	    }

	    static string PromptUserName ()
	    {
		    Console.Write("Please enter your name: ");
		    string name = Console.ReadLine();

		    return name;
	    }

	    static int PromptUserNumber ()
	    {
		    Console.Write("Please enter your favorite number: ");
		    string userNumber = Console.ReadLine();

		    int favoriteNumber = int.Parse(userNumber);

		    return favoriteNumber;
	    }

	    static int SquareNumber (int num)
	    {
		    return num * num;
	    }

	    static void DisplayResult (string name, int num)
	    {
		    Console.WriteLine($"{name}, the square of your number is {num}");
	    }

	    DisplayWelcome();
	    
	    string userName = PromptUserName();
	    int userNumber = PromptUserNumber();
	    int square = SquareNumber(userNumber);
	    DisplayResult(userName, square);

    }
}
