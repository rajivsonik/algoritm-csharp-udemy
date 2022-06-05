using System;

namespace AlgorithmDataStructLib
{
    public class ThreeSum
    {

        public static int CountTriplet(int[] inputArray)
        {
            int inputArrayLength = inputArray.Length;
            int tripletCount = 0;

            for (int i = 0; i < inputArrayLength; i++)
            {
                for (int j = i+1; j < inputArrayLength; j++)
                {
                    for (int k = j+1; k < inputArrayLength; k++)
                    {
                        if (inputArray[i] + inputArray[j] + inputArray[k] ==0)
                        {
                            tripletCount++;
                        } 
                    }
                }
            }

            return tripletCount;
        }
    }
}
