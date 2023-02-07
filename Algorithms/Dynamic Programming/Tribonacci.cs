using System;
namespace LeetCodeProblems.Algorithms.DynamicProgramming
{
	public class Tribonacci
	{
        // **The Tribonacci sequence Tn is defined as follows:  T0 = 0, T1 = 1, T2 = 1, and Tn+3 = Tn + Tn+1 + Tn+2 for n >= 0.
        // Given n, return the value of Tn.**

        // Credit for this solution goes to Santhosh1608. My original recursion-based solution exceeded the time limit.

        public static int Trib(int n)
        {
            // To solve dynamically, init a new List object with room for (n + 1) items,
            // that is: if n=3, the list will contain [(0, 0), (1, 1), (2, 1), (3, 2)]
            List<int> dp = new List<int>(n + 1);

            // These two if statements establish the conditions listed in the problem.
            if (n == 1 || n == 2)
            {
                return 1;
            }
            else if (n == 0)
            {
                return 0;
            }
            // Include the T0-T2 values in the List.
            dp.Insert(0, 0);
            dp.Insert(1, 1);
            dp.Insert(2, 1);

            // Insert the results of the Tribonacci function for each number leading up to n.
            for (int i = 3; i <= n; i++)
            {
                // Allocate a variable that holds the result of the function in the problem's description.
                int temp = dp[i - 3] + dp[i - 2] + dp[i - 1];
                // Insert the value and its result into the list.
                dp.Insert(i, temp);
            }

            // Return the last inserted value, that is, the solution.
            return dp[n];
        }
    }
}

