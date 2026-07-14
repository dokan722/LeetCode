using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3169 : IProblem
    {
        public bool Test()
        {
            var days = 10;
            var meetings = new[] { new int[] { 5, 7 }, new[] { 1, 3 }, new[] { 9, 10 } };

            var expected = 2;

            var result = CountDays(days, meetings);

            Console.WriteLine(result);

            return result == expected;
        }

        public int CountDays(int days, int[][] meetings)
        {
            var ordered = meetings.OrderBy(x => x[0]).ToArray();
            var cur = 1;
            var result = 0;
            foreach (var m in ordered)
            {
                if (m[0] > cur)
                    result += m[0] - cur;
                cur = Math.Max(cur, m[1] + 1);
            }
            result += days - cur + 1;
            return result;
        }
    }
}
