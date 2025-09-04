using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1029 : IProblem
    {
        public bool Test()
        {
            var costs = new[] {new[] {259, 770}, new[] {448, 54}, new[] {926, 667}, new[] {184, 139}, new[] {840, 118}, new[] {577, 469}};

            var expected = 1859;

            var result = TwoCitySchedCost(costs);

            Console.Write(result);

            return expected == result;
        }

        public int TwoCitySchedCost(int[][] costs)
        {
            var n = costs.Length / 2;
            Array.Sort(costs, Comparer<int[]>.Create((x, y) => (x[0] - x[1]).CompareTo(y[0] - y[1])));
            var result = 0;
            for (int i = 0; i < n; ++i)
                result += costs[i][0] + costs[n + i][1];
            return result;
        }
    }
}
