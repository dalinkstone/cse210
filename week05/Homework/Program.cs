using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment newAssignment = new Assignment("Samuel Bennet", "Multiplication");
	Console.WriteLine(newAssignment.GetSummary());
        
	Console.WriteLine();
        
	MathAssignment newMathAssignment = new MathAssignment(
            "Roberto Rodriguez",
            "Fractions",
            "7.3",
            "8-19"
        );
        Console.WriteLine(newMathAssignment.GetSummary());
        Console.WriteLine(newMathAssignment.GetHomeworkList());
        
	Console.WriteLine();

	WritingAssignment newWritingAssignment = new WritingAssignment("Mandy Water", "European History", "The Causes of World War II");
	Console.WriteLine(newWritingAssignment.GetSummary());
	Console.WriteLine(newWritingAssignment.GetWritingInformation());
    }
}
