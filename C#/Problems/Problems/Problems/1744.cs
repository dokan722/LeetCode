using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1744 : IProblem
    {
        public bool Test()
        {
            var candiesCount = new[] { 7, 4, 5, 3, 8 };
            var queries = new[] { new[] { 0, 2, 2 }, new[] { 4, 2, 4 }, new[] { 2, 13, 1000000000 } };

            var expected = new[] { true, false, true };

            var result = CanEat(candiesCount, queries);

            Utils.Print1DArray(result);

            return Utils.Compare1DArrays(expected, result);
        }

        public bool[] CanEat(int[] candiesCount, int[][] queries)
        {
            var n = candiesCount.Length;
            var pref = new long[n + 1];
            for (int i = 0; i < n; ++i)
                pref[i + 1] = pref[i] + candiesCount[i];
            var m = queries.Length;
            var result = new bool[m];
            for (int i = 0; i < m; ++i)
            {
                long type = queries[i][0];
                long day = queries[i][1] + 1;
                long cap = queries[i][2];
                if (pref[type] < day * cap && pref[type + 1] >= day)
                    result[i] = true;
                else
                    result[i] = false;
            }

            return result;
        }
    }
}
