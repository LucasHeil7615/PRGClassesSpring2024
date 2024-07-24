using System;

namespace OrderSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Address address1 = new Address("123 Main St", "Springfield", "IL", "USA");
            Address address2 = new Address("456 Elm St", "Toronto", "ON", "Canada");

            Customer customer1 = new Customer("John Doe", address1);
            Customer customer2 = new Customer("Jane Smith", address2);

            Product product1 = new Product("Widget", "W123", 10.00m, 2);
            Product product2 = new Product("Gadget", "G456", 15.00m, 1);
            Product product3 = new Product("Thingamajig", "T789", 5.00m, 5);

            Order order1 = new Order(customer1);
            order1.AddProduct(product1);
            order1.AddProduct(product2);

            Order order2 = new Order(customer2);
            order2.AddProduct(product1);
            order2.AddProduct(product3);

            Console.WriteLine("Order 1 Packing Label:");
            Console.WriteLine(order1.PackingLabel());
            Console.WriteLine("Order 1 Shipping Label:");
            Console.WriteLine(order1.ShippingLabel());
            Console.WriteLine($"Order 1 Total Cost: ${order1.TotalCost()}");

            Console.WriteLine();

            Console.WriteLine("Order 2 Packing Label:");
            Console.WriteLine(order2.PackingLabel());
            Console.WriteLine("Order 2 Shipping Label:");
            Console.WriteLine(order2.ShippingLabel());
            Console.WriteLine($"Order 2 Total Cost: ${order2.TotalCost()}");
        }
    }
}
