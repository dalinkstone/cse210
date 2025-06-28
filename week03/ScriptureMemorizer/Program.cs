using System;

class Program
{
    static void Main(string[] args)
    {
        Reference john = new Reference("John", 3, 16);
        Scripture johnScripture = new Scripture(
            john,
            "For God so loved the world, that He gave His only begotten Son, that whosoever believeth in Him should not perish, but have everlasting life."
        );

        Console.Clear();
        Console.Write(john.GetDisplayText());
        Console.WriteLine(johnScripture.GetDisplayText());

        while (johnScripture.IsCompletelyHidden() == false)
        {
            Console.WriteLine("Press enter to hide a word or type 'quit' to exit");

            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "quit")
            {
                return;
            }

            johnScripture.HideRandomWords(2);
            Console.Clear();
            Console.Write(john.GetDisplayText());
            Console.WriteLine(johnScripture.GetDisplayText());
        }
    	Console.ReadKey();
    }
}
