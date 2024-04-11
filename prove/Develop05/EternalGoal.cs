class EternalGoal : Goal {
    private int points;

    public EternalGoal(string name, string description) : base(name, description) {
        points = 100; // Arbitrary points for simplicity
    }

    public override int GetPoints() {
        return points;
    }

    public override string GetProgress() {
        return "Eternal goal. Can be repeatedly recorded for points.";
    }
}