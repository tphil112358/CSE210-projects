// Breathing Activity
// The activity should begin with the standard starting message and prompt for the duration that is used by all activities.
// The description of this activity should be something like: "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing."
// After the starting message, the user is shown a series of messages alternating between "Breathe in..." and "Breathe out..."
// After each message, the program should pause for several seconds and show a countdown.
// It should continue until it has reached the number of seconds the user specified for the duration.
// The activity should conclude with the standard finishing message for all activities.
using System.Security.Cryptography.X509Certificates;

class Breathe : Program {
    public void RunBreathe() {
        SetExerciseName("breathing");
        SetExerciseDescription("You will breathe in for 3 seconds, hold it for 2, breathe out for 3, hold it for 2 again, and repeat.");
        SetExerciseDuration(30);
        BeginExercise(GetExerciseName(),GetExerciseDescription(),GetExerciseDuration());
        int _userInput = GetExerciseDuration();
        BeginExercise("breathing","You will breathe in for 3 seconds, hold it for 2, breathe out for 3, hold it for 2 again, and repeat.",10);
        int _finisher;
        if (_userInput < 10) {
            _finisher = 10;
        }
        else {
            _finisher = _userInput;
        }
        while (_userInput > 0) {
            LoadingBar("Breathe in",3);
            LoadingBar("Now hold your breath",2);
            LoadingBar("Now breathe out",3);
            LoadingBar("Now hold your breath.",2);
            _userInput -= 10;
        }
        EndExercise(_finisher,"breathing");
    }
}