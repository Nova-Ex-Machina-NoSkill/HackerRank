namespace HackerRank.Algorithms.Warmup
{
    public static class SimpleArraySum
    {
        // https://www.hackerrank.com/challenges/simple-array-sum
        public static int GetSum(int[] array)
        {
            var sum = 0;
            foreach (int i in array) sum += i;
            return sum;
        }
    }
}
