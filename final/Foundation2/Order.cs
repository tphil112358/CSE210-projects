using System;
class Order
{
    private Customer customer;
    private List<Product> products;

    public Order(List<Product> products, Customer customer)
    {
        this.products = products;
        this.customer = customer;
    }

    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        label += $"Customer: {customer.GetName()}\n";
        foreach (Product p in products)
        {
            label += $"Product: {p.GetQuantity()} -- {p.GetID()} -- {p.GetName()}\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        string label = "Shipping Label:\n" + $"{customer.GetName()}\n" + customer.GetAddress().GetAddress();
        return label;
    }

    public double GetTotalPrice()
    {
        double totalPrice = 0;
        foreach (Product p in products)
        {
            totalPrice += p.GetCost();
        }
        if (customer.HasFreedom() == false) 
        {
            totalPrice += 30;
        }
        totalPrice += 5;
        return totalPrice;
    }
}




