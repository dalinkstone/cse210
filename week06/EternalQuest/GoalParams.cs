public class GoalParams
{
	// So this will create a private field that I don't really
	// know the name of, but I can call it by doing Class.Field
	// if this isn't industry standard, let me know so I don't keep
	// doing this, but seemed simple enough??
	public string Name { get; set; }
	public string Description { get; set; }
	public string Points { get; set; }
	public int Target { get; set; }
	public int Bonus { get; set; }

	public GoalParams(string name, string description, string points)
	{
		Name = name;
		Description = description;
		Points = points;
	}

	public GoalParams(string name, string description, string points, int target, int bonus)
	{
		Name = name;
		Description = description;
		Points = points;
		Target = target;
		Bonus = bonus;
	}
}
