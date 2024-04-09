using System.Runtime.CompilerServices;

class SimpleGoal : Goal {
    private int _numberOfCompletions;
    _numberOfCompletions = 1;
    public override bool IsGoalComplete() {
        if (_numberOfCompletions > 0) {
            return true;
        }
    }
}