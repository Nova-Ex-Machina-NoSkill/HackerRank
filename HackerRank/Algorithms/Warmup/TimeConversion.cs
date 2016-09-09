using System;

namespace HackerRank.Algorithms.Warmup
{
    public static class TimeConversion
    {
        // https://www.hackerrank.com/challenges/time-conversion
        public static string Format(string time)
        {
            var hours = int.Parse(time.Substring(0, 2));
            var minutes = time.Substring(3, 2);
            var seconds = time.Substring(6, 2);
            var ampm = time.Substring(8, 2).ToLower();
            if (ampm == "pm") hours = (hours + 12) % 24;
            return String.Format("{0:00}:{1:00}:{2:00}", hours, minutes, seconds);
        }
    }
}
