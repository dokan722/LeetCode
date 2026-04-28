using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2033 : IProblem
    {
        public bool Test()
        {
            var grid = new[] { new[] { 2, 4 }, new[] { 6, 8 } };
            var x = 2;

            var expected = 4;

            var result = MinOperations(grid, x);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MinOperations(int[][] grid, int x)
        {
            var n = grid.Length;
            var m = grid[0].Length;
            var exp = grid[0][0] % x;
            var freqs = new int[100001 / x + 1];
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < m; ++j)
                {
                    if (grid[i][j] % x != exp)
                        return -1;
                    freqs[grid[i][j] / x]++;
                }
            }
            var mid = (m * n + 1) / 2;
            var count = 0;
            var median = 0;
            for (int i = 0; i < freqs.Length; ++i)
            {
                count += freqs[i];
                if (count >= mid)
                {
                    median = i;
                    break;
                }
            }
            var result = 0;
            for (int i = 0; i < freqs.Length; ++i)
            {
                result += Math.Abs(i - median) * freqs[i];
            }

            return result;
        }
    }
}
