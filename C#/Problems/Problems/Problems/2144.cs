using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2144 : IProblem
    {
        public bool Test()
        {
            var cost = new[] { 1, 2, 3 };

            var expected = 5;

            var result = MinimumCost(cost);

            Console.WriteLine(result);

            return result == expected;
        }
        public int MinimumCost(int[] cost)
        {
            var n = cost.Length;
            Array.Sort(cost);
            var free = n % 3;
            var result = 0;
            for (int i = 0; i < n; ++i)
            {
                if (i % 3 != free)
                    result += cost[i];
            }

            return result;
        }

    }
}
