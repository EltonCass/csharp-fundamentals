// Copyright (c)  Elton Cassas. All rights reserved.
// See LICENSE.txt

namespace Fundamentals.Helpers
{
    internal class Employee
    {
        decimal Salary { get; set; } = 4500.99m;

        public override string ToString()
            => $"This employee has a salary of: {Salary:C}";
    }
}
