namespace HackerRank.Algorithms.Warmup
{
    public static class AVeryBigSum
    {
        // https://www.hackerrank.com/challenges/a-very-big-sum
        public static long GetSum(int[] array)
        {
            var sum = 0L;
            foreach (int i in array) sum += i;
            return sum;
        }
    }
}
