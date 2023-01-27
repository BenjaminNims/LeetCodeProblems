using System;
namespace LeetCodeProblems.Algorithms.ProgrammingSkills
{
	public class IsPerfectSquare
	{
        public bool IsPerfectSq(int num)
        {
            // Get the number to the power of 1/2 (the square root) and mod
            // 1 to see if it's an integer: a perfect square will yield mod 0.
            return (Math.Pow(num, 0.5)) % 1 == 0;
        }
    }
}

