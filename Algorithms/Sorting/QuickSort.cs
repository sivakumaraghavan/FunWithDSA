using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sorting
{
    class QuickSort
    {
        public QuickSort()
        {
            Console.WriteLine("Enter the elements of an array (space separated)");
            var input = Console.ReadLine();
            string[] sInput = input.Split(' ');
            int[] iInput = Array.ConvertAll(sInput, int.Parse);

            Console.WriteLine("******Quick Sort*******");

        }
    }
}
