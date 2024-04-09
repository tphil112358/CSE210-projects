using System;
class OutdoorGathering : Event
{
    private string weather;

    public OutdoorGathering(string type, string title, string description, DateTime date, string time, Address address, string weather) : base(type, title, description, date, time, address)
    {
        this.weather = weather;
    }

    public override string FullDetails() // I don't think we were supposed to use Polymorphism, but it was just the easiest way to fulfill the requirement. To be honest, I don't know why Polymorphism isn't simply part of the Inheritance lesson. 
    {
        return $"{StandardDetails()}\nType: Outdoor Gathering\nWeather Forecast: {weather}";
    }
}