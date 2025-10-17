using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3462 : IProblem
    {
        public bool Test()
        {
            var grid = new[] { new[] { 5, 3, 7 }, new[] { 8, 2, 6 } };
            var limits = new[] { 2, 2 };
            var k = 3;

            var expected = 21;

            var result = MaxSum(grid, limits, k);

            Console.WriteLine(result);

            return result == expected;
        }
        public long MaxSum(int[][] grid, int[] limits, int k)
        {
            var n = grid.Length;
            var m = grid[0].Length;
            var que = new PriorityQueue<int, int>(Comparer<int>.Create((x, y) => y.CompareTo(x)));
            for (int i = 0; i < n; ++i)
                for (int j = 0; j < m; ++j)
                    que.Enqueue(i, grid[i][j]);
            var filled = new int[n];
            var taken = 0;
            var result = 0;
            while (que.TryDequeue(out var row, out var value) && taken < k)
            {
                if (filled[row] < limits[row])
                {
                    result += value;
                    filled[row]++;
                    taken++;
                }
            }

            return result;
        }
    }
}
