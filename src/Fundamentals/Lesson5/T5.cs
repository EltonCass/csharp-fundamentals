// Copyright (c) 2023 Elton Cassas. All rights reserved.
// See LICENSE.txt

namespace Fundamentals.Lesson5
{
    internal static class T5
    {
        public static dynamic GenericAddDynamic(dynamic t1, dynamic t2)
        {
            var result = t1 + t2;
            return result;
        }

        public static T GenericAdd<T>(T t1, T t2)
        {
            var result = (dynamic)t1 + t2;
            return (T)result;
        }
    }
}
