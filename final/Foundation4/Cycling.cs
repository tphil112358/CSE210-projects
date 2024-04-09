using System;
class Cycling : Activity
{
    private double speed;
    private int durationInMinutes;
    public Cycling(string type, DateTime date, int durationInMinutes, double speed) : base(type, date, durationInMinutes)
    {
        this.speed = speed;
        this.durationInMinutes = durationInMinutes;
    }
    public override double GetDistance() 
    {
        return speed * durationInMinutes / 60;
    }
    public override double GetSpeed()
    {
        return Math.Round(speed, 2);
    }
}