using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3254 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 1, 2, 3, 4, 3, 2, 5 };
            var k = 3;

            var expected = new[] { 3, 4, -1, -1, -1 };

            var result = ResultsArray(nums, k);

            Utils.Print1DArray(result);

            return Utils.Compare1DArrays(result, expected);
        }

        public int[] ResultsArray(int[] nums, int k)
        {
            var n = nums.Length;
            if (k == 1)
                return nums;
            var result = new int[n - k + 1];
            var cur = 1;
            for (int i = 1; i < n; ++i)
            {
                if (nums[i] == nums[i - 1] + 1)
                    cur++;
                else
                    cur = 1;
                if (i >= k - 1)
                {
                    if (cur >= k)
                        result[i - k + 1] = nums[i];
                    else
                        result[i - k + 1] = -1;
                }
            }

            return result;
        }
    }
}
