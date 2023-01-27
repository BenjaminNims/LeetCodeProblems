using System;
namespace LeetCodeProblems.Algorithms.BinarySearch
{
	public class SearchInputPosition
	{
        // This is essentially a template for a generic binary search.
        public static int SearchInsert(int[] nums, int target)
        {
            int start = 0;
            int end = nums.Length - 1;

            while (start <= end)
            {
                int mid = (start + end) / 2;

                if (target < nums[mid])
                {
                    end = mid - 1;
                }
                else if (target > nums[mid])
                {
                    start = mid + 1;
                }
                else
                {
                    return mid;
                }
            }
            return start;
        }
    }
}

