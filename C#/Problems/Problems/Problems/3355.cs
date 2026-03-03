using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3355 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 4, 3, 2, 1 };
            var queries = new[] { new[] { 1, 3 }, new[] { 0, 2 } };

            var expected = false;

            var result = IsZeroArray(nums, queries);

            return result == expected;
        }
        public bool IsZeroArray(int[] nums, int[][] queries)
        {
            var n = nums.Length;
            var sweepArray = new int[n + 1];
            foreach (var query in queries)
            {
                sweepArray[query[0]]++;
                sweepArray[query[1] + 1]--;
            }
            var curr = 0;
            for (int i = 0; i < n; ++i)
            {
                curr += sweepArray[i];
                if (curr < nums[i])
                    return false;
            }

            return true;
        }
    }
}
