using Algorithms.Utilities;
using System;

namespace Algorithms.Sorting
{
    public class QuickSort
    {
        public QuickSort()
        {
            Console.WriteLine("Enter the elements of an array (space separated)");
            int[] iInput = Util.GetArrayElements();

            Console.WriteLine("\n******Quick Sort*******");

            QuickSortNow(iInput, 0, iInput.Length - 1);

            Console.WriteLine("Array after quick sort");
            Util.PrintArray(iInput);

            Console.ReadLine();
        }

        public QuickSort(int[] unSortedArray)
        {
            QuickSortNow(unSortedArray, 0, unSortedArray.Length - 1);
        }

        private void QuickSortNow(int[] unsortedArray, int low, int high)
        {
            if (low <= high)
            {
                int pivot = PartitionArrayByChoosingLastELementAsPivot(unsortedArray, low, high);

                QuickSortNow(unsortedArray, low, pivot - 1);
                QuickSortNow(unsortedArray, pivot + 1, high);
            }
        }

        private int PartitionArrayByChoosingLastELementAsPivot(int[] unSortedArray, int low, int high)
        {
            int pivotElement = unSortedArray[high];
            int pivotIndex = low;
            int temp;

            for (int i = low; i < high; i++)
            {
                if (unSortedArray[i] < pivotElement)
                {
                    temp = unSortedArray[pivotIndex];
                    unSortedArray[pivotIndex] = unSortedArray[i];
                    unSortedArray[i] = temp;

                    pivotIndex++;
                }
            }

            temp = unSortedArray[pivotIndex];
            unSortedArray[pivotIndex] = unSortedArray[high];
            unSortedArray[high] = temp;

            return pivotIndex;
        }

        private int PartitionArrayByChoosingFirstELementAsPivot(int[] unSortedArray, int low, int high)
        {
            int pivotElement = unSortedArray[low];
            int pivotIndex = low;
            int temp;

            for (int i = low + 1; i <= high; i++)
            {
                if (unSortedArray[i] < pivotElement)
                {
                    pivotIndex++;

                    temp = unSortedArray[pivotIndex];
                    unSortedArray[pivotIndex] = unSortedArray[i];
                    unSortedArray[i] = temp;
                }
            }

            temp = unSortedArray[pivotIndex];
            unSortedArray[pivotIndex] = unSortedArray[low];
            unSortedArray[low] = temp;

            return pivotIndex;
        }
    }
}