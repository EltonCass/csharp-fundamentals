// Copyright (c) 2023 Elton Cassas. All rights reserved.
// See LICENSE.txt

namespace Fundamentals.Lesson8;

public class NullCustomer : Customer
{
    public NullCustomer() : base("Unknown Customer")
    {
    }

    public override void PlaceOrder()
    {
        // Null implementation, no order placement
        Console.WriteLine("Cannot place order for unknown customer.");
    }
}