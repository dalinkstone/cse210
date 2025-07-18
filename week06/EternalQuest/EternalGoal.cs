public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, string points)
        : base(name, description, points) { }

    public override void RecordEvent() 
    {
      Console.WriteLine($"Congratulations you have earned {GetPoints()}");
      Console.WriteLine($"Congratulations you have accomplished the {GetName()} goal again!\n");
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"{GetType().Name}:{_shortName},{_description},{_points}";
    }
}
