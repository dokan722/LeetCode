using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _447 : IProblem
    {
        public bool Test()
        {
            var points = new[] { new[] { 0, 0 }, new[] { 1, 0 }, new[] { 2, 0 } };

            var expected = 2;

            var result = NumberOfBoomerangs(points);

            Console.WriteLine(result);

            return result == expected;
        }
        public int NumberOfBoomerangs(int[][] points)
        {
            var n = points.Length;
            var dists = new Dictionary<int, int>();
            var result = 0;
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    var x = points[i][0] - points[j][0];
                    var y = points[i][1] - points[j][1];
                    var dist = x * x + y * y;
                    if (dists.ContainsKey(dist))
                    {
                        result += 2 * dists[dist];
                        dists[dist]++;
                    }
                    else
                        dists[dist] = 1;
                }
                dists.Clear();
            }

            return result;
        }
    }
}
