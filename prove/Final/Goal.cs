using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices.Marshalling;

abstract class Goal {
    private int points;
    private string goalName;
    private string goalDescription;
    private int goalComplete;
    public int GetPoints() {
        return points;
    }
    public void SetPoints(int value) {
        points = value;
    }
    public string GetGoalName() {
        return goalName;
    }
    public void SetGoalName(string value) {
        goalName = value;
    }
    public string GetGoalDescription() {
        return goalDescription;
    }
    public void SetGoalDescription(string value) {
        goalDescription = value;
    }
    public int GetGoalComplete() {
        return goalComplete;
    }
    public void SetGoalComplete(int value) {
        goalComplete = value;
    }
    public abstract bool IsGoalComplete();
}