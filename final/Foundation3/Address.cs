using System;
class Address
{
    private string street;
    private string city;
    private string state;
    private string country;

    public Address(string street, string city, string state, string country)
    {
        this.street = street;
        this.city = city;
        this.state = state;
        this.country = country;
    }
    public override string ToString()
    {
        return $"{street}\n{city}\n{state}, {country}";
    }
    public bool HasFreedom() // Leftover code from Foundation 2, but I'll leave it; for fun :D
    {
        bool _hasFreedom = false;
        if (country == "USA") 
        {
            _hasFreedom = true;
        }
        return _hasFreedom;
    }
}
