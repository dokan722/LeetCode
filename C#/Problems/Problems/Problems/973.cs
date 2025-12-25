using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _973 : IProblem
    {
        public bool Test()
        {
            var points = new[] { new[] { 1, 3 }, new[] { -2, 2 } };
            var k = 1;

            var expected = new[] { new[] { -2, 2 } };

            var result = KClosest(points, k);

            Utils.Print2DArray(result);

            return Utils.Compare2DArrays(expected, result);
        }

        public int[][] KClosest(int[][] points, int k)
        {
            Array.Sort(points, Comparer<int[]>.Create((x, y) => (x[0] * x[0] + x[1] * x[1]).CompareTo(y[0] * y[0] + y[1] * y[1])));

            var result = new int[k][];
            for (int i = 0; i < k; ++i)
                result[i] = points[i];

            return result;
        }
    }
}
