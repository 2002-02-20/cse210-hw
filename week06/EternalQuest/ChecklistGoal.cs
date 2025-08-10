using System;

class ChecklistGoal : Goal
{
    private int _timesCompleted;
    private int _targetCount;
    private int _bonusPoints;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints, int timesCompleted = 0)
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _bonusPoints = bonusPoints;
        _timesCompleted = timesCompleted;
    }

    public override int RecordEvent()
    {
        _timesCompleted++;
        if (_timesCompleted >= _targetCount)
        {
            return Points + _bonusPoints;
        }
        return Points;
    }

    public override bool IsComplete() => _timesCompleted >= _targetCount;

    public override string GetDetailsString()
    {
        return $"{base.GetDetailsString()} -- Completed {_timesCompleted}/{_targetCount}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{Name}|{Description}|{Points}|{_targetCount}|{_bonusPoints}|{_timesCompleted}";
    }
}