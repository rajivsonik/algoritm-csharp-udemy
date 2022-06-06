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
             ArrayFunctions.JaggedArray();
            // ArrayFunctions.MultiDimArray();
            // ArrayFunctions.ArrayWithStartIndex1();
            // ArrayFunctions.ArrayDemo();
            // CheckTriplets();
        }

        private static void CheckTriplets()
        {

            // check 1k records
            var ints = ReadFile.ReadInts(@"data\1Kints.txt").ToArray();
            var watch = new Stopwatch();
            watch.Start();

            var tripletsFound = ThreeSum.CountTriplet(ints);
            watch.Stop();

            Console.WriteLine("Number of \"Zero Sum\" Triplets in 1k records: " + tripletsFound);
            Console.WriteLine($"Time Taken in 1k records:{ watch.Elapsed:g}");


            // check 4k records 
            ints = ReadFile.ReadInts(@"data\4Kints.txt").ToArray();
            watch = new Stopwatch();
            watch.Start();

            tripletsFound = ThreeSum.CountTriplet(ints);
            watch.Stop();

            Console.WriteLine("Number of \"Zero Sum\" Triplets in 4k records: " + tripletsFound);
            Console.WriteLine($"Time Taken in 4k records:{ watch.Elapsed:g}");
        }
    }
}
