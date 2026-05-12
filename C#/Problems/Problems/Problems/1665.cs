using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1665 : IProblem
    {
        public bool Test()
        {
            var tasks = new[] { new[] { 1, 2 }, new[] { 2, 4 }, new[] { 4, 8 } };

            var expected = 8;

            var result = MinimumEffort(tasks);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MinimumEffort(int[][] tasks)
        {
            var n = tasks.Length;
            Array.Sort(tasks, (x, y) => (y[1] - y[0]).CompareTo(x[1] - x[0]));
            var total = 0;
            for (int i = 0; i < n; ++i)
                total += tasks[i][0];
            var cur = total;
            var result = total;
            for (int i = 0; i < n; ++i)
            {
                var t = tasks[i];
                result += Math.Max(0, t[1] - cur);
                cur = Math.Max(cur, t[1]);
                cur -= t[0];
            }
            return result;
        }
    }
}
