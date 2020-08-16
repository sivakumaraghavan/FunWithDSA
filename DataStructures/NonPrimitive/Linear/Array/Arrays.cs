using System;
using Algorithms.Utilities;
using Algorithms.Sorting;

namespace DataStructures.NonPrimitive.Linear.Array
{
    class Arrays
    {
        private int[] Insertion(int[] array, int element, int position)
        {
            int arrayLength = array.Length+1;
            int[] newArray = new int[arrayLength];

            for(int index=0; index < arrayLength; index++)
            {
                if (index < position - 1)
                    newArray[index] = array[index];
                else
                if (index == position - 1)
                    newArray[index] = element;
                else
                    newArray[index] = array[index - 1];
            }

            return newArray;
        }

        private int[] Deletion(int[] array, int element)
        {
            int arrayLength = array.Length;
            int[] newArray = new int[arrayLength - 1];

            int k = 0;

            for (int index = 0; index < arrayLength; index++)
            {
                if (array[index] != element)
                    newArray[k++] = array[index];
            }

            return newArray;
        }

        private void Sorting(int[] array)
        {
            QuickSort quickSort = new QuickSort(array);
        }

        public Arrays()
        {
            Console.WriteLine("Enter the elements of an array (space separated)");
            int[] iArray = Util.GetArrayElements();

            Console.WriteLine("Enter the element to be inserted into array");
            int element = Util.GetIntegerValue();

            Console.WriteLine("Enter the position in which the element to be inserted");
            int position = Util.GetIntegerValue();

            iArray = Insertion(iArray, element, position);

            Console.WriteLine("Array after inserting {0}", element);
            Util.PrintArray(iArray);

            Console.WriteLine("\nEnter the element to be deleted");
            element = Util.GetIntegerValue();

            iArray = Deletion(iArray, element);

            Console.WriteLine("\nArray after deleting {0}", element);
            Util.PrintArray(iArray);

            Console.WriteLine("\nArray after quick sort");
            Sorting(iArray);
            Util.PrintArray(iArray);

            Console.ReadLine();
        }
    }
}