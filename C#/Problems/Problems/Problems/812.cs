using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _812 : IProblem
    {
        public bool Test()
        {
            var points = new[] { new[] { 0, 0 }, new[] { 0, 1 }, new[] { 1, 0 }, new[] { 0, 2 }, new[] { 2, 0 } };

            var expected = 2.0;

            var result = LargestTriangleArea(points);

            Console.WriteLine(result);

            return expected == result;
        }

        public double LargestTriangleArea(int[][] points)
        {
            var n = points.Length;
            var result = 0.0;
            for (int i = 0; i < n; ++i)
            {
                for (int j = i + 1; j < n; ++j)
                {
                    for (int k = j + 1; k < n; ++k)
                        result = Math.Max(result, Math.Abs((points[j][0] - points[i][0]) * (points[k][1] - points[i][1])
                                                           - (points[j][1] - points[i][1]) *
                                                           (points[k][0] - points[i][0])) / 2.0);
                }
            }

            return result;
        }
    }
}
