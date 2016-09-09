using System;

namespace HackerRank.Algorithms.Warmup
{
    // https://www.hackerrank.com/challenges/circular-array-rotation
    public static class CircularArrayRotation
    {
        public static void Read()
        {
            var arrString = Console.ReadLine();
            var argString = Console.ReadLine();
            var arr = arrString.Split(' ');
            var arg = argString.Split(' ');
            var n = int.Parse(arr[0]);
            var k = int.Parse(arr[1]);
            var q = int.Parse(arr[2]);
            var array = new int[n];
            var rotated = new int[n];
            var indexes = new int[q];
            for (var i = 0; i < n; i++) array[i] = int.Parse(arg[i]);
            for (var i = 0; i < q; i++) indexes[i] = int.Parse(Console.ReadLine());
            for (var i = 0; i < n; i++) rotated[(i + k) % n] = array[i];
            foreach (int i in indexes) Console.WriteLine(rotated[i]);
        }
    }
}
