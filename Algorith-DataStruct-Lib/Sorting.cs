using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;

namespace Algorith_DataStruct_Lib
{
    public class Sorting
    {
        public static void InsertionSort(int[] array)
        {
            for (int partIndex = 1; partIndex < array.Length; partIndex++)
            {
                int i = 0;
                int currentUnsorted = array[partIndex];
                for ( i = partIndex; i > 0 && array[i - 1] > currentUnsorted; i--)
                {
                    array[i] = array[i - 1];
                }

                array[i] = currentUnsorted;
            }
        }
        public static void SelectionSort(int[] array)
        {
            for (int partIndex = array.Length-1; partIndex > 0; partIndex--)
            {
                int largestAt = 0;
                for (int i = 1; i <= partIndex; i++)
                {
                    if (array[i] > array[largestAt])
                    {
                        largestAt = i;
                    }
                }
                Swap(array,largestAt,partIndex);
            }
        }
        public static void BubbleSort(int[] array)
        {
            for (int partIndex = array.Length-1; partIndex > 0; partIndex--)
            {
                for (int i = 0; i < partIndex; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        Swap(array, i, i+1);
                    }
                }
            }
        }

        private static void Swap(int[] array, int i, int j)
        {
            var temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
