using System.Diagnostics;

namespace Fundamentals.GarbageCollections
{
    internal static class ManualGCTrigger
    {
        internal static void RunCollection()
        {
            // Start the stopwatch to measure time
            Stopwatch stopwatch = Stopwatch.StartNew();

            GC.Collect(1, GCCollectionMode.Forced);
            GC.WaitForPendingFinalizers();

            // Stop the stopwatch and print the elapsed time
            stopwatch.Stop();
            Console.WriteLine($"Time taken for generation 1 garbage collection: {stopwatch.ElapsedMilliseconds} ms");

            // Check memory usage after garbage collection
            long memoryUsed = GC.GetTotalMemory(false);
            Console.WriteLine($"Memory used after garbage collection: {memoryUsed} bytes");
        }

        internal static void RunGen2Collection()
        {
            // Start the stopwatch to measure time
            Stopwatch stopwatch = Stopwatch.StartNew();

            // Manually run the garbage collector for generation 2 objects
            GC.Collect(2, GCCollectionMode.Forced);
            GC.WaitForPendingFinalizers();

            // Stop the stopwatch and print the elapsed time
            stopwatch.Stop();
            Console.WriteLine($"Time taken for generation 2 garbage collection: {stopwatch.ElapsedMilliseconds} ms");

            // Check memory usage after garbage collection
            long memoryUsed = GC.GetTotalMemory(false);
            Console.WriteLine($"Memory used after garbage collection: {memoryUsed} bytes");
        }
    }
}
