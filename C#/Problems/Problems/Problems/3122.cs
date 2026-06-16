using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3122 : IProblem
    {
        public bool Test()
        {
            var grid = new[] { new[] { 1, 0, 2 }, new[] { 1, 0, 2 } };

            var expected = 0;

            var result = MinimumOperations(grid);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MinimumOperations(int[][] grid)
        {
            var cap = 10;
            var n = grid.Length;
            var m = grid[0].Length;
            var dp = new int[cap];
            for (int i = 0; i < m; ++i)
            {
                var counts = new int[cap];
                for (int j = 0; j < n; ++j)
                    counts[grid[j][i]]++;
                var next = new int[cap];
                for (int j = 0; j < cap; ++j)
                {
                    var best = int.MaxValue;
                    for (int k = 0; k < cap; ++k)
                    {
                        if (k != j)
                            best = Math.Min(best, dp[k] + (n - counts[k]));
                    }
                    next[j] = best;
                }
                dp = next;
            }
            var result = int.MaxValue;
            for (int i = 0; i < cap; ++i)
                result = Math.Min(dp[i], result);
            return result;
        }
    }
}
