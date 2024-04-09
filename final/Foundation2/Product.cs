using System;
class Product
{
    private string name;
    private int iD;
    private double pricePerUnit;
    private int quantity;

    public Product(string name, int iD, double pricePerUnit, int quantity)
    {
        this.name = name;
        this.iD = iD;
        this.pricePerUnit = pricePerUnit;
        this.quantity = quantity;
    }

    public double GetCost()
    {
        return pricePerUnit * quantity;
    }

    public string GetName()
    {
        return name;
    }

    public int GetID()
    {
        return iD;
    }
    public int GetQuantity()
    {
        return quantity;
    }
}
