using System;
namespace LeetCodeProblems.Algorithms.BinarySearch
{
	public class PeakIndexInMountainArray
	{
        // A mountain array is one that ascends for part of it and descends for the other part.
        // i.e. [1, 4, 6, 4, 2]
        public int PeakIndexInMountain(int[] arr)
        {
            // Define two pointers
            int left = 0;
            int right = arr.Length - 1;

            // While we still have array to examine
            while (left < right)
            {
                // Define mid within while loop to avoid infinite loop.
                int mid = (left + right) / 2;

                // If the index in the middle is equal to or larger than the next element in the array,
                // we have our peak and our right pointer can be set to the correct position.
                if (arr[mid] >= arr[mid + 1])
                {
                    right = mid;
                }
                // Else, we can eliminate everything up until and including the element at arr[mid]
                else
                {
                    left = mid + 1;
                }
            }

            // Return our right pointer
            return right;
        }
    }
}

