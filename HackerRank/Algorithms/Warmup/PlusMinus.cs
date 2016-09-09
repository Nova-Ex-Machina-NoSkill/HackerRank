using System;

namespace HackerRank.Algorithms.Warmup
{
    // https://www.hackerrank.com/challenges/plus-minus
    public static class PlusMinus
    {
        public static void Fractions(int[] array)
        {
            var positive = 0;
            var negative = 0;
            var zero = 0;
            foreach(int i in array)
            {
                if (i > 0) positive++;
                else if (i < 0) negative++;
                else zero++;
            }
            Console.WriteLine((double)positive / array.Length);
            Console.WriteLine((double)negative / array.Length);
            Console.WriteLine((double)zero / array.Length);
        }
    }
}
