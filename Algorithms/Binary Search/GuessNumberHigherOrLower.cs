using System;
namespace LeetCodeProblems.Algorithms.BinarySearch
{
	public class GuessNumberHigherOrLower
	{

        /** 
        * Forward declaration of guess API.
        * @param  num   your guess
        * @return 	     -1 if num is higher than the picked number
        *			      1 if num is lower than the picked number
        *               otherwise return 0
        * int guess(int num);
        */

        public static int GuessNumber(int n)
        {
            // Initialize left, right, and middle variables.
            int min = 1;
            int max = n;
            int mid = 0;

            // I'll need to look into why it's <=.
            while (min <= max)
            {
                // Formula for midpoint.
                mid = min + (max - min) / 2;

                // So, if this is our answer...
                if (guess(mid) == 0)
                {
                    return mid;
                }
                // Next, check if the midpoint was lower than the guess.
                // If so, move "start" to one position right of the midpoint.
                else if (guess(mid) == 1)
                {
                    min = mid + 1;
                }
                // Finally, if it was higher. Order matters here but I don't know why yet.
                // Move "end" to one position left of the midpoint.
                else
                {
                    max = mid - 1;
                }
            }
            return mid;
        }
    }
}

