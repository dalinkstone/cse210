public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, string points)
        : base(name, description, points) { }

    public override void RecordEvent() 
    {
      Console.WriteLine($"Congratulations you have earned {GetPoints()}!");
      Console.WriteLine($"You have completed the {GetName()} goal!\n");
      _isComplete = true;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"{GetType().Name}:{_shortName},{_description},{_points},{_isComplete}";
    }
}
