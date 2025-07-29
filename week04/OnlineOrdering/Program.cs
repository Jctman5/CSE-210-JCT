using System;

namespace OrderProcessing
{
    class Program
    {
        static void Main(string[] args)
        {
            // Customer 1 (USA)
            Address address1 = new Address("323 String St", "New York", "NY", "USA");
            Customer customer1 = new Customer("John Doe", address1);
            Order order1 = new Order(customer1);
            order1.AddProduct(new Product("Klon pedal", "KL20", 500.50m, 1));
            order1.AddProduct(new Product("Patch Cable", "PC10", 15.00m, 2));

            // Customer 2 (International)
            Address address2 = new Address("225 Paris st", "Paris", "Île-de-France", "France");
            Customer customer2 = new Customer("Jane Dupont", address2);
            Order order2 = new Order(customer2);
            order2.AddProduct(new Product("Gibson Les Paul", "GLP1", 2000.00m, 1));
            order2.AddProduct(new Product("Guitar Cable 20 ft", "GC20", 45.00m, 1));
            order2.AddProduct(new Product("Guitar Stand", "GTS1", 25.00m, 2));

            // Display Order 1
            Console.WriteLine(order1.GetPackingLabel());
            Console.WriteLine(order1.GetShippingLabel());
            Console.WriteLine($"Total Price: ${order1.GetTotalCost():0.00}\n");

            // Display Order 2
            Console.WriteLine(order2.GetPackingLabel());
            Console.WriteLine(order2.GetShippingLabel());
            Console.WriteLine($"Total Price: ${order2.GetTotalCost():0.00}\n");
        }
    }
}