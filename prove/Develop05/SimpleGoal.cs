class SimpleGoal : Goal {
    private int points;

    public SimpleGoal(string name, string description) : base(name, description) {
        points = 0;
    }

    public override int GetPoints() {
        return points;
    }

    public override string GetProgress() {
        return "Simple goal. Marked complete for points.";
    }
}