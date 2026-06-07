using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1094 : IProblem
    {
        public bool Test()
        {
            var trips = new[] { new[] { 2, 1, 5 }, new[] { 3, 3, 7 } };
            var capacity = 4;

            var expected = false;

            var result = CarPooling(trips, capacity);

            return expected == result;
        }

        public bool CarPooling(int[][] trips, int capacity)
        {
            var sweep = new int[1002];
            var end = 0;
            foreach (var t in trips)
            {
                sweep[t[1]] += t[0];
                sweep[t[2]] -= t[0];
                end = Math.Max(end, t[2]);
            }
            var cur = 0;
            for (int i = 0; i <= end; ++i)
            {
                cur += sweep[i];
                if (cur > capacity)
                    return false;
            }

            return true;
        }
    }
}
