using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2267 : IProblem
    {
        public bool Test()
        {
            var grid = new[] {new[] {'(', '(', '('}, new[] {')', '(', ')'}, new[] {'(', '(', ')'}, new[] {'(', '(', ')'}};

            var expected = true;

            var result = HasValidPath(grid);

            return expected == result;
        }

        public bool HasValidPath(char[][] grid)
        {
            var n = grid.Length;
            var m = grid[0].Length;
            if (grid[0][0] == ')' || grid[n - 1][m - 1] == '(')
                return false;
            var dp = new HashSet<int>[n][];
            for (int i = 0; i < n; ++i)
            {
                dp[i] = new HashSet<int>[m];
                for (int j = 0; j < m; ++j)
                {
                    dp[i][j] = new HashSet<int>();
                }
            }
            dp[0][0].Add(1);
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < m; ++j)
                {
                    var c = (grid[i][j] == ')' ? -1 : 1);
                    if (i > 0)
                    {
                        foreach (var val in dp[i - 1][j])
                        {
                            var nx = val + c;
                            if (nx >= 0)
                                dp[i][j].Add(nx);
                        }
                    }
                    if (j > 0)
                    {
                        foreach (var val in dp[i][j - 1])
                        {
                            var nx = val + c;
                            if (nx >= 0)
                                dp[i][j].Add(nx);
                        }
                    }

                }
            }

            return dp[n - 1][m - 1].Contains(0);
        }
    }
}
