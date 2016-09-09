using System;

namespace HackerRank.Algorithms.Warmup
{
    // https://www.hackerrank.com/challenges/staircase
    public static class Staircase
    {
        public static void DrawStaircase(int lenght)
        {
            for(var i = 1; i <= lenght; i++)
            {
                var s = "";
                for (var j = lenght - i; j > 0; j--) s += " ";
                for (var k = i; k > 0; k--) s += "#";
                Console.WriteLine(s);
            }
        }
    }
}
