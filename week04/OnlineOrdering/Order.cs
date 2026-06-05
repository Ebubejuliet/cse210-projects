using System;
using System.Runtime.InteropServices.Marshalling;
public class Order
{
    private List<Product> _product;
    private Customer _customer;
    public Order(Customer customer)
    {
        _customer = customer;
    }
    public void AddProduct(Product product)
    {
        _product.Add(product);
    }
    public double GetTotalCost()
    {
        double totalCost = 0;
        foreach (Product product in _product)
        {
            totalCost += product.GetTotalCost();
        }
        if (_customer.LivesInUSA())
        {
            totalCost += 5;
        }
        else
        {
            totalCost += 35;
        }
        return totalCost;
    }
}