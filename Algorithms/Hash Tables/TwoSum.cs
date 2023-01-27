using System;
using System.Diagnostics;
using System.Runtime.Intrinsics.X86;

namespace LeetCodeProblems.Algorithms.HashTables
{
	public class TwoSum
	{
//        **Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
//        You may assume that each input would have exactly one solution, and you may not use the same element twice.
//        You can return the answer in any order.**

        public int[] TwoSumSolve(int[] nums, int target)
        {
            // initialize a new dictionary. The values from the nums array will be key and the index will be value.
            Dictionary<int, int> valToIndex = new Dictionary<int, int>(nums.Length);

            for (int i = 0; i < nums.Length; i++)
            {
                // Use ContainsKey method to test if the dictionary contains a number that added to the
                // current value would yield the target.
                if (valToIndex.ContainsKey(target - nums[i]))
                {
                    // if so, return an index with the two keys (the one we just found, the current one)
                    return new int[] { valToIndex[target - nums[i]], i };
                }
                // If not, add the current value and index to the dictionary.
                valToIndex[nums[i]] = i;
            }
            // Something has gone awry if we are here.
            return new int[] { -1, -1 };
        }
    }
}

