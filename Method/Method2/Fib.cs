using System;

namespace Method2
{
    class Fib
    {
        static void Main(string[] args)
        {
            // Loop through the first 10 numbers of the Fibonacci sequence and print them
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Fibonacci({i}) = {Fibonacci(i)}");
            }
        }

        // Method to calculate the nth Fibonacci number using recursion
        static int Fibonacci(int n)
        {
            // Base case: the first and second Fibonacci numbers are 1
            if (n == 1 || n == 2)
            {
                return 1;
            }
        
            // Recursive case: the nth Fibonacci number is the sum of the (n-1)th and (n-2)th numbers
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }

    
}