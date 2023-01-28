using System;
namespace LeetCodeProblems.Algorithms
{
	public class RomanToInt
	{
        // Given a roman numeral, convert it to an integer.
        public static int RomanToInteger(string s)
        {
            // Use a dictionary to store as key-value pairs.
            Dictionary<char, int> set = new Dictionary<char, int>();

            // Initialize variable to hold sum.
            int sum = 0;

            set.Add('I', 1);
            set.Add('V', 5);
            set.Add('X', 10);
            set.Add('L', 50);
            set.Add('C', 100);
            set.Add('D', 500);
            set.Add('M', 1000);

            // Iterate over the string
            for (int i = 0; i < s.Length; i++)
            {
                // Initialize variable to store current character
                char currentRomanChar = s[i];

                // Use TryGetValue() method to find the value for the key, int num.
                set.TryGetValue(currentRomanChar, out int num);

                // Check vs. string length.
                // If the value to the right of the one we're iterating over
                // is higher than the current one, we can subtract the current
                // number from our sum (IV = 5 - 1 = 4)

                if (i + 1 < s.Length &&
                    set[s[i + 1]] > set[currentRomanChar])
                {
                    sum -= num;
                }
                else
                {
                    // Otherwise simply add value to the sum
                    sum += num;
                }
            }

            return sum;
        }
    }
}

