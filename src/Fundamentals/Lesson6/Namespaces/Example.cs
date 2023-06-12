// Copyright (c) 2023 Elton Cassas. All rights reserved.
// See LICENSE.txt

using Dumpify;
using System.Reflection;
//using Fundamentals.Helpers;
//using Emp = Fundamentals.Helpers.Employee;

namespace Fundamentals.Lesson6.Namespaces
{
    internal class Example
    {
        //Emp Dwight = new Emp();
        //Employee Dwight = new Employee();
        Fundamentals.Helpers.Employee Dwight = new Helpers.Employee();

        internal void PrintEmployee()
        {
            Console.WriteLine(Dwight);
        }

        internal static void PrintMathContent()
        {
            // Get the assembly containing your types
            Assembly assembly = Assembly.GetExecutingAssembly();

            // Specify the namespace to filter by
            string namespaceToFilter = "Fundamentals.Lesson5";

            // Get all types from the assembly that belong to the specified namespace
            var typesInNamespace = assembly.GetTypes()
                .Where(type => type.Namespace == namespaceToFilter)
                .Select(t => t.Name)
                .ToArray();

            typesInNamespace.Dump();
        }
    }
}
