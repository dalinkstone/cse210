public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;
    private bool _isRunning;

    public GoalManager()
    {

    }

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

    public void ListGoalNames()
    {

    }

    public void ListGoalDetails()
    {

    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal\n");

        Console.Write("Which type of goal would you like to create? ");
        string typeOfGoal = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        string nameOfGoal = Console.ReadLine();

        Console.Write("What is a short description of the goal? ");
        string descriptionOfGoal = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        string pointsOfGoal = Console.ReadLine();

        Goal newGoal;

        switch (typeOfGoal)
        {
            case "1":
                newGoal = SimpleGoal(nameOfGoal, descriptionOfGoal, pointsOfGoal);
                break;
            case "2":
                newGoal = EternalGoal(nameOfGoal, descriptionOfGoal, pointsOfGoal);
                break;
            case "3":
                newGoal = ChecklistGoal(nameOfGoal, descriptionOfGoal, pointsOfGoal);
                break;

        }

        _goals.Add(newGoal);
    }

    public void RecordEvent()
    {

    }

    public void SaveGoals()
    {

    }

    public void LoadGoals()
    {

    }
}
