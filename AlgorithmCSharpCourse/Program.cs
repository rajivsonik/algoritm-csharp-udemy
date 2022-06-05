using System;
using System.Diagnostics;
using System.Linq;
using AlgorithmDataStructLib;

namespace AlgorithmCSharpCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            var ints = ReadFile.ReadInts(@"data\1Kints.txt").ToArray();
            var watch = new Stopwatch();
            watch.Start();

            var tripletsFound = ThreeSum.CountTriplet(ints);
            watch.Stop();

            Console.WriteLine("Number of \"Zero Sum\" Triplets: " + tripletsFound);
            Console.WriteLine($"Time Taken:{ watch.Elapsed:g}");
        }
    }
}
