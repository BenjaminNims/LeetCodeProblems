using System;
using static System.Net.Mime.MediaTypeNames;
using System.Diagnostics;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;

namespace LeetCodeProblems.Algorithms.BinarySearch
{
//    Solution courtesy of komiljon_aliev on LeetCode. Much more elegant than my
//    own implementation.

//    **Given a 1-indexed array of integers numbers that is already sorted in non-decreasing order, find two numbers such that they add up to a specific target number.Let these two numbers be numbers[index1] and numbers[index2] where 1 <= index1<index2 <= numbers.length.
//    Return the indices of the two numbers, index1 and index2, added by one as an integer array[index1, index2] of length 2.

//    The tests are generated such that there is exactly one solution.You may not use the same element twice.
//    Your solution must use only constant extra space.**
    public class TwoSumSortedInputArray
	{
        public static int[] TwoSum(int[] numbers, int target)
        {
            // initialize two pointers
            int min = 0, max = numbers.Length - 1;
            // while we don't have our solution yet
            while ((numbers[min] + numbers[max]) != target)
                // If we're too high, we need to decrease our max: since the array
                // is sorted in ascending order, this will yield the next highest number.
                if ((numbers[min] + numbers[max]) > target) max--;

                // otherwise we want the inverse
                else min++;
            // return a new array as the solution, adding one to each value as instructed in the problem.
            return new int[] { min + 1, max + 1 };
        }
    }
}

