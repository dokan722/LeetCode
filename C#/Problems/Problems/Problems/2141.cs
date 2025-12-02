using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2141 : IProblem
    {
        public bool Test()
        {
            var n = 2;
            var batteries = new[] { 3, 3, 3 };

            var expected = 4;

            var result = MaxRunTime(n, batteries);

            Console.WriteLine(result);

            return expected == result;
        }

        public long MaxRunTime(int n, int[] batteries)
        {
            var m = batteries.Length;
            Array.Sort(batteries);
            var start = m - n;
            long restSum = 0;
            for (int i = 0; i < start; ++i)
                restSum += batteries[i];

            for (int i = start; i < m - 1; ++i)
            {
                long toFill = (batteries[i + 1] - batteries[i]) * (i - start + 1);
                if (restSum > toFill)
                    restSum -= toFill;
                else
                    return batteries[i] + restSum / (i - start + 1);
            }

            return batteries[m - 1] + restSum / n;
        }
    }
}
