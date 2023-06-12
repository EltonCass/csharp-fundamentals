// Copyright (c) 2023 Elton Cassas. All rights reserved.
// See LICENSE.txt

namespace Fundamentals.Lesson8;

internal static class NullableObject
{
    public static void GetCustomers()
    {
        // Thinking that customers go from VIP to Free Tier to Non existing
        Customer vipCustomer = GetCustomer(1);
        Customer freeTierCustomer = GetCustomer(1000);
        Customer nullCostumer = GetCustomer(100000);

        vipCustomer.PlaceOrder();
        freeTierCustomer.PlaceOrder();
        nullCostumer.PlaceOrder();
    }

    static Customer GetCustomer(int customerId)
    {
        // Retrieve customer from database or other source
        // If customer does not exist, return NullCustomer
        // Otherwise, return actual Customer object

        if (customerId < 100)
        {
            return new VIPCustomer("John Doe");
        }
        else if (customerId < 10000)
        {
            return new FreeTierCustomer("Jane Smith");
        }
        else
        {
            return new NullCustomer();                                                                                                                               er();
        }
    }
}