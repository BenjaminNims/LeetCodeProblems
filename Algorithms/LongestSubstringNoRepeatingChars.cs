using System;
using System.Data.SqlTypes;

namespace LeetCodeProblems.Algorithms
{
	public class LongestSubstringNoRepeatingChars
	{
        // QUESTION: Given a string s, find the length of the longest substring without repeating characters.

        // Use the "sliding window" method.
        public static int LengthOfLongestSubstring(string s)
        {

            int start = 0;
            int end = 0;
            int maxLength = 0;

            // If the HashSet already has a character in it, it returns false.
            HashSet<char> set = new HashSet<char>();

            // Use a while loop to iterate
            while (end < s.Length)
            {
                // So, if "true," that is, if the character being added is not
                // already present in the HashSet
                if (set.Add(s[end]))
                {
                    // then we move up to the next char and adjust our maxLength
                    // to the number of chars in the HashSet
                    end++;
                    maxLength = Math.Max(maxLength, set.Count);
                }
                else
                {
                    // Else we increment the start and remove the redundant char
                    // from the string
                    set.Remove(s[start]);
                    start++;
                }
            }

            return maxLength;
        }
    }
}

