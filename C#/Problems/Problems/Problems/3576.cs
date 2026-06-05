using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3576 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 1, -1, 1, -1, 1 };
            var k = 3;

            var expected = true;

            var result = CanMakeEqual(nums, k);

            return result == expected;
        }

        public bool CanMakeEqual(int[] nums, int k)
        {
            var n = nums.Length;
            var opsNeg = 0;
            var opsPos = 0;
            var nextNeg = nums[0];
            var nextPos = nums[0];
            for (int i = 0; i < n - 1; ++i)
            {
                if (nextPos == -1)
                {
                    nextPos = nums[i + 1] * -1;
                    opsPos++;
                }
                else
                    nextPos = nums[i + 1];
                if (nextNeg == 1)
                {
                    nextNeg = nums[i + 1] * -1;
                    opsNeg++;
                }
                else
                    nextNeg = nums[i + 1];
                if (opsPos > k && opsNeg > k)
                    return false;
            }

            return (opsPos <= k && nextPos == 1) || (opsNeg <= k && nextNeg == -1);
        }
    }
}
