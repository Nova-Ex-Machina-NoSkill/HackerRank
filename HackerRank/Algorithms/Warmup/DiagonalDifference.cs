using System;

namespace HackerRank.Algorithms.Warmup
{
    // https://www.hackerrank.com/challenges/diagonal-difference
    public static class DiagonalDifference
    {
        public static int GetSum(int[][] array)
        {
            var primary = 0;
            var secondary = 0;
            for(var i = 0; i < array.Length; i++)
            {
                primary += array[i][i];
                secondary += array[i][array.Length - 1 - i];
            }
            return Math.Abs(primary - secondary);
        }
    }
}
