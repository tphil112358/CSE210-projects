// Scenario
// You have been hired by an event planning company. They help organize and market events throughout the world. They need you to write a program to track each of 
// these events and produce the marketing material to distribute on social media. They typically handle a few main types of events:

// Lectures, which have a speaker and have a limited capacity.
// Receptions, which require people to RSVP, or register, beforehand.
// Outdoor gatherings, which do not have a limit on attendees, but need to track the weather forecast.

// They would like the ability to generate three different messages:
// Standard details - Lists the title, description, date, time, and address.
// Full details - Lists all of the above, plus type of event and information specific to that event type. For lectures, this includes the speaker name and capacity. 
// For receptions this includes an email for RSVP. For outdoor gatherings, this includes a statement of the weather.
// Short description - Lists the type of event, title, and the date.

// Program Specification
// Write a program that has a base Event class along with derived classes for each type of event. These classes should contain the necessary data and provide methods 
// to return strings for each of the messages the company desires.
// Remember that any data or methods that are common among all types of events should be in the base class.
// Once you have the classes in place, write a program that creates at least one event of each type and sets all of their values. Then, for event event, call each of 
// the methods to generate the marketing messages and output their results to the screen.

// In addition, your program must:
// Use inheritance to avoid duplicating shared attributes and methods.
// Use an address class for the addresses.
// Follow the principles of encapsulation, making sure each member variable is private.
// using System;

using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Event 1:");
        Address address1 = new Address("615 S 1 W", "Rexburg", "ID", "USA");
        Event event1 = new Lecture("Lecture","Cyber Tools Innovations", "Discuss the newest tools and innovations within the cyber protection industry.", new DateTime(2024, 4, 10), "10 AM - 12 PM", address1, "Tyler Phillips", 50);
        Console.WriteLine($"{event1.StandardDetails()}\n");
        Console.WriteLine($"{event1.FullDetails()}\n");
        Console.WriteLine($"{event1.ShortDescription()}\n");

        Console.WriteLine("\nEvent 2:");
        Address address2 = new Address("760 East Dorchester Dr", "Jacksonville", "FL", "USA");
        Event event2 = new Reception("Reception","Tyler & Samantha", "Come see the creation of the Phillips this weekend! Ring reception and cake at our home afterwards.", new DateTime(2024, 8, 2), "5 - 11 PM", address2, "rsvp@gmail.com");
        Console.WriteLine($"{event2.StandardDetails()}\n");
        Console.WriteLine($"{event2.FullDetails()}\n");
        Console.WriteLine($"{event2.ShortDescription()}\n");

        Console.WriteLine("\nEvent 3:");
        Address address3 = new Address("5 Caribou Way", "Moose", "AB", "Canada");
        Event event3 = new OutdoorGathering("Outdoor Gathering","Caribou Wrangling", "Come wrangle yourself a steer at Alberta's Semiannual Caribou Wrangling! This year special event- Get in the ring and wrestle Toonu the Bear!", new DateTime(2024, 7, 5), "8 AM - 5 PM", address3, "Mild to Severe Blizzard");
        Console.WriteLine($"{event3.StandardDetails()}\n");
        Console.WriteLine($"{event3.FullDetails()}\n");
        Console.WriteLine($"{event3.ShortDescription()}\n");
    }
}