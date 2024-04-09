using System;
class Lecture : Event
{
    private string keynote;
    private int capacity;

    public Lecture(string type, string title, string description, DateTime date, string time, Address address, string keynote, int capacity) : base(type, title, description, date, time, address)
    {
        this.keynote = keynote;
        this.capacity = capacity;
    }

    public override string FullDetails() // I don't think we were supposed to use Polymorphism, but it was just the easiest way to fulfill the requirement. To be honest, I don't know why Polymorphism isn't simply part of the Inheritance lesson. 
    {
        return $"{StandardDetails()}\nType: Lecture\nSpeaker: {keynote}\nCapacity: {capacity}";
    }
}