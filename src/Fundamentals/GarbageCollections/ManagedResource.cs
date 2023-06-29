// Copyright (c) 2023 Elton Cassas. All rights reserved.
// See LICENSE.txt

namespace Fundamentals.GarbageCollections
{
    public class ManagedResource
    {
        private string Data { get; set; }

        private ManagedResource(string data)
        {
            Data = data;
        }

        public static void CreatedMultiple(int iterations = 5000)
        {
            for (int i = 0; i < iterations; i++)
            {
                ManagedResource resource = new ManagedResource($"Resource {i}");
            }
        }
    }
}
