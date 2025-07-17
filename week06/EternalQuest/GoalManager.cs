public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;
    private bool _isRunning;

    public GoalManager() { }

    public void Start()
    {
        _isRunning = true;

        while (_isRunning)
        {
            Console.Clear();

            DisplayPlayerInfo();

            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a Choice from the menu: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.Clear();
                    CreateGoal();

                    break;
                case "2":
                    Console.Clear();

                    break;
                case "3":
                    Console.Clear();

                    break;
                case "4":
                    Console.Clear();

                    break;
                case "5":
                    Console.Clear();

                    break;
                case "6":
                    _isRunning = false;

                    break;
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.\n");
    }

    public void ListGoalNames() { }

    public void ListGoalDetails() { }

    private GoalParams CreateGoalType(string type)
    {
        GoalParams goalParams;
        string nameOfGoal;
        string descriptionOfGoal;
        string pointsOfGoal;
        int targetOfGoal;
        int bonusOfGoal;

        switch (type)
        {
            case "1":
            case "2":
                Console.Write("What is the name of your goal? ");
                nameOfGoal = Console.ReadLine();

                Console.Write("What is a short description of the goal? ");
                descriptionOfGoal = Console.ReadLine();

                Console.Write("What is the amount of points associated with this goal? ");
                pointsOfGoal = Console.ReadLine();

                goalParams = new GoalParams(nameOfGoal, descriptionOfGoal, pointsOfGoal);

                return goalParams;
            case "3":

                Console.Write("What is the name of your goal? ");
                nameOfGoal = Console.ReadLine();

                Console.Write("What is a short description of the goal? ");
                descriptionOfGoal = Console.ReadLine();

                Console.Write("What is the amount of points associated with this goal? ");
                pointsOfGoal = Console.ReadLine();

                Console.Write(
                    "How many times does this goal need to be accomplished for a bonus? "
                );
                targetOfGoal = int.Parse(Console.ReadLine());

                Console.Write("What is the bonus for accomplishing this goal that many times? ");
                bonusOfGoal = int.Parse(Console.ReadLine());

                goalParams = new GoalParams(
                    nameOfGoal,
                    descriptionOfGoal,
                    pointsOfGoal,
                    targetOfGoal,
                    bonusOfGoal
                );

                return goalParams;
	   default:
		Console.WriteLine("That is not a valid goal type.");
		throw new ArgumentException("Invalid goal type");
        }

    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal\n");

        Console.Write("Which type of goal would you like to create? ");
        string typeOfGoal = Console.ReadLine();

        Goal newGoal;

        switch (typeOfGoal)
        {
            case "1":
                // i know that what i am doing here is not necessarily best practice
                // if i could do this again i would create a class for the input
                // so that it is strongly typed and then i can call the attributes
                // but having to write another class makes me struggle with
                // the line between good DRY and abstraction vs. complexity demon
                GoalParams simpleParams = CreateGoalType(typeOfGoal);
                newGoal = new SimpleGoal(
                    simpleParams.Name,
                    simpleParams.Description,
                    simpleParams.Points
                );
                _goals.Add(newGoal);
                break;
            case "2":
                GoalParams eternalParams = CreateGoalType(typeOfGoal);
                newGoal = new EternalGoal(
                    eternalParams.Name,
                    eternalParams.Description,
                    eternalParams.Points
                );
                _goals.Add(newGoal);
                break;
            case "3":
                GoalParams checklistParams = CreateGoalType(typeOfGoal);
                newGoal = new ChecklistGoal(
                    checklistParams.Name,
                    checklistParams.Description,
                    checklistParams.Points,
                    checklistParams.Target,
                    checklistParams.Bonus
                );
                _goals.Add(newGoal);
                break;
        }
    }

    public void RecordEvent() { }

    public void SaveGoals() { }

    public void LoadGoals() { }
}
