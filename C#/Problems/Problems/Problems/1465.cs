using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1465 : IProblem
    {
        public bool Test()
        {
            var h = 5;
            var w = 4;
            var horizontalCuts = new[] { 1, 2, 4 };
            var verticalCuts = new[] { 1, 3 };

            var expected = 4;

            var result = MaxArea(h, w, horizontalCuts, verticalCuts);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MaxArea(int h, int w, int[] horizontalCuts, int[] verticalCuts)
        {
            var n = horizontalCuts.Length;
            var m = verticalCuts.Length;
            Array.Sort(horizontalCuts);
            Array.Sort(verticalCuts);
            var maxH = horizontalCuts[0];
            for (int i = 1; i < n; ++i)
                maxH = Math.Max(maxH, horizontalCuts[i] - horizontalCuts[i - 1]);
            maxH = Math.Max(maxH, h - horizontalCuts[n - 1]);
            var maxW = verticalCuts[0];
            for (int i = 1; i < m; ++i)
                maxW = Math.Max(maxW, verticalCuts[i] - verticalCuts[i - 1]);
            maxW = Math.Max(maxW, w - verticalCuts[m - 1]);

            return (int)((long)maxH * maxW % 1000000007);
        }
    }
}
