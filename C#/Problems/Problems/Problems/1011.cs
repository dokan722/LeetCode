using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1011 : IProblem
    {
        public bool Test()
        {
            var weights = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var days = 5;

            var expected = 15;

            var result = ShipWithinDays(weights, days);

            Console.WriteLine(result);

            return result == expected;
        }

        public int ShipWithinDays(int[] weights, int days)
        {
            var n = weights.Length;
            var l = 0;
            var r = 0;
            foreach (var num in weights)
            {
                l = Math.Max(num, l);
                r += num;
            }
            while (l < r)
            {
                var mid = (l + r) / 2;
                int cur = 0;
                for (int i = 0; i < days; ++i)
                {
                    var pack = 0;
                    while (cur < n && pack + weights[cur] <= mid)
                    {
                        pack += weights[cur];
                        cur++;
                    }
                    if (cur >= n)
                        break;
                }
                if (cur >= n)
                    r = mid;
                else
                    l = mid + 1;
            }

            return l;
        }
    }
}
