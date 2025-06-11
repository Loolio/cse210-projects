using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

        // Create addresses. 
        Address addr1 = new Address("508 Nawoitorong", "New York", "NY", "USA");
        Address addr2 = new Address("456 Maple Ave", "Toronto", "ON", "Canada");

        // Create customers
        Customer cust1 = new Customer("Peter Loolio", addr1);
        Customer cust2 = new Customer("Waldyr Junior", addr2);

        // Create products
        Product prod1 = new Product("Laptop", "LPT123", 999.99m, 1);
        Product prod2 = new Product("Mouse", "MSE456", 25.50m, 1);
        Product prod3 = new Product("Keyboard", "KBD789", 45.00m, 1);
        Product prod4 = new Product("Mouse Pad", "MPK101", 10.20m, 1);

        // Create orders
        Order order1 = new Order(cust1);
        order1.AddProduct(prod1);
        order1.AddProduct(prod2);

        Order order2 = new Order(cust2);
        order2.AddProduct(prod2);
        order2.AddProduct(prod3);

        // Display order details
        DisplayOrder(order1);
        DisplayOrder(order2);
    }

    static void DisplayOrder(Order order)
    {
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order.GetTotalCost() :0.00}\n");
        Console.WriteLine(new string('-', 40));

    }
}