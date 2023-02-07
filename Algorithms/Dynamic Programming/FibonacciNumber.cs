using System;
namespace LeetCodeProblems.Algorithms.DynamicProgramming
{
	public class FibonacciNumber
	{
        // The Fibonacci numbers, commonly denoted F(n) form a sequence, called the Fibonacci sequence,
        // such that each number is the sum of the two preceding ones, starting from 0 and 1. That is...

        // F(0) = 0, F(1) = 1
        // F(n) = F(n - 1) + F(n - 2), for n > 1.

        public int Fib(int n)
        {
            // We know this because F(1) is explicitly stated to equa1 1, & F(2-1) + F(2-2) => F(1) + F(0) => F(1) = 1.
            if (n == 1 || n == 2)
            {
                return 1;
            }
            // Condition stated in problem description.
            else if (n == 0)
            {
                return 0;
            }
            // This implementation uses recursion, or calling a function within itself. The formula is the same
            // as that listed in the problem description.
            else
            {
                return Fib(n - 1) + Fib(n - 2);
            }
        }
    }
}

