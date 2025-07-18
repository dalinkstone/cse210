public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, string points)
        : base(name, description, points) { }

    public override void RecordEvent() { }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"{this.GetType().Name}:{_shortName},{_description},{_points},{_isComplete}";
    }
}
