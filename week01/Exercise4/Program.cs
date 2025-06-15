using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

	Console.WriteLine("Enter a list of numbers, type 0 when finished.");

	List<int> numbers = new List<int>();
	string response;
	int num = -1;
	int sum = 0;
	int max = 0;

	while (num != 0)
	{
		Console.Write("Enter a number: ");
		response = Console.ReadLine();

		num = int.Parse(response);
		
		if (num != 0)
		{
			numbers.Add(num);
		}
	}

	foreach (int number in numbers)
	{
		sum += number;
	}

	foreach (int number in numbers)
	{
		if (number > max)
		{
			max = number;
		}
	}

	double average = (double)sum / numbers.Count;

	Console.WriteLine($"The sum is: {sum}");
	Console.WriteLine($"The average is: {average}");
	Console.WriteLine($"The largest number is: {max}");

    }
}
