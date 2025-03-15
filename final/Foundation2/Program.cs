using System;

class Program
{
    static void Main()
    {
        Customer customer1 = new Customer("Ayden Shearer", new Address("123 Elm St", "Springfield", "IL", "USA"));
        Customer customer2 = new Customer("Jane Banana", new Address("456 Maple Ave", "Toronto", "ON", "Canada"));
        
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("PC", "A123", 1200, 1));
        order1.AddProduct(new Product("Mouse", "B456", 25, 2));
        
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Phone", "C789", 800, 1));
        order2.AddProduct(new Product("Charger", "D012", 30, 1));
        
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice()}");
        Console.WriteLine("------------------------------");
        
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice()}");
    }
}
