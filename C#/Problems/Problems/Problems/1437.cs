using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1437 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 1, 0, 0, 0, 1, 0, 0, 1 };
            var k = 2;

            var expected = true;

            var result = KLengthApart(nums, k);

            return result == expected;
        }

        public bool KLengthApart(int[] nums, int k)
        {
            var n = nums.Length;
            var last = -1000000;
            for (int i = 0; i < n; ++i)
            {
                if (nums[i] == 1)
                {
                    if (i - last - 1 < k)
                        return false;
                    last = i;
                }
            }

            return true;
        }
    }
}
