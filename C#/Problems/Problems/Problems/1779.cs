using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1779 : IProblem
    {
        public bool Test()
        {
            var x = 3;
            var y = 4;

            var points = new[] { new[] { 1, 2 }, new[] { 3, 1 }, new[] { 2, 4 }, new[] { 2, 3 }, new[] { 4, 4 } };

            var expected = 2;

            var result = NearestValidPoint(x, y, points);

            Console.WriteLine(result);

            return expected == result;
        }

        public int NearestValidPoint(int x, int y, int[][] points)
        {
            var minDist = int.MaxValue;
            var result = -1;
            for (int i = 0; i < points.Length; i++)
            {
                if (x != points[i][0] && y != points[i][1])
                    continue;
                var dist = Math.Abs(x - points[i][0]) + Math.Abs(y - points[i][1]);
                if (dist < minDist)
                {
                    result = i;
                    minDist = dist;
                }
            }

            return result;
        }
    }
}
