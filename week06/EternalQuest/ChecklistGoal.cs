public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, string points, int target, int bonus)
        : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent() { }

    public override bool IsComplete()
    {
        if (_amountCompleted == _target)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override string GetDetailsString()
    {
        if (IsComplete())
        {
            return $"[ X ] {_shortName} ({_description}) --- Currently Completed: {_amountCompleted}/{_target}";
        }
        else
        {
            return $"[ ] {_shortName} ({_description}) --- Currently Completed: {_amountCompleted}/{_target}";
        }
    }

    public override string GetStringRepresentation()
    {
        return $"{GetType().Name}:{_shortName},{_description},{_points},{_amountCompleted},{_target},{_bonus}";
    }
}
