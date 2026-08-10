using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _576 : IProblem
    {
        public bool Test()
        {
            var m = 2;
            var n = 2;
            var maxMove = 2;
            var startRow = 0;
            var startColumn = 0;

            var expected = 6;

            var result = FindPaths(m, n, maxMove, startRow, startColumn);

            Console.WriteLine(result);

            return result == expected;
        }

        public int FindPaths(int m, int n, int maxMove, int startRow, int startColumn)
        {
            var cur = new long[m][];
            for (int i = 0; i < m; ++i)
                cur[i] = new long[n];
            cur[startRow][startColumn] = 1;
            long result = 0;
            var mod = 1000000007;
            for (int i = 0; i < maxMove; ++i)
            {
                for (int j = 0; j < m; ++j)
                    result = (result + cur[j][0] + cur[j][n - 1]) % mod;
                for (int j = 0; j < n; ++j)
                    result = (result + cur[0][j] + cur[m - 1][j]) % mod;
                var next = new long[m][];
                for (int j = 0; j < m; ++j)
                    next[j] = new long[n];
                for (int j = 0; j < m; ++j)
                {
                    for (int k = 0; k < n; ++k)
                    {
                        var up = j > 0 ? cur[j - 1][k] : 0;
                        var down = j < m - 1 ? cur[j + 1][k] : 0;
                        var left = k > 0 ? cur[j][k - 1] : 0;
                        var right = k < n - 1 ? cur[j][k + 1] : 0;
                        next[j][k] = (up + down + left + right) % mod;
                    }
                }
                cur = next;
            }

            return (int)result;
        }
    }
}
