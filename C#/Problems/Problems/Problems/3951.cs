using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3951 : IProblem
    {
        public bool Test()
        {
            var n = 5;
            var brightness = 5;
            var intervals = new[] { new[] { 6, 12 } };

            var expected = 14;

            var result = MinEnergy(n, brightness, intervals);

            Console.WriteLine(result);

            return result == expected;
        }

        public long MinEnergy(int n, int brightness, int[][] intervals)
        {
            long cost = (brightness + 2) / 3;
            Array.Sort(intervals, Comparer<int[]>.Create((x, y) => (x[0].CompareTo(y[0]) == 0 ? x[1].CompareTo(y[1]) : x[0].CompareTo(y[0]))));
            long result = 0;
            var th = 0;
            foreach (var i in intervals)
            {
                if (th > i[1])
                    continue;
                result += cost * (i[1] - Math.Max(i[0], th) + 1);
                th = i[1] + 1;
            }

            return result;
        }
    }
}
