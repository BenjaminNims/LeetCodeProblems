using System;
namespace LeetCodeProblems.Algorithms.ProgrammingSkills
{
	public class AvgSalaryNoMaxOrMin
	{
        public static double Average(int[] salary)
        {
            // Declare required variables.
            int i, min, max, n;
            // Define length.
            n = salary.Length;

            // Both pointers are in position 1: provides baseline value for
            // comparisons in the for loop.
            min = salary[0];
            max = salary[0];

            // Iterate starting on i = 1, as the pointers are both at salary[0]
            for (i = 1; i < n; i++)
            {
                // If value is higher than max, it's the new max.
                if (salary[i] > max)
                {
                    max = salary[i];
                }
                // Same with the min value.
                if (salary[i] < min)
                {
                    min = salary[i];
                }
            }

            // Take the values we want and put them in the array
            // First those that satisfy one condition, then the other.
            salary = salary.Where(val => val != max).ToArray();
            salary = salary.Where(val => val != min).ToArray();

            // The Queryable classes and methods convert generic IEnumerables
            // to IQueryables, allowing us to find the average of the
            // values directly.
            double avg = Queryable.Average(salary.AsQueryable());
            return avg;
        }

    }
}

