using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Utilities
{
    public static class Util
    {
        public static int[] GetArrayElements()
        {
            var input = Console.ReadLine();
            string[] sInput = input.Split(' ');
            return Array.ConvertAll(sInput, int.Parse);
        }

        public static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
