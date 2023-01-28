using System;
namespace LeetCodeProblems.DataStructures.Arrays
{
	public class IntersectionOfTwoArraysII
	{
        // Credit for this solution goes to KunMan on LeetCode.
        // This is one of three approaches to solving this problem. Here the solution
        // is based on sorting, but binary search and HashMap approaches are possible.

        // **Given two integer arrays nums1 and nums2, return an array of their intersection.
        // Each element in the result must appear as many times as it shows in both arrays
        // and you may return the result in any order.**

        // Note: this question is somewhat misleading with LeetCode's examples: returning the exact order
        // of an intersection, like a substring, is not the objective. Return only the values that appear
        // in both.

        public int[] Intersect(int[] nums1, int[] nums2)
        {
            // Sort our arrays.
            Array.Sort(nums1);
            Array.Sort(nums2);

            // Declare a new list.
            List<int> result = new List<int>();

            // Declare iterating variables.
            int i = 0;
            int j = 0;

            // Use this approach to iterate over two lists simulataneously without using nested for loops.
            // Since our arrays are now sorted, we can iterate in a linear path.
            while (i < nums1.Length && j < nums2.Length)
            {
                // So, if we get a match, we'll add the value to our list and manually increment both iterating variables.
                if (nums1[i] == nums2[j])
                {
                    result.Add(nums1[i]);
                    i++;
                    j++;
                }
                // So, for example, if nums1[0] < nums2[0], we would increment the nums1 iterator
                // so that we compare nums[1] (which is greater)
                // with nums2[0] on the next run through the loop.
                else if (nums1[i] < nums2[j])
                {
                    i++;
                }
                // Should nums1[0] be greater than nums2[0], we would want to compare nums1[0] to nums2[1],
                // which is greater than nums2[0].
                else
                {
                    j++;
                }
            }

            // Convert our list to an array that contains all shared values, and return it.
            return result.ToArray();
        }
    }
}

