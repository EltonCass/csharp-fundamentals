// Copyright (c) 2023 Elton Cassas. All rights reserved.
// See LICENSE.txt

namespace Fundamentals.Lesson8;

public class VIPCustomer : Customer
{
    public VIPCustomer(string name) : base(name)
    {
    }

    public override void PlaceOrder()
    {
        Console.WriteLine($"Placing order for VIP customer: {Name}");
        // Additional order placement logic
    }
}