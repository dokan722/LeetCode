using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _539 : IProblem
    {
        public bool Test()
        {
            var timePoints = new[] { "23:59", "00:00" };

            var expected = 1;

            var result = FindMinDifference(timePoints);

            Console.WriteLine(result);

            return result == expected;
        }

        public int FindMinDifference(IList<string> timePoints)
        {
            var total = 24 * 60;
            var pres = new bool[total];
            foreach (var t in timePoints)
            {
                var minutes = 600 * (t[0] - '0') + 60 * (t[1] - '0') + 10 * (t[3] - '0') + (t[4] - '0');
                if (pres[minutes])
                    return 0;
                pres[minutes] = true;
            }
            var l = 0;
            while (!pres[l])
                l++;
            var r = total - 1;
            while (!pres[r])
                r--;
            var result = l + total - r;
            var prev = l;
            for (int i = l + 1; i <= r; ++i)
            {
                if (pres[i])
                {
                    result = Math.Min(result, i - prev);
                    prev = i;
                }
            }

            return result;
        }
    }
}
