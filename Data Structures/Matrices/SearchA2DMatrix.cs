using System;
namespace LeetCodeProblems.DataStructures.Matrices
{
	public class SearchA2DMatrix
	{
        public static bool SearchMatrix(int[][] matrix, int target)
        {
            // Row and column quantities are always the following:
            int rows = matrix.Length;
            int columns = matrix[0].Length;

            // Nested for loop to access matrix.
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    // We first iterate over the matrix to see if our target is
                    // still ahead of us in the for loop. If the element at the last
                    // column of the last row is still less than our target,
                    // we can break and return false, because our matrix does not
                    // have it.
                    if (matrix[i][columns - 1] < target && i < rows - 1)
                    {
                        break;
                    }

                    // Now knowing that our target may be in the range of the matrix,
                    // we iterate through the y-axis by column to see if one of the rows
                    // has our target.
                    if (matrix[i][j] == target)
                    {
                        return true;
                    }
                }
            }

            // If not, return false.
            return false;
        }
    }
}

