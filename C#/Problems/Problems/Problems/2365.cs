using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2365 : IProblem
    {
        public bool Test()
        {
            var tasks = new[] { 1, 2, 1, 2, 3, 1 };
            var space = 3;

            var expected = 9;

            var result = TaskSchedulerII(tasks, space);

            Console.WriteLine(result);

            return result == expected;
        }

        public long TaskSchedulerII(int[] tasks, int space)
        {
            long result = 0;
            var th = new Dictionary<int, long>();
            foreach (var t in tasks)
            {
                if (!th.ContainsKey(t))
                    th[t] = 0L;
                result = Math.Max(th[t], result) + 1;
                th[t] = result + space;
            }

            return result;
        }
    }
}
