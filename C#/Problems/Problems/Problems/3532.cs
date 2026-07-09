using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3532 : IProblem
    {
        public bool Test()
        {
            var n = 2;
            var nums = new[] { 1, 3 };
            var maxDiff = 1;
            var queries = new[] { new[] { 0, 0 }, new[] { 0, 1 } };

            var expected = new[] { true, false };

            var result = PathExistenceQueries(n, nums, maxDiff, queries);

            Utils.Print1DArray(result);

            return Utils.Compare1DArrays(expected, result);
        }

        public bool[] PathExistenceQueries(int n, int[] nums, int maxDiff, int[][] queries)
        {
            var clusts = new int[n];
            var cur = 0;
            for (int i = 1; i < n; ++i)
            {
                if (nums[i - 1] + maxDiff < nums[i])
                    cur++;
                clusts[i] = cur;
            }
            var m = queries.Length;
            var result = new bool[m];
            for (int i = 0; i < m; ++i)
            {
                var q = queries[i];
                result[i] = clusts[q[0]] == clusts[q[1]];
            }

            return result;
        }
    }
}
