using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3882 : IProblem
    {
        public bool Test()
        {
            var grid = new[] { new[] { 2, 22, 7 }, new[] { 21, 17, 8 } };

            var expected = 13;

            var result = MinCost(grid);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MinCost(int[][] grid)
        {
            var n = grid.Length;
            var m = grid[0].Length;
            var dp = new HashSet<int>[m];
            dp[0] = new HashSet<int> { grid[0][0] };
            for (int i = 1; i < m; ++i)
                dp[i] = new HashSet<int> { grid[0][i] ^ dp[i - 1].First() };
            for (int i = 1; i < n; ++i)
            {
                dp[0] = new HashSet<int> { grid[i][0] ^ dp[0].First() };
                for (int j = 1; j < m; ++j)
                {
                    var next = new HashSet<int>();
                    foreach (var val in dp[j - 1])
                        next.Add(val ^ grid[i][j]);
                    foreach (var val in dp[j])
                        next.Add(val ^ grid[i][j]);
                    dp[j] = next;
                }
            }
            var result = int.MaxValue;
            foreach (var val in dp[m - 1])
                result = Math.Min(result, val);
            return result;
        }
    }
}
