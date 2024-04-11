abstract class Goal {
    private string goalName;
    private string goalDescription;
    private bool goalComplete;

    public Goal(string name, string description) {
        goalName = name;
        goalDescription = description;
        goalComplete = false;
    }

    public string GetGoalName() {
        return goalName;
    }

    public string GetGoalDescription() {
        return goalDescription;
    }

    public void SetGoalComplete(bool value) {
        goalComplete = value;
    }

    public bool IsGoalComplete() {
        return goalComplete;
    }

    public abstract int GetPoints();
    public abstract string GetProgress();
}