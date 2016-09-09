namespace HackerRank.Algorithms.Warmup
{
    public static class CompareTheTriplets
    {
        // https://www.hackerrank.com/challenges/compare-the-triplets
        public static void ComparePoints(ref int firstContester, ref int secondContester, int[] firstContesterAnswers, int[] secondContesterAnswers)
        {
            var n = firstContesterAnswers.Length;
            for(var i = 0; i < n; i++)
            {
                if (firstContesterAnswers[i] > secondContesterAnswers[i]) firstContester++;
                else if (firstContesterAnswers[i] < secondContesterAnswers[i]) secondContester++;
            }
        }
    }
}
