using System;
using System.ComponentModel.DataAnnotations;

public class Owner
{
    public string name;
    public string phone;
    public string FavoriteColor;
}
public class Car
{
    public Car(string make, string model, int gallons, int MilesPerGallon, Owner owner)
    {
        this.make = make;
        this.model = model;
        this.gallons = gallons;
        this.MilesPerGallon = MilesPerGallon;
        this.Owner = owner;
    }
    public int MilesPerGallon;
    public int gallons;
    public string make;
    public string model;
    public Owner Owner;
    public int TotalRange()
    {
        return gallons * MilesPerGallon;
    }
    public void Display()
    {
        Console.WriteLine($"{make} {model}: Range= {TotalRange()}");
    }
}
class Program
{
    static void Main(string[] args)
    {
        var cars = new List<Car>();

        var owner = new Owner();
        Owner.name = "Bob";
        Owner.phone = "406-439-2194";

        var car = new Car("Ford", "F-150", 30, 5, owner);
        cars.Add(car);

        Owner = new Owner();
        Owner.name = "Sue";
        Owner.phone = "716-431-0554";
        Car.Owner = Owner;

        Car = new Car("Honda","Civic",10,30, Owner);
        cars.Add(Car);

        foreach (var c in cars)
        {
            c.Display();
        }
    }
}