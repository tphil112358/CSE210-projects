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
    public string GetAddress()
    {
        return $"{street}\n{city}\n{state}, {country}";
    }
    public bool HasFreedom()
    {
        bool _hasFreedom = false;
        if (country == "USA") 
        {
            _hasFreedom = true;
        }
        return _hasFreedom;
    }
}
