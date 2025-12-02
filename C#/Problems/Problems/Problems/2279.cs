using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2279 : IProblem
    {
        public bool Test()
        {
            var capacity = new[] { 2, 3, 4, 5 };
            var rocks = new[] { 1, 2, 4, 4 };
            var additionalRocks = 2;

            var expected = 3;

            var result = MaximumBags(capacity, rocks, additionalRocks);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MaximumBags(int[] capacity, int[] rocks, int additionalRocks)
        {
            var n = capacity.Length;
            var space = new int[n];
            for (int i = 0; i < n; ++i)
            {
                space[i] = capacity[i] - rocks[i];
            }
            Array.Sort(space);
            var result = 0;
            for (int i = 0; i < n; ++i)
            {
                if (space[i] == 0 || additionalRocks >= space[i])
                {
                    additionalRocks -= space[i];
                    result++;
                }
                else
                {
                    return result;
                }
            }

            return result;
        }
    }
}
