using System;
namespace LeetCodeProblems.Algorithms.ProgrammingSkills
{
	public class CountOddNumbersWithinInterval
	{
        // Given an interval, return the number of odds in each range.
        // So, low=8 and high=10 yields 1 ([8,9,10]).
        public static int CountOdds(int low, int high)
        {
            // Definition of range.
            int range = (high - low + 1);
            // Initialize solution variable.
            int numberOfOdds = 0;

            // If range is even, the number of evens and odds will be the same.
            if (range % 2 == 0)
            {
                numberOfOdds = (high - low) / 2;
            }
            // If odd, the number is the difference between high and low minus one.
            else
                numberOfOdds = (high - low - 1);

            return numberOfOdds;
        }
    }
}

