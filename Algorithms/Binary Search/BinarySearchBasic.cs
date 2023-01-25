using System;
namespace LeetCodeProblems.Algorithms.BinarySearch
{
	public class BinarySearchBasic
	{
        public static int Search(int[] nums, int target)
        {
            // Initialize a start and an end point.
            int mini = 0;
            // This seems to be a typical max for binary searches.
            int maxi = nums.Length - 1;

            // So, until the two ends meet.
            while (mini <= maxi)
            {
                // Initialize midpoint variable.
                int mid = (mini + maxi) / 2;

                //First check: is this our target?
                if (target == nums[mid])
                {
                    return mid;
                }
                // Second check: if it's less, we move our "end" to
                // one position to the left of the midpoint.
                else if (target < nums[mid])
                {
                    maxi = mid - 1;
                }
                // Finally, if it's greater, we move our "start" to
                // one position to the right of the midpoint.
                else
                {
                    mini = mid + 1;
                }
            }
            // Something went wrong if we're here.
            return -1;
        }
    }
}

