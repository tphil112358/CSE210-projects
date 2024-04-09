// Scenario
// You have been hired to help a company with their product ordering system. They sell many products online to a variety of customers and need to produce packing 
// labels, shipping labels, and compute final prices for billing.

// Program Specification
// Write a program that has classes for Product, Customer, Address, and Order. The responsibilities of these classes are as follows:

//$ Order
// Contains a list of products and a customer. Can calculate the total cost of the order. Can return a string for the packing label. Can return a string for the 
// shipping label.
// The total price is calculated as the sum of the total cost of each product plus a one-time shipping cost.
// This company is based in the USA. If the customer lives in the USA, then the shipping cost is $5. If the customer does not live in the USA, then the shipping cost 
// is $35.
// A packing label should list the name and product id of each product in the order.
// A shipping label should list the name and address of the customer
//$ Product
// Contains the name, product id, price per unit, and quantity of each product.
// The total cost of this product is computed by multiplying the price per unit and the quantity. If the price per unit was $3 and they bought 5, the product total 
// cost would be $15.
//$ Customer
// The customer contains a name and an address.
// The name is a string, but the Address is a class.
// The customer should have a method that can return whether they live in the USA or not. (Hint this should call a method on the address to find this.)
//$ Address
// The address contains a string for the street address, the city, state/province, and country.
// The address should have a method that can return whether it is in the USA or not.
// The address should have a method to return a string all of its fields together in one string (with newline characters where appropriate)
// Other considerations
// Make sure that all member variables are private and getters, setters, and constructors are created as needed.
// 
// Once you have created these classes, write a program that creates at least two orders with a 2-3 products each. Call the methods to get the packing label, the 
// shipping label, and the total price of the order, and display the results of these methods.

using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("615 S 1 W", "Rexburg", "ID", "USA");
        Customer customer1 = new Customer("Levi Conrad", address1);
        List<Product> products1 = new List<Product> {
            new Product("Lenovo Laptop", 12345, 899.99, 1),
            new Product("GAMING Mouse [Extra GAMER LEDs]", 67890, 19.99, 2)
        };
        Order order1 = new Order(products1, customer1);
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("\nTotal Price: $" + order1.GetTotalPrice());
        Console.WriteLine();

        Address address2 = new Address("760 East Dorchester Dr", "Jacksonville", "FL", "USA");
        Customer customer2 = new Customer("Mrs.Phillips", address2);
        List<Product> products2 = new List<Product> {
            new Product("5.56x10 Carbine Ammunition", 20321, 16.99, 27),
            new Product("M18A1, Anti-Personnel", 09176, 359.99, 4),
            new Product("Surplus USARMY Patriot MDS", 18879, 2380000.00, 1)
        };
        Order order2 = new Order(products2, customer2);
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("\nTotal Price: $" + order2.GetTotalPrice());
        Console.WriteLine();

        Address address3 = new Address("5 Caribou Way", "Moose", "AB", "Canada");
        Customer customer3 = new Customer("Kenneth Bone", address3);
        List<Product> products3 = new List<Product> {
            new Product("Hockey Stick", 00372, 69.99, 2),
            new Product("Maple Syrup", 09221, 9.99, 10),
            new Product("Beaver Pheromones [AUTHENTICALLY and HUMANELY SOURCED]", 13509, 199.99, 1)
        };
        Order order3 = new Order(products3, customer3);
        Console.WriteLine(order3.GetPackingLabel());
        Console.WriteLine(order3.GetShippingLabel());
        Console.WriteLine("\nTotal Price: $" + order3.GetTotalPrice());
        Console.WriteLine();
    }
}