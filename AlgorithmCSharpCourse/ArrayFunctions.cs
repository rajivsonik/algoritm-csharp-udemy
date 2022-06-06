using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmCSharpCourse
{
    public class ArrayFunctions
    {
        public static void ArrayDemo()
        {
            int[] array1 = new int[5] {1,3,-2,5,1};
            int[] array2 = { 1, 2, 3, 4, 5 };

            // use for loop for array
            for (int i = 0; i < array1.Length; i++)
            {
                Console.Write(array1[i] + ", ");
            }
            Console.WriteLine();
           
            // use foreach for array
            foreach (var thisElement in array2)
            {
                    Console.Write(thisElement);
            }
            Console.WriteLine();
        }

        public static void ArrayWithStartIndex1()
        {
            Array myArray = Array.CreateInstance(typeof(int), new[] { 4 }, new[] { 1 });

            myArray.SetValue(2019,1);
            myArray.SetValue(2020, 2);
            myArray.SetValue(2021, 3);
            myArray.SetValue(2022, 4);

            Console.WriteLine($"Start index: {myArray.GetLowerBound(0)}");
            Console.WriteLine($"End index: {myArray.GetUpperBound(0)}");

            for (int i = myArray.GetLowerBound(0); i <= myArray.GetUpperBound(0); i++)
            {
                Console.WriteLine($"{myArray.GetValue(i)} at index {i} ");
            }

        }

        public static void MultiDimArray()
        {
            int[,] my2DArray1 = new int[2,3] { { 3,5,7 }, { 2,6,8 } };
            int[,] my2DArray2 = { { 1, 2, 3 }, { 4, 5, 6 } };

            Console.WriteLine($"Total Elements in my2DArray1: {my2DArray1.Length}");

            for (int i = 0; i < my2DArray1.GetLength(0); i++)
            {
                for (int j = 0; j < my2DArray1.GetLength(1); j++)
                {
                    Console.Write(my2DArray1[i,j]);
                }
                Console.WriteLine();
            }
        }

        public static void JaggedArray()
        {
            int[][] jaggedArray1 = new int[4][];
            jaggedArray1[0] = new int[1];
            jaggedArray1[1] = new int[3];
            jaggedArray1[2] = new int[2];
            jaggedArray1[3] = new int[4];
            
            //int[][] jaggedArray2 = new int[][]
            //{
            //    new int[] { 4 },
            //    new int[] { 3, 5, 7 },
            //    new int[] { 89, 23 },
            //    new int[] { 0, 45, 78, 53 }
            //};

            Console.WriteLine($"Jagged Array length is : {jaggedArray1.Length} ");
            // read values for jagged array
            Console.WriteLine("Enter 10 number for Jagged array ");
            for (int i = 0; i < jaggedArray1.Length; i++)
            {
                for (int j = 0; j < jaggedArray1[i].Length; j++)
                {
                    string inputValue = Console.ReadLine();
                    jaggedArray1[i][j] = int.Parse(inputValue);
                }
            }
            Console.WriteLine("User input Values ");
            for (int i = 0; i < jaggedArray1.Length; i++)
            {
                for (int j = 0; j < jaggedArray1[i].Length; j++)
                {
                    Console.Write(jaggedArray1[i][j]);
                    Console.Write("\0");

                }
                Console.WriteLine("");
            }

        }
    }
}
