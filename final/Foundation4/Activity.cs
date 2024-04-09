using System;
class Activity
{
    private string type;
    private DateTime date;
    private int durationInMinutes;
    public Activity(string type, DateTime date, int durationInMinutes)
    {
        this.type = type;
        this.date = date;
        this.durationInMinutes = durationInMinutes;
    }
    public virtual double GetDistance()
    {
        return 0;
    }
    public virtual double GetSpeed()
    {
        return 0;
    }
    public double GetPace()
    {
        return 60 / GetSpeed();
    }
    public string GetSummary()
    {
        return $"{date.ToShortDateString()} {type} ({durationInMinutes} min) - Distance: {Math.Round(GetDistance(), 2)} miles, Speed: {GetSpeed()} mph, Pace: {Math.Round(GetPace(), 2)} min per mile";
    }
}