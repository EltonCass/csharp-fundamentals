// Copyright (c) 2023 Elton Cassas. All rights reserved.
// See LICENSE.txt

namespace Fundamentals.Lesson7
{
    public class PathNotFoundException : DirectoryNotFoundException
    {
        public PathNotFoundException() : base("Given Path was not found.")
        {
        }

        public PathNotFoundException(string message) : base(message)
        {
        }

        public PathNotFoundException(string message, Exception? innerException)
            : base(message, innerException) { }
    }
}
