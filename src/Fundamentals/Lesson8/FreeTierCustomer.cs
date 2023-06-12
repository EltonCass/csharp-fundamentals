// Copyright (c) 2023 Elton Cassas. All rights reserved.
// See LICENSE.txt

namespace Fundamentals.Lesson8;

public class FreeTierCustomer : Customer
{
    public FreeTierCustomer(string name) : base(name)
    {
    }

    public override void PlaceOrder()
    {
        Console.WriteLine($"Placing order for customer: {Name}. This may take a few minutes");
    }
}
