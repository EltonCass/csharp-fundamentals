// Copyright (c) 2023 Elton Cassas. All rights reserved.
// See LICENSE.txt

namespace Fundamentals.Lesson8;

public abstract class Customer
{
    public string Name { get; protected set; }

    //public static Customer Null => new NullCustomer1();

    public Customer(string name)
    {
        Name = name;
    }

    public abstract void PlaceOrder();


    //public class NullCustomer1 : Customer
    //{
    //    public NullCustomer1() : base("Unknown Customer")
    //    {
    //    }

    //    public override void PlaceOrder()
    //    {
    //        // Null implementation, no order placement
    //        Console.WriteLine("Cannot place order for unknown customer.");
    //    }
    //}
}
