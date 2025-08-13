public abstract class Goal
{
    public string Name { get; private set; }
    public string Description { get; private set; }
    public int Points { get; private set; }
    public abstract bool IsComplete { get; }

    public Goal(string name, string description, int points)
    {
        Name = name;
        Description = description;
        Points = points;
    }

    public abstract int RecordEvent();
    public abstract string GetStatus();
    public abstract string GetSaveString();

    public static Goal LoadFromString(string data)
    {
        var parts = data.Split("|");
        string type = parts[0];

        return type switch
        {
            "SimpleGoal" => new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4])),
            "EternalGoal" => new EternalGoal(parts[1], parts[2], int.Parse(parts[3])),
            "ChecklistGoal" => new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6])),
            _ => throw new Exception("Unknown goal type.")
        };
    }
}