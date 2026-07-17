using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3312 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 2, 3, 4 };
            var queries = new long[] { 0, 2, 2 };

            var expected = new[] { 1, 2, 2 };

            var result = GcdValues(nums, queries);

            Utils.Print1DArray(result);

            return Utils.Compare1DArrays(expected, result);
        }

        public int[] GcdValues(int[] nums, long[] queries)
        {
            var n = nums.Length;
            var mx = 0;
            for (int i = 0; i < n; ++i)
                mx = Math.Max(mx, nums[i]);
            var freqs = new int[mx + 1];
            for (int i = 0; i < n; ++i)
                freqs[nums[i]]++;
            var gcds = new long[mx + 1];
            for (int i = mx; i > 0; --i)
            {
                long pairs = 0;
                long bigger = 0;
                for (int j = i; j <= mx; j += i)
                {
                    pairs += freqs[j];
                    bigger += gcds[j];
                }
                gcds[i] = pairs * (pairs - 1) / 2 - bigger;
            }
            for (int i = 1; i <= mx; ++i)
                gcds[i] += gcds[i - 1];
            var m = queries.Length;
            var result = new int[m];

            for (int i = 0; i < m; ++i)
            {
                var l = 0;
                var r = mx;
                var val = queries[i] + 1;
                while (l < r)
                {
                    var mid = (l + r) / 2;
                    if (gcds[mid] < val)
                        l = mid + 1;
                    else
                        r = mid;
                }

                result[i] = l;
            }

            return result;
        }
    }
}
