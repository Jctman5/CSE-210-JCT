public class SimpleGoal : Goal
{
    private bool _isComplete;

    public override bool IsComplete => _isComplete;

    public SimpleGoal(string name, string description, int points, bool isComplete = false)
        : base(name, description, points)
    {
        _isComplete = isComplete;
    }

    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            return Points;
        }
        return 0;
    }

    public override string GetStatus()
    {
        return $"[{(_isComplete ? "X" : " ")}] {Name} ({Description})";
    }

    public override string GetSaveString()
    {
        return $"SimpleGoal|{Name}|{Description}|{Points}|{_isComplete}";
    }
}