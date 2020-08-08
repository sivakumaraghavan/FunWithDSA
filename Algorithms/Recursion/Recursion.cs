using System;

namespace Algorithms.Recursion
{
    class Recursion
    {
        public Recursion()
        {
            Console.WriteLine("Enter the number to find factorial and fibonacci using recursion");

            int number = Utilities.Util.GetIntegerValue();

            Console.WriteLine("Recursion --> Factorial");
            Console.WriteLine(Factorial(number));

            Console.WriteLine("Recursion --> Fabonacci");
            Console.WriteLine(Fibonacci(number));
        }

        private int Factorial(int number)
        {
            if (number <= 1)
                return number;

            return number * Factorial(number - 1);
        }

        private int Fibonacci(int number)
        {
            if (number <= 1)
                return number;

            return Fibonacci(number - 1) + Fibonacci(number - 2);
        }
    }
}