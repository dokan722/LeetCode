using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _963 : IProblem
    {
        public bool Test()
        {
            var points = new[] { new[] { 1, 2 }, new[] { 2, 1 }, new[] { 1, 0 }, new[] { 0, 1 } };

            var expected = 2.0;

            var result = MinAreaFreeRect(points);

            Console.WriteLine(result);
            return Math.Abs(result - expected) < 1e-5;
        }

        public double MinAreaFreeRect(int[][] points)
        {
            var n = points.Length;
            var pointsSet = new HashSet<(int X, int Y)>();
            foreach (var point in points)
                pointsSet.Add((point[0], point[1]));
            var result = double.MaxValue;
            for (int i = 0; i < n; ++i)
            {
                var x = points[i];
                for (int j = i + 1; j < n; ++j)
                {
                    var y = points[j];
                    for (int k = j + 1; k < n; ++k)
                    {

                        var z = points[k];
                        var expX = x[0] + y[0] - z[0];
                        var expY = x[1] + y[1] - z[1];
                        if (pointsSet.Contains((expX, expY)) && ((x[0] - z[0]) * (y[0] - z[0]) + (x[1] - z[1]) * (y[1] - z[1])) == 0)
                            result = Math.Min(result,
                                Math.Sqrt((x[0] - z[0]) * (x[0] - z[0]) + (x[1] - z[1]) * (x[1] - z[1])) * Math.Sqrt((y[0] - z[0]) * (y[0] - z[0]) + (y[1] - z[1]) * (y[1] - z[1])));
                    }
                }
            }

            return result == double.MaxValue ? 0 : result;
        }
    }
}
