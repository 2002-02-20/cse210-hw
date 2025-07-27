using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== SYSTEMS OF ORDERS ===\n");

    
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Address address2 = new Address("456 Elm Ave", "Toronto", "ON", "Canada");

      
        Customer customer1 = new Customer("Juan Pérez", address1);
        Customer customer2 = new Customer("María García", address2);


        Product product1 = new Product("Laptop", "LAP001", 999.99, 1);
        Product product2 = new Product("Mouse", "MOU001", 25.50, 2);
        Product product3 = new Product("Teclado", "TEC001", 75.00, 1);

        
        Product product4 = new Product("Monitor", "MON001", 299.99, 2);
        Product product5 = new Product("Webcam", "WEB001", 89.99, 1);

        
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        
        Order order2 = new Order(customer2);
        order2.AddProduct(product4);
        order2.AddProduct(product5);

        
        Console.WriteLine("ORDER 1:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Prices: ${order1.CalculateTotalCost():F2}");
        Console.WriteLine(new string('-', 50));

        // Mostrar información del segundo pedido
        Console.WriteLine("\nORDER 2:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.CalculateTotalCost():F2}");

        Console.WriteLine("\nPress any key to exit");
        Console.ReadKey();
    }
}