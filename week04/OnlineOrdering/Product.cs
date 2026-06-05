using System;
public class Product
{
    private string _name;
    private string _productId;
    private string _quantity;
    private double _price;
    public Product(string name, string productID, double price, string quantity)
    {
        _name = name;
        _productId = productID;
        _price = price;
        _quantity = quantity;
    }
    public double GetTotalCost()
    {
        return _price * int.Parse(_quantity);
    }
    public string GetName()
    {
        return _name;
    }
    public string GetProductId()
    {
        return _productId;
    }
}