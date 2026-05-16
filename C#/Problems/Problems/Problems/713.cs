using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _713 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 10, 5, 2, 6 };
            var k = 100;

            var expected = 8;

            var result = NumSubarrayProductLessThanK(nums, k);

            Console.WriteLine(result);

            return result == expected;
        }

        public int NumSubarrayProductLessThanK(int[] nums, int k)
        {
            if (k < 2)
                return 0;
            var n = nums.Length;
            var l = 0;
            var result = 0;
            long cur = 1;
            for (int i = 0; i < n; ++i)
            {
                cur *= nums[i];
                while (l < n && cur >= k)
                {
                    cur /= nums[l];
                    l++;
                }
                result += i - l + 1;
            }

            return result;
        }
    }
}
