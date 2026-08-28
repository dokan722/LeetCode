using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1482 : IProblem
    {
        public bool Test()
        {
            var bloomDay = new[] { 1, 10, 3, 10, 2 };
            var m = 3;
            var k = 1;

            var expected = 3;
            
            var result = MinDays(bloomDay, m, k);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MinDays(int[] bloomDay, int m, int k)
        {
            var n = bloomDay.Length;
            if (n < (long)m * k)
                return -1;
            var mx = 0;
            for (int i = 0; i < n; ++i)
                mx = Math.Max(mx, bloomDay[i]);
            var l = 1;
            var r = mx;
            while (l < r)
            {
                var mid = (l + r) / 2;
                var poss = 0;
                var prev = -1;
                for (int i = 0; i < n; ++i)
                {
                    if (bloomDay[i] > mid)
                    {
                        var le = i - prev - 1;
                        poss += le / k;
                        prev = i;
                    }
                }
                poss += (n - prev - 1) / k;
                if (poss >= m)
                    r = mid;
                else
                    l = mid + 1;
            }

            return l;
        }
    }
}
