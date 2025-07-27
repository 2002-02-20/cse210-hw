using System;
using System.Collections.Generic;
using System.Text;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    // Constructor
    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    // Getters
    public Customer Customer
    {
        get { return _customer; }
        set { _customer = value; }
    }

    public List<Product> Products
    {
        get { return _products; }
    }

  
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

  
    public double CalculateTotalCost()
    {
        double productsCost = 0;
        
        foreach (Product product in _products)
        {
            productsCost += product.GetTotalCost();
        }

        double shippingCost = _customer.LivesInUSA() ? 5.0 : 35.0;
        return productsCost + shippingCost;
    }

    
    public string GetPackingLabel()
    {
        StringBuilder label = new StringBuilder();
        label.AppendLine("=== PACKING LABEL ===");
        
        foreach (Product product in _products)
        {
            label.AppendLine($"Name: {product.Name}, ID: {product.ProductId}");
        }
        
        return label.ToString();
    }

    
    public string GetShippingLabel()
    {
        StringBuilder label = new StringBuilder();
        label.AppendLine("=== SHIPPING LABEL ===");
        label.AppendLine($"Client: {_customer.Name}");
        label.AppendLine("Direction:");
        label.AppendLine(_customer.Address.GetFullAddress());
        
        return label.ToString();
    }
}