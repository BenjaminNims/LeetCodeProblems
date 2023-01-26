using System;
namespace LeetCodeProblems.Algorithms.ProgrammingSkills
{
	public class CountOddNumbersWithinInterval
	{
        // Given an interval, return the number of odds in each range.
        // So, low=8 and high=10 yields 1 ([8,9,10]).
        public static int CountOdds(int low, int high)
        {
            // Initialize counter.
            int numberOfOdds = 0;

            // If both numbers are non-zero...
            if (low >= 0 && high >= 0)
            {
                // Iterating from low to high...
                for (int i = low; i <= high; i++)
                {
                    // if i is not even, increment odd counter.
                    if (!(i % 2 == 0))
                    {
                        numberOfOdds++;
                    }
                }
            }

            return numberOfOdds;
        }
    }
}

