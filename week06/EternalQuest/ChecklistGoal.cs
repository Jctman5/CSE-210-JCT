public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonus;

    public override bool IsComplete => _currentCount >= _targetCount;

    public ChecklistGoal(string name, string description, int points, int targetCount, int currentCount = 0, int bonus = 0)
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _currentCount = currentCount;
        _bonus = bonus;
    }

    public override int RecordEvent()
    {
        if (_currentCount < _targetCount)
        {
            _currentCount++;
            return _currentCount == _targetCount ? Points + _bonus : Points;
        }
        return 0;
    }

    public override string GetStatus()
    {
        string status = IsComplete ? "X" : " ";
        return $"[{status}] {Name} ({Description}) -- Completed {_currentCount}/{_targetCount} times";
    }

    public override string GetSaveString()
    {
        return $"ChecklistGoal|{Name}|{Description}|{Points}|{_targetCount}|{_currentCount}|{_bonus}";
    }
}