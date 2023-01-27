using System;
namespace LeetCodeProblems.Algorithms.TwoPointers
{
	public class RotateArray
	{
        // Credit for this solution goes to estabrook on LeetCode. This problem was
        // a challenge for me, and working through the elements of this helped me a
        // lot in understanding the problem, and some methods/concepts I wasn't
        // familiar with before.

        // Given an integer array nums, rotate the array to the right by k steps, where k is non-negative.
        // As an example, we'll use Rotate([1, 2, 3, 4, 5, 6], 3);
        // Expected solution is [4, 5, 6, 1, 2, 3]
        public void Rotate(int[] nums, int k)
        {
            // define a variable for the length for easy reference.
            int n = nums.Length;
            // This yields the "remainder" in division. Since k in this case is smaller than n, this will simply yield k.
            // However, if k is larger than n (more rotations than numbers in array), for example k=7, then we're effectively
            // only working with a rotation of one because we have one 360-degree rotation (6) plus one.
            k = k % n;

            // Reverse method is defined as a helper method below.

            // So, we first reverse the entire array (ex. [6, 5, 4, 3, 2, 1])
            Reverse(ref nums, 0, n - 1);
            // Then, we reverse the first half of the array (ex. [4, 5, 6, 3, 2, 1])
            Reverse(ref nums, 0, k - 1);
            // Finally, we reverse the second half (ex. [4, 5, 6, 1, 2, 3])
            Reverse(ref nums, k, n - 1);
        }

        // Saving this for later helper function reference
        public static void Reverse(ref int[] nums, int start, int end)
        {
            while (start < end)
            {
                nums[start] = nums[start] + nums[end];
                nums[end] = nums[start] - nums[end];
                nums[start] = nums[start++] - nums[end--];
            }
        }
    }
}

