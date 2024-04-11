class CheckListGoal : Goal {
    private int pointsPerCompletion;
    private int requiredCompletions;
    private int completions;

    public CheckListGoal(string name, string description) : base(name, description) {
        pointsPerCompletion = 50;
        requiredCompletions = 10;
        completions = 0;
    }

    public override int GetPoints() {
        if (completions >= requiredCompletions) {
            return requiredCompletions * pointsPerCompletion + 500; // Bonus points
        }
        else {
            return completions * pointsPerCompletion;
        }
    }

    public override string GetProgress() {
        return $"Checklist goal. Completed {completions}/{requiredCompletions} times.";
    }
}