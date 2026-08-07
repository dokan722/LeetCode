using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1310 : IProblem
    {
        public bool Test()
        {
            var arr = new[] { 1, 3, 4, 8 };
            var queries = new[] { new[] { 0, 1 }, new[] { 1, 2 }, new[] { 0, 3 }, new[] { 3, 3 } };

            var expected = new[] { 2, 7, 14, 8 };

            var result = XorQueries(arr, queries);

            Utils.Print1DArray(result);

            return Utils.Compare1DArrays(expected, result);
        }

        public int[] XorQueries(int[] arr, int[][] queries)
        {
            var n = arr.Length;
            var pref = new int[n + 1];
            for (int i = 0; i < n; ++i)
                pref[i + 1] = pref[i] ^ arr[i];
            var m = queries.Length;
            var result = new int[m];
            for (int i = 0; i < m; ++i)
            {
                result[i] = pref[queries[i][0]] ^ pref[queries[i][1] + 1];
            }

            return result;
        }
    }
}
