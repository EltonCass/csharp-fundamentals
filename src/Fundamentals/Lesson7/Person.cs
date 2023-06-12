// Copyright (c) 2023  Elton Cassas. All rights reserved.
// See LICENSE.txt

using System.Runtime.Serialization;

namespace Fundamentals.Lesson7;

[DataContract]
internal class Person
{
    [DataMember]
    public string? Name { get; set; }
    [DataMember]
    public int Age { get; set; }

    public Person() : this(0, string.Empty)
    {
    }

    public Person(int age, string? name)
    {
        Age = age;
        ArgumentNullException.ThrowIfNull(name, "name");
        Name = name;
    }
}