using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3623 : IProblem
    {
        public bool Test()
        {
            var points = new[] { new[] { 1, 0 }, new[] { 2, 0 }, new[] { 3, 0 }, new[] { 2, 2 }, new[] { 3, 2 } };

            var expected = 3;

            var result = CountTrapezoids(points);

            Console.WriteLine(result);

            return result == expected;
        }

        public int CountTrapezoids(int[][] points)
        {
            var counts = new Dictionary<int, long>();
            var mod = 1000000007;
            foreach (var point in points)
            {
                if (counts.ContainsKey(point[1]))
                    counts[point[1]]++;
                else
                    counts[point[1]] = 1;
            }

            long s = 0;
            long result = 0;
            foreach (var count in counts)
            {
                var pairs = count.Value * (count.Value - 1) / 2;
                result = (result + pairs * s) % mod;
                s = (s + pairs) % mod;
            }

            return (int)result;
        }
    }
}
