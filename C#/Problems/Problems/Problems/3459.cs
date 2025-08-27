using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3459 : IProblem
    {
        public bool Test()
        {
            var grid = new[] {new[] {2, 2, 2, 2, 2}, new[] {2, 0, 2, 2, 0}, new[] {2, 0, 1, 1, 0}, new[] {1, 0, 2, 2, 2}, new[] {2, 0, 0, 2, 2}};

            var expected = 4;

            var result = LenOfVDiagonal(grid);

            Console.WriteLine(result);

            return expected == result;
        }

        private Dictionary<(int, int), (int, int)> _turns = new Dictionary<(int, int), (int, int)>()
        {
            { (1, 1), (1, -1) },
            { (1, -1), (-1, -1) },
            { (-1, -1), (-1, 1) },
            { (-1, 1), (1, 1) },
        };

        public int LenOfVDiagonal(int[][] grid)
        {
            var result = 0;
            var n = grid.Length;
            var m = grid[0].Length;
            foreach (var dir in _turns.Keys)
            {
                var dpWithTurn = new int[n][];
                var dpWithoutTurn = new int[n][];
                for (int i = 0; i < n; i++)
                {
                    dpWithTurn[i] = Enumerable.Repeat(-1, m).ToArray();
                    dpWithoutTurn[i] = Enumerable.Repeat(-1, m).ToArray();
                }

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        if (grid[i][j] == 1)
                            result = Math.Max(result, 1 + Dfs(grid, dpWithTurn, dpWithoutTurn, n, m, i + dir.Item1, j + dir.Item2, dir.Item1, dir.Item2, 0, true));
                    }
                }
            }

            return result;
        }

        private int Dfs(int[][] grid, int[][] dpWithTurn, int[][] dpNoTurn, int n, int m, int x, int y, int ver, int hor, int prev, bool haveMove)
        {
            if (x < 0 || x >= n || y < 0 || y >= m || grid[x][y] == 1 || prev == grid[x][y])
                return 0;
            if (haveMove && dpWithTurn[x][y] != -1)
                return dpWithTurn[x][y];
            if (!haveMove && dpNoTurn[x][y] != -1)
                return dpNoTurn[x][y];

            var notTurn = 1 + Dfs(grid, dpWithTurn, dpNoTurn, n, m, x + ver, y + hor, ver, hor, grid[x][y], haveMove);
            if (!haveMove)
            {
                dpNoTurn[x][y] = notTurn;
                return dpNoTurn[x][y];
            }

            (ver, hor) = _turns[(ver, hor)];
            var turn = 1 + Dfs(grid, dpWithTurn, dpNoTurn, n, m, x + ver, y + hor, ver, hor, grid[x][y], false);
            dpWithTurn[x][y] = turn;

            return Math.Max(notTurn, turn);
        }
    }
}
