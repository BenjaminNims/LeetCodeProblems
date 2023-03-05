using System;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace LeetCodeProblems.Algorithms.BinarySearch
{
	public class FindTargetIndecesAfterSortingArray
	{
        // You are given a 0-indexed integer array nums and a target element target.
        // A target index is an index i such that nums[i] == target.
        // Return a list of the target indices of nums after sorting nums in non-decreasing order.If there are no target indices,
        // return an empty list.The returned list must be sorted in increasing order.

        // implementation credit goes to Sree12345 at LeetCode.

        public void Binarysearch(int[] nums, int low, int high, int target, List<int> list)
        {
            // Fulfilling for all items in nums
            if (low <= high)
            {
                // this template for mid controls for overflow
                int mid = low + (high - low) / 2;

                // if we've got what we're looking for
                if (nums[mid] == target)
                {
                    // put the index in the IList<T> object
                    list.Add(mid);
                    // Perform binarysearch in both directions to confirm whether other
                    // matches for target exist on either side
                    Binarysearch(nums, low, mid - 1, target, list);
                    Binarysearch(nums, mid + 1, high, target, list);
                }
                // else if our guess is too high...
                else if (nums[mid] > target)
                    // perform Binarysearch in the leftward direction
                    Binarysearch(nums, low, mid - 1, target, list);
                // else if our guess is too low...
                else
                    // perform Binarysearch in the rightward direction
                    Binarysearch(nums, mid + 1, high, target, list);
            }
        }
        // we implement our actual funtion, which will return our solution
        public IList<int> TargetIndices(int[] nums, int target)
        {
            // sort the array
            Array.Sort(nums);
            // initialize high and low variables
            int low = 0, high = nums.Length - 1;
            // initialize list for indeces
            List<int> list = new List<int>();
            // perform recursive binarysearch defined above
            Binarysearch(nums, low, high, target, list);
            // sort the list
            list.Sort();
            // return our answer
            return list;
        }
    }
}

