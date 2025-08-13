public class EternalGoal : Goal
{
    public override bool IsComplete => false;

    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
    }

    public override int RecordEvent()
    {
        return Points;
    }

    public override string GetStatus()
    {
        return $"[∞] {Name} ({Description})";
    }

    public override string GetSaveString()
    {
        return $"EternalGoal|{Name}|{Description}|{Points}";
    }
}