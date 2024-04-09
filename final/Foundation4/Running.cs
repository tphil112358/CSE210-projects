using System;
class Running : Activity
{
    private double distance;
    private int durationInMinutes;
    public Running(string type, DateTime date, int durationInMinutes, double distance) : base(type, date, durationInMinutes)
    {
        this.distance = distance;
        this.durationInMinutes = durationInMinutes;
    }
    public override double GetDistance()
    {
        return distance;
    }
    public override double GetSpeed()
    {
        return Math.Round(distance / durationInMinutes * 60, 2);
    }
}