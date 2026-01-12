using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1266 : IProblem
    {
        public bool Test()
        {
            var points = new[] { new[] { 1, 1 }, new[] { 3, 4 }, new[] { -1, 0 } };

            var expected = 7;

            var result = MinTimeToVisitAllPoints(points);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MinTimeToVisitAllPoints(int[][] points)
        {
            var n = points.Length;

            var result = 0;
            for (int i = 1; i < n; ++i)
            {
                result += Math.Max(Math.Abs(points[i][0] - points[i - 1][0]), Math.Abs(points[i][1] - points[i - 1][1]));
            }

            return result;
        }
    }
}
