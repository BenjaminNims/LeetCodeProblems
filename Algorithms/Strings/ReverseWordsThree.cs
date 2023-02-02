using System;
namespace LeetCodeProblems.Algorithms.Strings
{
	public class ReverseWordsThree
	{
        public static string ReverseWords(string s)
        {
            // We use the Join method to concatenate members of an IEnumerable
            // using the specified separator.
            string result = string.Join(" ", s
            .Split(' ') // Splits the input string at each space.
            .Select(x => new String(x.Reverse().ToArray())));

            // So, in the above (...).Select(); method, we are taking in the split
            // string, reversing them, and placing them into an array, which we then initialize
            // into a new string.

            // Return that string.
            return result;
        }
    }
}

