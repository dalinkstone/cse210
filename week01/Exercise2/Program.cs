using System;

class Program
{
    static void Main(string[] args)
    {
	string letter;
        Console.Write("What is your grade percentage? ");
	string grade = Console.ReadLine();

	int numGrade = int.Parse(grade);

	if (numGrade >= 90) 
	{
		letter = "A";
	}
	else if (numGrade >= 80)
	{
		letter = "B";
	}
	else if (numGrade >= 70) 
	{
		letter = "C";
	}
	else if (numGrade >= 60)
	{
		letter = "D";
	}
	else 
	{
		letter = "F";
	}

	
	Console.WriteLine($"Your grade is {letter}.");

	if (numGrade >= 70)
	{
		Console.WriteLine("You passed the class! Good Job!");
	}
	else
	{
		Console.WriteLine("You did not pass the class... Do better");
	}
		
		

    }
}
