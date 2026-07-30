using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1052 : IProblem
    {
        public bool Test()
        {
            var customers = new[] { 1, 0, 1, 2, 1, 1, 7, 5 };
            var grumpy = new[] { 0, 1, 0, 1, 0, 1, 0, 1 };
            var minutes = 3;

            var expected = 16;

            var result = MaxSatisfied(customers, grumpy, minutes);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MaxSatisfied(int[] customers, int[] grumpy, int minutes)
        {
            var n = customers.Length;
            var satisfied = 0;
            var grumpies = 0;
            var best = 0;
            for (int i = 0; i < n; ++i)
            {
                if (grumpy[i] == 0)
                    satisfied += customers[i];
                else
                    grumpies += customers[i];
                if (i >= minutes && grumpy[i - minutes] == 1)
                    grumpies -= customers[i - minutes];
                best = Math.Max(best, grumpies);
            }

            return satisfied + best;
        }
    }
}
