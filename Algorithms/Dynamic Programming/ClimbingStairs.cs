using System;
namespace LeetCodeProblems.Algorithms.DynamicProgramming
{
	public class ClimbingStairs
	{
        // You are climbing a staircase. It takes n steps to reach the top. Each time you can either climb 1 or 2 steps.
        // In how many distinct ways can you climb to the top?

        // Finalized my implementation using gresgklyanny's solution. Originally used a List which yielded the correct answer,
        // but returned an "index out of bounds" exception.
        public static int ClimbStairs(int n)
        {
            // Only one way to take one step.
            if (n == 1)
            {
                return 1;
            }
            // Init a new array of n + 1 size.
            int[] dp = new int[n + 1];
            // Load up the first two values into the array.
            dp[1] = 1;
            dp[2] = 2;
            // For all numbers leading up to n, we insert values into the array using the Fibonacci formula
            // (this problem is only a slight variation on the Fibonacci problem).
            for (int i = 3; i <= n; i++)
            {
                dp[i] = dp[i - 1] + dp[i - 2];
            }
            // Return the last inserted value, that is, our answer.
            return dp[n];
        }
    }
}

