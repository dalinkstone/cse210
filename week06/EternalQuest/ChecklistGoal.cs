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
        _amountCompleted = 0;
    }

    public int GetBonus()
    {
      return _bonus;
    }

    public void SetAmountCompleted()
    {
      _amountCompleted++;
    }

    public string GetChecklistPoints()
    {
      return _points;
    }

    public string GetPoints()
    {   
      string totalPoints;
      if (IsComplete())
      {
        int tempPoints = GetBonus() + int.Parse(GetChecklistPoints());
        totalPoints = tempPoints.ToString();
      }
      else
      {
          totalPoints = GetChecklistPoints();
      }
        return totalPoints;
    }

    public override void RecordEvent() 
    {
      SetAmountCompleted();
      GetPoints();  
        Console.WriteLine($"Congratulations you have earned {GetPoints()}");
      Console.WriteLine($"Congratulations you accomplished the {GetName()} goal!");
    }

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
