using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3567 : IProblem
    {
        public bool Test()
        {
            var grid = new[] { new[] { 1, 8 }, new[] { 3, -2 } };
            var k = 2;

            var expected = new[] { new[] { 2 } };

            var result = MinAbsDiff(grid, k);

            Utils.Print2DArray(result);

            return Utils.Compare2DArrays(expected, result);
        }

        public int[][] MinAbsDiff(int[][] grid, int k)
        {
            int m = grid.Length, n = grid[0].Length;
            int[][] result = new int[m - k + 1][];
            for (int i = 0; i < m - k + 1; i++)
                result[i] = new int[n - k + 1];

            for (int i = 0; i + k <= m; i++)
            {
                for (int j = 0; j + k <= n; j++)
                {
                    List<int> elems = new List<int>();
                    for (int l = i; l < i + k; l++)
                    {
                        for (int o = j; o < j + k; o++)
                        {
                            elems.Add(grid[l][o]);
                        }
                    }
                    int smallest = int.MaxValue;
                    elems.Sort();
                    for (int t = 1; t < elems.Count; t++)
                    {
                        if (elems[t] == elems[t - 1])
                            continue;
                        smallest = Math.Min(smallest, elems[t] - elems[t - 1]);
                    }
                    result[i][j] = smallest == int.MaxValue ? 0 : smallest;
                }
            }
            return result;
        }
    }
}
