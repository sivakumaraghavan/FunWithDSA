using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Searching
{
    public class BinarySearch
    {
        public BinarySearch()
        {
            Console.WriteLine("Enter the elements for sorted array (space separated)");
            var input = Console.ReadLine();
            string[] sInput = input.Split(' ');
            int[] iInput = Array.ConvertAll(sInput, int.Parse);

            Console.WriteLine("Enter the element to search");
            int element = int.Parse(Console.ReadLine());

            Console.WriteLine("******Binary search*******");
            int result = BinarySearchNow(iInput, 0, iInput.Length, element);

            if (result == -1)
                Console.WriteLine("Element not found");
            else
                Console.WriteLine("Element found at index {0}", result);
        }
        private int BinarySearchNow(int[] sortedArray, int low, int high, int element)
        {
            if (high >= low)
            {
                int mid = low + (high - low) / 2; // Find mid point of the array

                if (sortedArray[mid] == element)
                    return mid;

                if (element < sortedArray[mid]) // If the element is less than the mid element search in left array
                    return BinarySearchNow(sortedArray, low, mid - 1, element); 

                if (element > sortedArray[mid]) // If the element is more than the mid element search in right array
                    return BinarySearchNow(sortedArray, mid + 1, high, element); 
            }
            return -1;
        }
    }
}