using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2240 : IProblem
    {
        public bool Test()
        {
            var total = 20;
            var cost1 = 10;
            var cost2 = 5;

            var expected = 9;

            var result = WaysToBuyPensPencils(total, cost1, cost2);

            Console.WriteLine(result);

            return result == expected;
        }

        public long WaysToBuyPensPencils(int total, int cost1, int cost2)
        {
            long result = 0;
            var big = Math.Max(cost1, cost2);
            var smol = Math.Min(cost1, cost2);
            for (int i = 0; i <= total / big; ++i)
            {
                result += (total - big * i) / smol + 1;
            }

            return result;
        }
    }
}
