using System;

class Program
{
    static void Main(string[] args)
    {
	Assignment newAssignment = new Assignment("Samuel Bennet", "Multiplication");
	Console.WriteLine(newAssignment.GetSummary());
    }
}
