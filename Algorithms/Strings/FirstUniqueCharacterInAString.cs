using System;
namespace LeetCodeProblems.Algorithms.Strings
{
	public class FirstUniqueCharacterInAString
	{
        // **Given a string s, find the first non-repeating character in it and return its index. If it does not exist, return -1.**
        public static int FirstUniqChar(string s)
        {
            // Initialize a dictionary to store characters and their indexes.
            Dictionary<char, int> letters = new Dictionary<char, int>();

            // Iterate over the string.
            for (int i = 0; i < s.Length; i++)
            {
                // If the dictionary already contains the character at the current location,
                // set the value for each key matching the letter to -1, which we will use as
                // a filter.
                if (letters.ContainsKey(s[i]))
                {
                    letters[s[i]] = -1;
                }
                // Else, add the letter to the dictionary with its index as the value in the pair.
                else
                {
                    letters.Add(s[i], i);
                }
            }

            // Iterate over each KV pair in the dictionary.
            foreach (KeyValuePair<char, int> pair in letters)
            {
                // Since we set each value of a repeated char to -1, when we iterate over the
                // dictionary, we will find the first key to have a value other than -1
                // and return that value.
                if (pair.Value != -1)
                {
                    return pair.Value;
                }
            }

            // Should we not have any unique characters, return -1.
            return -1;
        }
    }
}

