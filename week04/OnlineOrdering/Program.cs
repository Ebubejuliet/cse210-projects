using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Anytown", "CA", "USA");
        Customer customer1 = new Customer("John Doe", address1);
        Console.WriteLine($"Customer: {customer1.GetName()}");
        Console.WriteLine($"Address: {customer1.GetAddress()}");
        Console.WriteLine($"Lives in USA: {customer1.LivesInUSA()}");

        Address address2 = new Address("456 Elm St", "Othertown", "ON", "Canada");
        Customer customer2 = new Customer("Jane Smith", address2);
        Console.WriteLine($"Customer: {customer2.GetName()}");
        Console.WriteLine($"Address: {customer2.GetAddress()}");
        Console.WriteLine($"Lives in USA: {customer2.LivesInUSA()}");
    }
}