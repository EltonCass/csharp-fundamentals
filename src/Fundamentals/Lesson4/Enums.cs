// Copyright (c) 2023  Elton Cassas. All rights reserved.
// See LICENSE.txt

namespace Fundamentals.Lesson4
{
    internal class Enums
    {
        public static void UsingEnums()
        {
            var campus = LocationTypes.Campus;

            var locationNo = (int)LocationTypes.Building;

            var definedOptionA =Enum.IsDefined(typeof(LocationTypes), 4);
            var definedOptionB = Enum.IsDefined(typeof(LocationTypes), 0);
            var definedOptionC = Enum.IsDefined(typeof(LocationTypes), "Campus");
        }
    }

    enum LocationTypes
    {
        Campus = 0,
        Building = 3,
        Floor = 2,
        Room = 1,
    }
}
