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

	Reference proverbs = new Reference("Proverbs", 3, 5, 6);
	Scripture proverbsScripture = new Scripture(proverbs, "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");

	List<Scripture> scriptureList = new List<Scripture> { johnScripture, proverbsScripture }; 
	Random randomNumber = new Random();
	int randomScripture = randomNumber.Next(scriptureList.Count);

	List<Reference> referenceList = new List<Reference> { john, proverbs };
	int randomReference = randomNumber.Next(referenceList.Count);

	Scripture scripture = scriptureList[randomScripture];
	Reference reference = referenceList[randomReference];

        Console.Clear();
        Console.Write(reference.GetDisplayText());
        Console.WriteLine(scripture.GetDisplayText());

        while (scripture.IsCompletelyHidden() == false)
        {
            Console.WriteLine("Press enter to hide a word or type 'quit' to exit");

            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "quit")
            {
                return;
            }

            scripture.HideRandomWords(2);
            Console.Clear();
            Console.Write(reference.GetDisplayText());
            Console.WriteLine(scripture.GetDisplayText());
        }
    	Console.ReadKey();
    }
}
