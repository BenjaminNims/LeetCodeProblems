using System;
using System.Drawing;

namespace LeetCodeProblems.DataStructures.Matrices
{
	public class ReshapeTheMatrix
	{
//        **In MATLAB, there is a handy function called reshape which can reshape an m x n matrix into a new one
//        with a different size r x c keeping its original data.

//        You are given an m x n matrix mat and two integers r and c representing
//        the number of rows and the number of columns of the wanted reshaped matrix.

//        The reshaped matrix should be filled with all the elements
//        of the original matrix in the same row-traversing order as they were.

//        If the reshape operation with given parameters is possible and legal,
//        output the new reshaped matrix; Otherwise, output the original matrix.**

        public static int[][] MatrixReshape(int[][] mat, int r, int c)
        {
            // Number of rows is always mat.Length.
            int rows = mat.Length;
            // Numbers of columns is always mat[0].Length.
            int columns = mat[0].Length;

            // So, if the dimensions of the first matrix do not correspond to the
            // dimensions in the new matrix, return the old matrix.
            if ((rows * columns) != (r * c)) return mat;

            // Declare the new array.
            int[][] output_arr = new int[r][];

            // For whatever fuckin reason you can't just declare new int[r][c], so
            // iterate over the new array with this for loop to add the number
            // of columns
            for (int i = 0; i < r; i++)
            {
                output_arr[i] = new int[c];
            }


            int row_num = 0;
            int column_num = 0;

            // Iterate over the new matrix
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    // Assign values from mat into the new matrix.
                    output_arr[row_num][column_num] = mat[i][j];
                    // Iterate by column: the second value goes into row 1, column 2...
                    column_num++;
                    // If we're on the last column in the new array, reset column to zero
                    // and move to the next row.
                    if (column_num == c)
                    {
                        column_num = 0;
                        row_num++;
                    }
                }
            }
            // Return the new matrix.
            return output_arr;
        }
    }
}

