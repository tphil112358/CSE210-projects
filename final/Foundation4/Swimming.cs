using System;
class Swimming : Activity
{
    private double laps;
    private int durationInMinutes;
    public Swimming(string type, DateTime date, int durationInMinutes, double laps) : base(type, date, durationInMinutes)
    {
        this.laps = laps;
        this.durationInMinutes = durationInMinutes;
    }
    public override double GetDistance()
    {
        return laps * 50 * 3.281 / 5280;
    }
    public override double GetSpeed()
    {
        return Math.Round(GetDistance() / (durationInMinutes * 60), 10);
    }
}