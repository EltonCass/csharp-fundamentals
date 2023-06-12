// Copyright (c) 2023 Elton Cassas. All rights reserved.
// See LICENSE.txt

namespace Fundamentals.Lesson6;

public class Dog : Animal
{ 
    protected private override void MakeSound(string a)
        => Console.Write(a);

    public void UpdateAge(int age)
        => Grow(age);

    //protected bool IsEating => base.IsEating;
}
