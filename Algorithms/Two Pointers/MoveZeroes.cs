using System;
namespace LeetCodeProblems.Algorithms.TwoPointers
{
	public class MoveZeroes
	{
        // Given an integer array nums, move all 0's to the end of it while maintaining the relative order of the non-zero elements.
        // Note that you must do this in-place without making a copy of the array.
        public static void Move(int[] nums)
        {
            // Initialize counter, set to zero because it will first be used
            // at nums[0]
            int counter = 0;

            // Iterate through nums.
            for (int i = 0; i < nums.Length; i++)
            {
                // Leave the zeroes alone.
                if (nums[i] == 0)
                    continue;
                // Instead, if value is not zero, move to beginning of array,
                // then increment counter to the next position.
                nums[counter] = nums[i];
                counter++;
            }

            // Now fill the rest of the array with zeroes.
            for (int i = counter; i < nums.Length; i++)
                nums[i] = 0;
        }
    }
}

