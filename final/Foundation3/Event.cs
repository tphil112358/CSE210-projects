using System;
class Event
{
    private string type;
    private string title;
    private string description;
    private DateTime date;
    private string time;
    private Address address;

    public Event(string type, string title, string description, DateTime date, string time, Address address)
    {
        this.type = type;
        this.title = title;
        this.description = description;
        this.date = date;
        this.time = time;
        this.address = address;
    }

    public string StandardDetails()
    {
        return $"Title: {title}\nDescription: {description}\nDate: {date.ToShortDateString()}\nTime: {time}\nAddress:\n{address}";
    }

    public virtual string FullDetails() // I don't think we were supposed to use Polymorphism, but it was just the easiest way to fulfill the requirement. To be honest, I don't know why Polymorphism isn't simply part of the Inheritance lesson. 
    {
        return StandardDetails();
    }

    public string ShortDescription()
    {
        return $"Type: {type}\nTitle: {title}\nDate: {date.ToShortDateString()}";
    }
}