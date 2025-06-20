using System;

class Program
{
    static void Main(string[] args)
    {
        PromptGenerator promptRolodex = new PromptGenerator();
        Journal myJournal = new Journal();

        promptRolodex._prompts.Add("Who was the most interesting person I interacted with today?");
        promptRolodex._prompts.Add("What was the best part of my day?");
        promptRolodex._prompts.Add("How did I see the hand of the Lord in my life today?");
        promptRolodex._prompts.Add("What was the strongest emotion I felt today?");
        promptRolodex._prompts.Add("If I had one thing I could do over today, what would it be?");

        Console.WriteLine("Welcome to the Journal Program!");

        while (true)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            int selection = int.Parse(Console.ReadLine());
            Console.WriteLine();
            // I guess we haven't gone over these in class yet, but they are exactly
            // the same as in Python pretty much and repeats having to make a ton
            // of if statements. Which I'd rather not do honestly.
            switch (selection)
            {
                case 1:
                    Entry newEntry = new Entry();
                    newEntry._date = DateTime.Now.ToShortDateString();

                    string selectionPrompt = promptRolodex.GetRandomPrompt();
                    newEntry._promptText = selectionPrompt;

                    Console.WriteLine(selectionPrompt);
                    string writtenEntry = Console.ReadLine();

                    newEntry._entryText = writtenEntry;
                    myJournal._entries.Add(newEntry);

                    break;
                case 2:
                    myJournal.DisplayAll();
                    break;
                case 3:
                    Console.Write("What is the file name? ");
                    string fileNameLoad = Console.ReadLine();

                    myJournal.LoadFromFile(fileNameLoad);
                    break;
                case 4:
                    Console.Write("What is the file name? ");
                    string fileNameSave = Console.ReadLine();

                    myJournal.SaveToFile(fileNameSave);
                    break;

                // I found this explanation of exiting a program on c-sharpcorner.com
                // This seems like the closest thing I can get to Python-like functionality
                // https://www.c-sharpcorner.com/UploadFile/c713c3/how-to-exit-in-C-Sharp/
                case 5:
                    System.Environment.Exit(0);
                    break;
            }
        }
    }
}
