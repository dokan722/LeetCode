using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3502 : IProblem
    {
        public bool Test()
        {
            var cost = new[] { 5, 3, 4, 1, 3, 2 };

            var expected = new[] { 5, 3, 3, 1, 1, 1 };

            var result = MinCosts(cost);

            Utils.Print1DArray(result);

            return Utils.Compare1DArrays(expected, result);
        }

        public int[] MinCosts(int[] cost)
        {
            var n = cost.Length;
            var result = new int[n];
            var min = cost[0];
            for (int i = 0; i < n; ++i)
            {
                min = Math.Min(min, cost[i]);
                result[i] = min;
            }

            return result;
        }
    }
}
