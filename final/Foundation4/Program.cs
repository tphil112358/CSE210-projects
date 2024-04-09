// Scenario
// The local fitness center has hired you to write an app for their customers to track their exercise. They have facilities for the following:
// Running
// Stationary Bicycles
// Swimming in the lap pool

// For each activity, they want to track the the date and the length of the activity in minutes. Then, for each activity, they would like to also track the following:
// Running: distance
// Cycling: speed
// Swimming: number of laps

// For each activity, they do not want to store this information, but they would like to be able to get following information (by calculation if it is not stored 
// directly):
// The distance
// The speed (miles per hour or kilometers per hour)
// The pace (minutes per mile or minutes per kilometer)

// A summary in the form of:
// 03 Nov 2022 Running (30 min)- Distance 3.0 miles, Speed 6.0 mph, Pace: 10.0 min per mile
// 03 Nov 2022 Running (30 min): Distance 4.8 km, Speed: 9.6 kph, Pace: 6.25 min per km
// You may choose if your program uses miles or kilometers (you do not need to handle both). In either case the length of a lap in the lap pool is 50 meters.

// Program Specification
// Write a program that has a base Activity class and then has a derived class for each of the three activities. The base class should contain any attributes that are 
// shared among all activities. Then, each derived class can define any additional attributes.
// In addition, the base class should contain virtual methods for getting the distance, speed, pace. These methods should be overridden in the derived classes.
// Finally, you should provide a GetSummary method to produce a string with all the summary information.
// Remember that the summary method can make use of the other methods to produce its result. This method should be available for all classes, so it should be defined 
// in the base class (you can override it in the derived classes if needed, but it may not need to be...).

// Once you have the classes in place, write a program that creates at least one activity of each type. Put each of these activities in the same list. Then iterate 
// through this list and call the GetSummary method on each item and display the results.

// In addition, your program must:
// Use inheritance to avoid duplicating shared attributes and methods.
// Use method overriding for the calculation methods.
// Follow the principles of encapsulation, making sure each member variable is private.

// Math Hints:
// Distance (km) = swimming laps * 50 / 1000
// Distance (miles) = swimming laps * 50 / 1000 * 0.62
// Speed (mph or kph) = (distance / minutes) * 60
// Pace (min per mile or min per km)= minutes / distance
// Speed = 60 / pace
// Pace = 60 / speed

using System;
class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = 
        [
            new Running("Running", new DateTime(2024, 11, 03), 30, 3.0),
            new Cycling("Cycling", new DateTime(2024, 11, 03), 45, 20.0),
            new Swimming("Swimming", new DateTime(2024, 11, 03), 20, 60.0),
        ]; // Compact, right? First time an IDE plugin suggested something that actually improved my code without making my head hurt

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}