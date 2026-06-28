using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3152 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 3, 4, 1, 2, 6 };
            var queries = new[] { new[] { 0, 4 } };

            var expected = new[] { false };

            var result = IsArraySpecial(nums, queries);

            Utils.Print1DArray(result);

            return Utils.Compare1DArrays(result, expected);
        }

        public bool[] IsArraySpecial(int[] nums, int[][] queries)
        {
            var n = nums.Length;
            var lastSame = new int[n];
            for (int i = 1; i < n; ++i)
            {
                if (nums[i] % 2 == nums[i - 1] % 2)
                    lastSame[i] = i;
                else
                    lastSame[i] = lastSame[i - 1];
            }

            var m = queries.Length;
            var result = new bool[m];
            for (int i = 0; i < m; ++i)
            {
                if (lastSame[queries[i][1]] <= queries[i][0])
                    result[i] = true;
            }

            return result;
        }
    }
}
