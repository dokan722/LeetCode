using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2536 : IProblem
    {
        public bool Test()
        {
            var n = 3;
            var queries = new[] { new[] { 1, 1, 2, 2 }, new[] { 0, 0, 1, 1 } };

            var expected = new[] { new[] { 1, 1, 0 }, new[] { 1, 2, 1 }, new[] { 0, 1, 1 } };

            var result = RangeAddQueries(n, queries);

            Utils.Print2DArray(result);

            return Utils.Compare2DArrays(expected, result);
        }
        public int[][] RangeAddQueries(int n, int[][] queries)
        {
            var ranges = new int[n + 1][];
            for (int i = 0; i <= n; ++i)
                ranges[i] = new int[n + 1];
            foreach (var query in queries)
            {
                ranges[query[0]][query[3] + 1]--;
                ranges[query[2] + 1][query[1]]--;
                ranges[query[0]][query[1]]++;
                ranges[query[2] + 1][query[3] + 1]++;
            }
            var result = new int[n][];
            for (int i = 0; i < n; ++i)
                result[i] = new int[n];
            result[0][0] = ranges[0][0];
            for (int i = 1; i < n; ++i)
            {
                result[0][i] = result[0][i - 1] + ranges[0][i];
                result[i][0] = result[i - 1][0] + ranges[i][0];
            }

            for (int i = 1; i < n; ++i)
            {
                for (int j = 1; j < n; ++j)
                {
                    result[i][j] = result[i][j - 1] + result[i - 1][j] + ranges[i][j] - result[i - 1][j - 1];
                }
            }

            return result;
        }
    }
}
