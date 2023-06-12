// Copyright (c) 2023 Elton Cassas. All rights reserved.
// See LICENSE.txt

namespace Fundamentals.Lesson6
{
    public class Animal
    {
        private bool IsEating => false;
        internal int Age { get; private set; }

        protected private virtual void MakeSound(string sound) =>
            Console.Write(sound);

        protected private void Grow(int age)
        {
            Console.Write($"New Age: {age}");
            Age = age;
        }
    }
}
    