using System;

namespace OrderingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("======================================");
            Console.WriteLine("   PRODUCT ORDERING SYSTEM DEMO");
            Console.WriteLine("======================================\n");

            Address address1 = new Address(
                "123 Main Street",
                "Seattle",
                "WA",
                "USA"
            );

            Customer customer1 = new Customer("John Smith", address1);

            Order order1 = new Order(customer1);
            order1.AddProduct(new Product("Laptop", "PROD001", 899.99, 1));
            order1.AddProduct(new Product("Wireless Mouse", "PROD002", 24.99, 2));
            order1.AddProduct(new Product("USB-C Cable", "PROD003", 12.50, 3));

            Console.WriteLine("ORDER #1:");
            Console.WriteLine("---------\n");
            Console.WriteLine(order1.GetPackingLabel());
            Console.WriteLine(order1.GetShippingLabel());
            Console.WriteLine($"Total Price: ${order1.CalculateTotalCost():F2}");
            Console.WriteLine("\n");

            Address address2 = new Address(
                "456 Maple Avenue",
                "Toronto",
                "ON",
                "Canada"
            );

            Customer customer2 = new Customer("Sarah Johnson", address2);

            Order order2 = new Order(customer2);
            order2.AddProduct(new Product("Mechanical Keyboard", "PROD004", 149.99, 1));
            order2.AddProduct(new Product("Monitor Stand", "PROD005", 39.99, 1));

            Console.WriteLine("ORDER #2:");
            Console.WriteLine("---------\n");
            Console.WriteLine(order2.GetPackingLabel());
            Console.WriteLine(order2.GetShippingLabel());
            Console.WriteLine($"Total Price: ${order2.CalculateTotalCost():F2}");
            Console.WriteLine("\n");

            Console.WriteLine("======================================");
            Console.WriteLine("   END OF DEMO");
            Console.WriteLine("======================================");
        }
    }
}