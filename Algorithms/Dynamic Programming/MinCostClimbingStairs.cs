using System;
namespace LeetCodeProblems.Algorithms.DynamicProgramming
{
	public class MinCostClimbingStairs
	{
        // ** You are given an integer array cost where cost[i] is the cost of ith step on a staircase.
        // Once you pay the cost, you can either climb one or two steps.
//        You can either start from the step with index 0, or the step with index 1.
//        Return the minimum cost to reach the top of the floor. **

        // Implementation created by shikhar47 on LeetCode.

        public static int MinCost(int[] cost)
        {
            // Starting pointers are the last and second to last in the array. We are starting from the end.
            int a = cost[cost.Length - 1];
            int b = cost[cost.Length - 2];
            // Initialize counter.
            int c = 0;

            // So, starting from the next integer up from the two at the end, we're going to decrement our way through the list.
            for (int i = cost.Length - 3; i >= 0; i--)
            {
                // Our counter will be set to the current element plus the minimum of the two after it, which is the ideal step.
                c = cost[i] + Math.Min(b, a);
                // We then reset our start variable to the previous end point and our end variable to the result of c, which will
                // determine whether we climb one or two steps on the next iteration.
                a = b;
                b = c;
            }

            // Return solution.
            return Math.Min(b, a);

        }
    }
}

