using System;
using System.Collections.Generic;
using System.Text;

public class Customer
{
    private string _name;
    private Address _address;

    // Constructor
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    // Getters y Setters
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public Address Address
    {
        get { return _address; }
        set { _address = value; }
    }

   
    public bool LivesInUSA()
    {
        return _address.IsInUSA();
    }
}