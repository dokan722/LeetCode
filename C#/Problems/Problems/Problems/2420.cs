using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2420 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 2, 1, 1, 1, 3, 4, 1 };
            var k = 2;

            var expected = new[] { 2, 3 };

            var result = GoodIndices(nums, k);

            Utils.Print1DArray(result);

            return Utils.Compare1DArrays(expected, result);
        }

        public IList<int> GoodIndices(int[] nums, int k)
        {
            var n = nums.Length;
            var to = new int[n];
            var cur = 1;
            for (int i = n - 2; i >= 0; --i)
            {
                to[i] = cur;
                if (nums[i] <= nums[i + 1])
                    cur++;
                else
                    cur = 1;
            }
            var result = new List<int>();
            cur = 1;
            for (int i = 1; i < n; ++i)
            {
                if (to[i] >= k && cur >= k)
                    result.Add(i);
                if (nums[i - 1] >= nums[i])
                    cur++;
                else
                    cur = 1;
            }

            return result;
        }
    }
}
