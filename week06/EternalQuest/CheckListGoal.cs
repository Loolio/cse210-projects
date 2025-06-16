public class ChecklistGoal : Goal
{
    public int TargetCount { get; set; }
    public int CurrentCount { get; set; }
    public int BonusPoints { get; set; }

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints)
        : base(name, description, points)
    {
        TargetCount = targetCount;
        CurrentCount = 0;
        BonusPoints = bonusPoints;
    }

    public override void RecordEvent()
    {
        CurrentCount++;
        // Bonus points logic can be handled in GoalManager if needed
    }

    public override string GetDetailsString()
    {
        return $"{_name} ({_description}) -- Completed {CurrentCount}/{TargetCount}";
    }

    public override bool IsComplete()
    {
        return CurrentCount >= TargetCount;
    }

    public override string GetStringRepresentation()
    {
        return $"Checklist:{_name},{_description},{_points},{TargetCount},{CurrentCount},{BonusPoints}";
    }
}
