using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3349 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 2, 5, 7, 8, 9, 2, 3, 4, 3, 1 };
            var k = 3;

            var expected = true;

            var result = HasIncreasingSubarrays(nums, k);

            return expected == result;
        }

        public bool HasIncreasingSubarrays(IList<int> nums, int k)
        {
            if (k == 1)
                return true;
            var n = nums.Count;
            var firstFound = false;
            var len = 1;
            for (int i = 1; i < n; ++i)
            {
                if (nums[i] <= nums[i - 1])
                {
                    if (len < k)
                        firstFound = false;
                    len = 0;
                }

                len++;
                if (len % k == 0)
                {
                    if (firstFound)
                        return true;
                    firstFound = true;
                }
            }

            return false;
        }
    }
}
