using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1288 : IProblem
    {
        public bool Test()
        {
            var intervals = new[] { new[] { 1, 4 }, new[] { 3, 6 }, new[] { 2, 8 } };

            var expected = 2;

            var result = RemoveCoveredIntervals(intervals);

            Console.WriteLine(result);

            return result == expected;
        }

        public int RemoveCoveredIntervals(int[][] intervals)
        {
            Array.Sort(intervals, CompareInts);
            var end = -1;
            var result = 0;
            foreach (var interval in intervals)
            {
                if (interval[1] > end)
                {
                    end = interval[1];
                    result++;
                }
            }

            return result;
        }

        private int CompareInts(int[] x, int[] y)
        {
            var cmpStart = x[0].CompareTo(y[0]);
            if (cmpStart != 0)
                return cmpStart;
            return y[1].CompareTo(x[1]);
        }
    }
}
