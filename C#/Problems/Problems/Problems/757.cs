using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _757 : IProblem
    {
        public bool Test()
        {
            var intervals = new[] { new[] { 1, 3 }, new[] { 3, 7 }, new[] { 8, 9 } };

            var expected = 5;

            var result = IntersectionSizeTwo(intervals);

            Console.WriteLine(result);

            return expected == result;
        }

        public int IntersectionSizeTwo(int[][] intervals)
        {
            Array.Sort(intervals, CompareIntervals);
            var suf = new int[] { intervals[0][1] - 1, intervals[0][1] };
            var result = 2;
            foreach (var inter in intervals)
            {
                var start = inter[0];
                var end = inter[1];
                if (start <= suf[0])
                    continue;
                if (start > suf[1])
                {
                    result += 2;
                    suf[0] = end - 1;
                    suf[1] = end;
                }
                else
                {
                    result += 1;
                    suf[0] = suf[1];
                    suf[1] = end;
                }
            }

            return result;
        }

        private int CompareIntervals(int[] int1, int[] int2)
        {
            var cmp = int1[1].CompareTo(int2[1]);
            return cmp == 0 ? int2[0].CompareTo(int1[0]) : cmp;
        }
    }
}
