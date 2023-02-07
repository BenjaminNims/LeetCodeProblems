using System;
using System.Transactions;

namespace LeetCodeProblems.DataStructures.Arrays
{
//    You are given an array prices where prices[i] is the price of a given stock on the ith day.

//    You want to maximize your profit by choosing a single day to buy one stock and choosing a different day in the future
//    to sell that stock.

//    Return the maximum profit you can achieve from this transaction.If you cannot achieve any profit, return 0.

    public class BestTimeBuySellStock
	{
        public static int MaxProfit(int[] prices)
        {
            // Declare min and max variables. Min is set to the highest possible value
            // because we want our comparison functions to always yield the input on the first pass.
            // Max is our "max profit" variable: we init to zero for the same reason.
            int max = 0;
            int min = Int32.MaxValue;

            // For each of our prices...
            foreach (int price in prices)
            {
                // We check to see if the price is lower than our current min, and if it is,
                // we have our new min.
                min = Math.Min(price, min);
                // Then, if our price minus our current min (profit) is greater than our current max profit,
                // max is set equal to that difference.
                max = Math.Max(price - min, max);
            }

            // Return max profit. Note that if our price for each day is lower than the previous one,
            // we will return zero, as (price - min) <= 0.
            return max;
        }
    }
}

