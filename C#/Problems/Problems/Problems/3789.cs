using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3789 : IProblem
    {
        public bool Test()
        {
            int cost1 = 3;
            int cost2 = 2;
            int costBoth = 1;
            int need1 = 3;
            int need2 = 2;

            var expected = 3l;

            var result = MinimumCost(cost1, cost2, costBoth, need1, need2);

            Console.WriteLine(result);

            return result == expected;
        }

        public long MinimumCost(int cost1, int cost2, int costBoth, int need1, int need2)
        {
            if (costBoth < cost1 && costBoth < cost2)
                return (long)costBoth * Math.Max(need1, need2);
            if (cost1 + cost2 < costBoth)
                return (long)cost1 * need1 + (long)cost2 * need2;
            if (need1 < need2)
                return (long)costBoth * need1 + (long)Math.Min(costBoth, cost2) * (need2 - need1);
            return (long)costBoth * need2 + (long)Math.Min(costBoth, cost1) * (need1 - need2);
        }
    }
}
