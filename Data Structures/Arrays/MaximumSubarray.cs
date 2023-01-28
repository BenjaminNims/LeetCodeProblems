using System;
namespace LeetCodeProblems.Algorithms
{
	public class MaximumSubarray
	{
        // QUESTION: Given an integer array nums, find the subarray with the largest sum, and return its sum.

		// Note that we need not return the subarray itself, only the largest sum that can be obtained
		// from adding consecutive numbers in the array.

        public static int FindMaxSubarray(int[] nums)
		{
			// Initialize values for storing last and current maximums for comparison.
			int max = nums[0];
			int currentMax = nums[0];

			// For loop begins iterating at nums[1] to avoid the first operation yielding:
			// Math.Max(nums[0], nums[0] * 2)
			for (int i = 1; i < nums.Length; i++)
			{
				// this checks whether the value being iterated over is non-negative
				currentMax = Math.Max(nums[i], currentMax + nums[i]);

				// this sets the return value equal to either itself, or currentMax if it is greater after this iteration
				// of the for loop.
				max = Math.Max(max, currentMax);
			}

			return max;
		}
	}
}

