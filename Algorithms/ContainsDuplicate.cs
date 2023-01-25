using System;
namespace LeetCodeProblems.Algorithms
{
	public class EmptyClass
	{
        // Given an integer array nums, return true if any value appears at least twice in the array,
        // and return false if every element is distinct.

        public static bool ContainsDuplicate(int[] nums)
        {
            // Initialize a new Hashset
            HashSet<int> set = new();

            // Iterate over the array
            for (int i = 0; i < nums.Length; i++)
            {
                // If condition of problem is not met, add element to Hashset.
                if (set.Contains(nums[i]))
                {
                    return true;
                }

                set.Add(nums[i]);
            }

            // If we're at this point, all elements are distinct.
            return false;
        }
    }
}

