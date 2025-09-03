using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{

    // SAME AS 3027
    public class _3025 : IProblem
    {
        public bool Test()
        {
            var points = new[] { new[] { 3, 1 }, new[] { 1, 3 }, new[] { 1, 1 } };

            var expected = 2;

            var result = NumberOfPairs(points);

            Console.WriteLine(result);

            return result == expected;
        }

        public int NumberOfPairs(int[][] points)
        {
            var n = points.Length;
            Array.Sort(points, Comparer<int[]>.Create(ComparePoints));
            var result = 0;

            for (int i = 0; i < n - 1; ++i)
            {
                var maxX = int.MaxValue;
                var maxY = int.MaxValue;
                for (int j = i + 1; j < n; ++j)
                {
                    if (points[j][0] <= points[i][0] && points[j][1] >= points[i][1] && points[j][0] < maxX && points[j][1] < maxY)
                    {
                        result++;
                        maxX = points[j][0];
                        maxY = points[j][1];
                    }
                }
            }

            return result;
        }

        private int ComparePoints(int[] x, int[] y)
        {
            if (x[0] != y[0])
                return y[0].CompareTo(x[0]);
            return x[1].CompareTo(y[1]);
        }
    }
}
