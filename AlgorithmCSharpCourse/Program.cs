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
            TestTranspose();
            // TestReverseInPlace();
            // ArrayFunctions.JaggedArray();
            // ArrayFunctions.MultiDimArray();
            // ArrayFunctions.ArrayWithStartIndex1();
            // ArrayFunctions.ArrayDemo();
            // CheckTriplets();
        }

        private static void TestTranspose()
        {
            int[,] matrix = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            Console.WriteLine("Original Matrix");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(matrix[i,j]);
                }
                Console.WriteLine();
            }

            int[,] transposedMatrix = ArrayFunctions.TransposeMatrix(matrix);
             rows = matrix.GetLength(0);
             columns = matrix.GetLength(1);
            Console.WriteLine("Transposed Matrix");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(transposedMatrix[i, j]);
                }
                Console.WriteLine();
            }



        }

        private static void TestReverseInPlace()
        {
            int[] myArray = new[] { 1, 2, 3, 4, 5, 6, 7 };
            Console.WriteLine("Original Array");
            Array.ForEach(myArray, Console.WriteLine);

            Console.WriteLine("Reversed Array");
            ArrayFunctions.ReverseInPlace(myArray);
            Array.ForEach(myArray, Console.WriteLine);
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
